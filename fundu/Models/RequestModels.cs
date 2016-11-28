using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace fundu.Models
{
    //public class RequestModels
    //{
    //}

    public class PostModel
    {
    [Key]
        [Required]
        //[Display(Name = "Current password")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }

        public int LocId { get; set; }
        public int CatId { get; set; }
        public string PostDesc { get; set; }
        public int UID { get; set; }
        public int FollowPostId { get; set; }
        public int Status { get; set; }

        //dibakar need to work
        public decimal budgetFrom { get; set; }
        public decimal budgetTo { get; set; }
             
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "New password")]
        //public string NewPassword { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm new password")]
        //[Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }
}