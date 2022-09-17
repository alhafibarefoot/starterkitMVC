namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class SMT_Action:BaseEntity
    {
       
        public SMT_Action()
        {
           // SEC_RolePermission = new HashSet<SEC_RolePermission>();
        }
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

        [Key]
        [StringLength(12)]
        public string Action_Code { get; set; }

        

        [Required]
        [StringLength(100)]
        public string ActionNameAr { get; set; }

        [StringLength(100)]
        public string ActionNameEn { get; set; }

       

       
    }
}
