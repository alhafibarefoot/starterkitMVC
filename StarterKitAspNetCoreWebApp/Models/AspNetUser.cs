namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  
    

    public partial class AspNetUser:BaseEntity
    {
        

        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

        [Key]
        [Required]
        [StringLength(128)]
        public string UserId { get; set; }




        [StringLength(50)]
        public string FirstName { get; set; }



        [StringLength(50)]
        public string LastName { get; set; }



        public byte[] UserPhoto { get; set; }



        public bool IsEmployee { get; set; }



        [StringLength(128)]
        public string OrganizationEmail { get; set; }



        [StringLength(5)]
        public string EmployeeCode { get; set; }



        [StringLength(128)]
        public string Email { get; set; }



        public bool EmailConfirmed { get; set; }



        [StringLength(128)]
        public string PasswordHash { get; set; }



        [StringLength(128)]
        public string SecurityStamp { get; set; }



        [StringLength(15)]
        public string PhoneNumber { get; set; }



        public bool PhoneNumberConfirmed { get; set; }



        public bool TwoFactorEnabled { get; set; }



        public DateTime? LockoutEndDateUtc { get; set; }



        public bool LockoutEnabled { get; set; }



        public int AccessFailedCount { get; set; }



        [Required]
        [StringLength(50)]
        public string UserName { get; set; }



       
//----------------------------------------Forign Tables-------------------------------
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

        [InverseProperty(nameof(SEC_RoleDelegation.AspNetUser))]
        public virtual ICollection<SEC_RoleDelegation> SEC_RoleDelegationUserSource { get; set; }
        [InverseProperty(nameof(SEC_RoleDelegation.AspNetUser1))]
        public virtual ICollection<SEC_RoleDelegation> SEC_RoleDelegationUserDestenation { get; set; }
       

//----------------------------------------------------------------------------------------

       
 

        
    }
}
