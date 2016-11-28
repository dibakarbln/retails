using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace fundu.Models
{
    public class VendorModels
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
    }
}