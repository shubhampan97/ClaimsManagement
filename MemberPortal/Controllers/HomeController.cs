using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MemberPortal.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MemberMicroservice.Models;
using System.Text;
using System.Net;

namespace MemberPortal.Controllers
{


    public class HomeController : Controller
    {


        private static int count = 1;
        private static MockDatabase _dataPolicy=new MockDatabase();
        private static MockDatabasePolicy _newDataPolicy = new MockDatabasePolicy();
        private readonly MockDbContext _context;
        private readonly MockDbPolicyContext _con;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(HomeController));
        

        public HomeController(MockDbContext context )
        {
            _context = context;
            //_con = con;
          
        }

        public IActionResult Index()
        {
            if(CheckStatus())
            {
                _log4net.Info(nameof(Index)+" method invoked.");
                ViewBag.UserName = HttpContext.Session.GetString("Username");
                _log4net.Info(ViewBag.UserName + " logged in.");
                return View();
            }
                
            return RedirectToAction("Index", "Login");
        }

        public IActionResult Admin()
        {
            if (CheckStatus())
            {
                _log4net.Info(nameof(Admin) + " method invoked.");
                ViewBag.UserName = HttpContext.Session.GetString("Username");
                _log4net.Info(ViewBag.UserName + " logged in.");
                return View();
            }

            return RedirectToAction("Index", "Login");
        }


        private bool CheckStatus()
        {
            if (HttpContext.Session.GetString("Username") != null)
                return true;
            return false;
        }

