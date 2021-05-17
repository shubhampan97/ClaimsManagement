﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PolicyMicroservice.Models;
using PolicyMicroservice.Repository;
using PolicyMicroservice.ViewModels;

namespace PolicyMicroservice.Controllers
{

    /// <summary>
    /// Contributed By Anupam Bhattacharyya(848843)
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly IPolicyRepo _policyRepository;
       static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(PolicyController));
        public PolicyController(IPolicyRepo policyRepository)
        {
            _policyRepository = policyRepository;
        }

        /// <summary>
        /// To get the List of Chain of Providers
        /// </summary>
        /// <param name="PolicyID"></param>
        /// <returns></returns>


        //http://52.224.146.148/api/Policy/GetChainOfProviders/1
        [HttpGet]
        [Route("GetChainOfProviders/{PolicyID}")]
        public IActionResult GetChainOfProviders(int policyId)
        {
            try
            {
               
                if (policyId>0)
                {
                    var providerlist = _policyRepository.GetChainOfProviders(policyId);
                    _log4net.Info("GetChainOfProviders Accesed for policyId :"+policyId);
                    

                    return new OkObjectResult(providerlist);
                }
                else
                    _log4net.Info("Data is not valid in GetChainOfProviders while checking for PolicyId: "+policyId);
                    return BadRequest();

            }
            catch(Exception e)
            {
               _log4net.Error("Exception in GetChainOfProviders for entered PolicyId: "+policyId+" "+e.Message);
                return new NoContentResult();
            }
        }
        /// <summary>
        /// To Get the Benefits list
        /// </summary>
        /// <param name="PolicyID"></param>
        /// <param name="MemberID"></param>
        /// <returns></returns>

        // http://52.224.146.148/api/Policy/GetEligibleBenefits?PolicyId=1&MemberID=1
        [HttpGet]
      [Route("GetEligibleBenefits")]
    
        public IActionResult GetEligibleBenefit([FromQuery]int policyId,[FromQuery] int memberId)
        {
            try
            {
                if (policyId>0 && memberId>0)
                {
                    _log4net.Info("GetEligibleBenefit is accessed for MemberId :"+memberId +" PolicyId :"+policyId);
                    var benefitslist = _policyRepository.GetEligibleBenefits(policyId, memberId);
                    return new OkObjectResult(benefitslist);
                }
                else
                {
                    _log4net.Info("Data is not valid in GetEligibleBenefit for the entered MemberId :"+memberId+" PolicyId :"+policyId );
                    return BadRequest() ;
                }

            }
            catch(Exception e)
            {
                 _log4net.Error("Exception in GetEligibleBenefit for the entered MemberId :" + memberId + " PolicyId :" + policyId +" " +e.Message);
                return new NoContentResult();
            }
        }

        /// <summary>
        /// To get the eligible Claim Amount
        /// </summary>
        /// <param name="PolicyId"></param>
        /// <param name="MemberID"></param>
        /// <param name="BenefitId"></param>
        /// <returns></returns>
        /// 
        //http://52.224.146.148/api/Policy/GetEligibleClaimAmount?PolicyId=1&MemberID=1&BenefitId=1
        [HttpGet]
        [Route("GetEligibleClaimAmount")]
        public IActionResult GetEligibleClaimAmount([FromQuery]int policyId,[FromQuery] int memberId,[FromQuery] int benefitId)
        {
            try
            {
                if (policyId>0 && memberId>0 && benefitId>0)
                {
                    _log4net.Info("GetEligibleClaimAmount is accesed for PolicyId :"+policyId+" MemberId :"+memberId+" BenefitId :"+benefitId);
                    var amt = _policyRepository.GetEligibleClaimAmount(policyId, memberId, benefitId);
                    return new OkObjectResult(amt);
                }
                else
                    _log4net.Info("Data is not valid for GetEligibleClaimAmount for the entered PolicyId :" + policyId + " MemberId :" + memberId + " BenefitId :" + benefitId);
                    return BadRequest();

            }
            catch(Exception e)
            {
                _log4net.Error("Exception in GetEligibleClaimAmount for entered PolicyId :" + policyId + " MemberId :" + memberId + " BenefitId :" + benefitId+" " +e.Message);
                return new NoContentResult();

            }
        }

        /*[Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("AddNewPolicy")]
        public IActionResult AddNewPolicy([FromForm] PolicyDetail detail)
        {
            PolicyData.policyList.Add(new Policy
            {
                PolicyId = detail.PolicyId,
                PolicyNo = detail.PolicyNo,
                Premium = detail.Premium,
                Tenure = detail.Tenure,
                BenefitId = detail.BenefitId
            });
            return Ok("Policy Added");
        }*/



        [HttpPost]
        [Route("AddNewPolicy")]
        public async Task<ActionResult<string>> AddNewPolicy([FromQuery] int policyID, [FromQuery] int policyNO, [FromQuery] int benefitID, [FromQuery] int premium, [FromQuery] int tenure)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _log4net.Info("AddNewPolicy Accesed");
                    return Ok(_policyRepository.AddNewPolicy(policyID, policyNO, benefitID, premium, tenure));
                }
                else
                    _log4net.Info("Inputs given are not valid");
                return BadRequest();
            }
            catch (Exception e)
            {
                _log4net.Error("Exception in AddnewPolicy" + e.Message);
                return new NoContentResult();
            }
        }

        [HttpGet]
        [Route("GetPolicy/{id}")]
        public Policy ViewPolicy(int id)
        {
            return PolicyData.policyList.Where(m => m.PolicyId == id).FirstOrDefault();
        }


        [HttpGet]
        [Route("GetAllPolicies")]
        public List<Policy> GetAllPolicies()
        {
            var members = _policyRepository.GetAllPolicies();
            return members;
        }

    }
}
