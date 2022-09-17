namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class SEC_RolePermission:BaseEntity
    {
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            
        [Key]
        public string RolePermission_Code { get; set; }

        

// Add Primary Key with AspNetUsers---------------------------
        [Required]
        [StringLength(128)]
        [Column("RoleId")]
        public string AspNetRoleRoleId { get; set; }
        public AspNetRole AspNetRole { get; set; }
// -----------------------------------------------------------

        [Required]
        [StringLength(12)]
        public string Action_Code { get; set; }

        [Required]
        [StringLength(12)]
        public string Module_Code { get; set; }

       

        
    }
}