        public IActionResult ViewBill()
        {
            try
            {
                if (CheckStatus())
                {
                    if (_dataPolicy.PolicyID != 0)
                    {
                        _log4net.Info(nameof(ViewBill) + " method invoked!");
                        using (var client = new HttpClient())
                        {
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = new HttpResponseMessage();
                            response = client.GetAsync("https://localhost:44355/api/Members/viewBills?policyID=" + _dataPolicy.PolicyID + "&memberID=" + _dataPolicy.MemberID).Result;
                            var data = JsonConvert.DeserializeObject<MemberPremium>(response.Content.ReadAsStringAsync().Result);

                            return View(data);
                        }
                    }
                    return View();
                }
                return RedirectToAction("Index", "Login");
            }
            catch(Exception e)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    ErrorMessage = e.Message
                };
                _log4net.Error("Error Ocuured in " + nameof(ViewBill) + " Error message : " + e.Message);
                return View("Error", error);
            }
            
            
           
        }

        public IActionResult SubmitClaim()
        {
            if (CheckStatus())
            {
                _log4net.Info(nameof(SubmitClaim) + " method invked.");
                return View();
            }
            return RedirectToAction("Index", "Login");

        }


        public IActionResult ClaimStatus()
        {
            if(CheckStatus())
            {
                _log4net.Info(nameof(ClaimStatus) + " method invked.");
                return View();
            }
            return RedirectToAction("Index", "Login");

        }

        [HttpPost]
        public IActionResult SubmitStatus([FromForm] MockDatabase data)
        {
            try
            {
                _log4net.Info(nameof(SubmitStatus) + " method invoked with Memeber Id " + data.MemberID);
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = client.GetAsync("https://localhost:44355/api/Members/getClaimStatus?claimID=" + data.ClaimID + "&policyID=" + data.PolicyID).Result;
                    var responseData = JsonConvert.DeserializeObject<string>(response.Content.ReadAsStringAsync().Result);
                    ViewBag.Status = responseData;
                    return View("Status");
                }
            }
            catch(Exception e)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    ErrorMessage = e.Message
                };
                _log4net.Error("Error Ocuured in " + nameof(SubmitStatus) + " Error message : " + e.Message);
                return View("Error", error);
            }
               
        }

        [HttpPost]
        public IActionResult SaveClaim([FromForm] int policyId , [FromForm] int memberId, [FromForm] int benefitId, [FromForm] int hospitalId, [FromForm] double claimAmount, [FromForm] string benefitName)
        {
            try
            {
               _dataPolicy.TransactionID = Guid.NewGuid();
                _dataPolicy.BenefitID = benefitId;
                _dataPolicy.PolicyID = policyId;
                _dataPolicy.MemberID = memberId;
                _dataPolicy.BenefitName = benefitName;
                _dataPolicy.ClaimID = count++;
                _dataPolicy.ClaimAmount = claimAmount;
                _dataPolicy.HospitalId = hospitalId;
                _context.MockDatabasesPolicy.Add(_dataPolicy);
                _context.SaveChanges();


                _log4net.Info(nameof(SaveClaim) + " method invoked.");
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = new HttpResponseMessage();
                    StringContent content = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
                    response = client.PostAsync("https://localhost:44355/api/Members/submitClaim?policyID=" + policyId + "&memberID=" + memberId + "&benefitID=" + benefitId + "&hospitalID=" + hospitalId + "&claimAmt=" +claimAmount + "&benefit=" + benefitName , content).Result;
                    var responseData = JsonConvert.DeserializeObject<string>(response.Content.ReadAsStringAsync().Result);
                    ViewBag.Status = responseData;
                    return View("Status");
                }
            }
            catch(Exception e)
            {

                ErrorViewModel error = new ErrorViewModel
                {
                    ErrorMessage = e.Message
                };
                _log4net.Error("Error Ocuured in " + nameof(SaveClaim) + " Error message : " + e.Message);
                return View("Error", error);
            }
           
        }


        public IActionResult Logout()
        {
            _log4net.Info(nameof(Logout) + " method invoked. " + ViewBag.UserName + " logged out.");
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

         public IActionResult AddNewPolicy()
        {
            if (CheckStatus())
            {
                _log4net.Info(nameof(AddNewPolicy) + " method invked.");
                return View();
            }
            return RedirectToAction("Index", "Login");

        }


        public IActionResult UpdateMember()
        {
            if (CheckStatus())
            {
                _log4net.Info(nameof(ViewPolicy) + " method invked.");
                return View();
            }
            return RedirectToAction("Index", "Login");

        }

        [HttpPost]
        public IActionResult AddNewPolicy([FromForm] int policyId, [FromForm] int policyNo, [FromForm] int benefitId, [FromForm] double premium, [FromForm] int tenure)
        {
            try
            {
                _log4net.Info(nameof(AddNewPolicy) + " method invoked.");
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = new HttpResponseMessage();
                    StringContent content = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
                    response = client.PostAsync("https://localhost:44373/api/Policy/AddNewPolicy?policyID=" + policyId + "&policyNO=" + policyNo + "&benefitID=" + benefitId + "&premium=" + premium + "&tenure=" + tenure, content).Result;
                    //var data = response.Content.ReadAsStringAsync().Result;
                    if (response.StatusCode == HttpStatusCode.OK)
                        return View("AddednewPolicy");
                    else return View("Error");
                }
            }
            catch (Exception e)
            {

                ErrorViewModel error = new ErrorViewModel
                {
                    ErrorMessage = e.Message
                };
                _log4net.Error("Error Ocuured in " + nameof(AddNewPolicy) + " Error message : " + e.Message);
                return View("Error", error);
            }

        }

        public IActionResult ViewPolicy()
        {
            if (CheckStatus())
            {
                _log4net.Info(nameof(ViewPolicy) + " method invked.");
                return View();
            }
            return RedirectToAction("Index", "Login");

        }


        public IActionResult SubmitViewPolicy([FromForm] MockDatabasePolicy policyDet)
        {
            try
            {
                if (CheckStatus())
                {
                    if (policyDet.PolicyID != 0)
                    {
                        _log4net.Info(nameof(SubmitViewPolicy) + " method invoked!");
                        using (var client = new HttpClient())
                        {
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = new HttpResponseMessage();
                            response = client.GetAsync("https://localhost:44373/api/Policy/GetPolicy/" + policyDet.PolicyID).Result;
                            var data = JsonConvert.DeserializeObject<MockDatabasePolicy>(response.Content.ReadAsStringAsync().Result);

                            return View(data);
                        }
                    }
                    return View();
                }
                return RedirectToAction("Index", "Login");
            }
            catch (Exception e)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    ErrorMessage = e.Message
                };
                _log4net.Error("Error Ocuured in " + nameof(ViewBill) + " Error message : " + e.Message);
                return View("Error", error);
            }
        }

        [HttpPost]
        public IActionResult SubmitUpdateMember([FromForm] MockDatabaseMember member)
        {
            try
            {
                if (CheckStatus())
                {
                    if (member.MemberID != 0)
                    {
                        _log4net.Info(nameof(SubmitUpdateMember) + " method invoked!");
                        using (var client = new HttpClient())
                        {
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = new HttpResponseMessage();
                            StringContent content = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
                            response = client.PostAsync("https://localhost:44355/api/Members/updateMember?memberID=" + member.MemberID + "&memberName=" + member.MemberName + "&memberAddress1=" + member.MemberAddress1 + "&memberAddress2=" + member.MemberAddress2 + "&memberCity=" + member.MemberCity + "&memberPhone=" +member.MemberPhone + "&username=" + member.Username + "&password=" + member.Password + "&role=" +member.Role, content).Result; ////update here
                            //var data = response.Content.ReadAsStringAsync().Result;//JsonConvert.DeserializeObject<MockDatabasePolicy>(response.Content.ReadAsStringAsync().Result);
                            //var responseData = JsonConvert.DeserializeObject<string>(response.Content.ReadAsStringAsync().Result);
                            if (response.StatusCode == HttpStatusCode.OK)

                                return View();
                            //return View(data);
                        }
                    }
                    return View();
                }
                return RedirectToAction("Index", "Login");
            }
            catch (Exception e)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    ErrorMessage = e.Message
                };
                _log4net.Error("Error Ocuured in " + nameof(ViewBill) + " Error message : " + e.Message);
                return View("Error", error);
            }



        }





    }
}
