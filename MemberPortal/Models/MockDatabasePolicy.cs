using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MemberPortal.Models
{

    public class MockDatabasePolicy
    {

        [Required(ErrorMessage = "Policy ID can't be empty!")]
        public int PolicyID { get; set; }

        [Required(ErrorMessage = "Policy No. can't be empty!")]
        
        public int PolicyNO { get; set; }


        [Required(ErrorMessage = "Benefit ID can't be empty!")]
        public int BenefitID { get; set; }

        [Required(ErrorMessage = "Premium amount can't be empty!")]
        public double Premium { get; set; }

        [Required(ErrorMessage = "Tenure can't be empty!")]
        public int Tenure { get; set; }

    }
}
