using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZHO.BAL.Models
{
    public class Employees
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Kindly enter Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Kindly enter Age")]
        [Display(Name = "Age")]
        public int? Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Kindly select Role")]
        [Display(Name = "Role")]
        public int? RoleID { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Kindly enter Mobile")]
        [MaxLength(10,ErrorMessage ="Kindly enter valid Mobile")]
        [Display(Name = "Mobile")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Kindly enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public string ModifiedOn { get; set; }
    }
}
