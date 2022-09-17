namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class AspNetUserRole:BaseEntity
    {

 // Add Primary Key with User & Roles---------------------------
        [Key]
        [Column("UserId",Order = 0)]
        [StringLength(128)]
        public string AspNetUserUserId { get; set; }
        public AspNetUser AspNetUser { get; set; }

        [Key]
        [Column("RoleId",Order = 1)]
        [StringLength(128)]
        public string AspNetRoleRoleId { get; set; }
        public AspNetRole AspNetRole { get; set; }
//-----------------------------------------------------------------------------        

        

      
    }
}
