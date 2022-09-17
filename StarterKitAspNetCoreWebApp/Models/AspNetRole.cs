namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    
    

    public partial class AspNetRole:BaseEntity
    {
        

       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

        [Key]
        [Required]
        [StringLength(128)]
        public string RoleId { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }



        [StringLength(50)]
        public string NameAr { get; set; }




        [StringLength(256)]
        public string Description { get; set; }




        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

   

      //-------------------------Forign Tables-----------------------------------------------
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }


        public virtual ICollection<SEC_RoleDelegation> SEC_RoleDelegation { get; set; }


        public virtual ICollection<SEC_RolePermission> SEC_RolePermission { get; set; }

       //------------------------------------------------------------------------  
    }
}
