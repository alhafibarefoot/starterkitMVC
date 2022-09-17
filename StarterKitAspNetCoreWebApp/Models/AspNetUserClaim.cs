namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class AspNetUserClaim
    {
        public int Id { get; set; }


 // Add Primary Key with AspNetUsers---------------------------
        [Required]
        [StringLength(128)]

        [Column("UserId")]
        public string AspNetUserUserId { get; set; }
        public AspNetUser AspNetUser { get; set; }
        // public string RoleId { get; set; }

 //-------------------------------------------------------------------------------------       

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

       
    }
}
