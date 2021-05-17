using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyMicroservice.ViewModels
{
    public class PolicyDetail
    {
        [Required(ErrorMessage = "PolicyId can't be empty!")]
        public int PolicyId { get; set; }

        [Required(ErrorMessage = "PolicyNo can't be empty!")]
        public int PolicyNo { get; set; }

        [Required(ErrorMessage = "BenefitNo can't be empty!")]
        public int BenefitId { get; set; }

        [Required(ErrorMessage = "Premium can't be empty!")]
        public double Premium { get; set; }

        [Required(ErrorMessage = "Tenure can't be empty!")]
        public int Tenure { get; set; }
    }
}
