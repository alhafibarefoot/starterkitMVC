namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class SEC_RoleDelegation:BaseEntity
    {
            [Column(Order=0)]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Key]
            public string RoleDelegation_Code { get; set; }

// Add Primary Key with AspNetUsers---------------------------
      

        [StringLength(128)]
        [Column("LF_Source_UserId")]
         [Required]
        public string AspNetUserUserId { get; set; }

 
        public  AspNetUser AspNetUser { get; set; }
//-----------------------------------------------------------------------------------

          

  // Add Primary Key with AspNetUsers---------------------------
      
       
        [StringLength(128)]
        [Column("LF_Destenation_UserId")]
       // [Required]
        public string AspNetUser1UserId { get; set; }


        public  AspNetUser AspNetUser1 { get; set; }
    
//-----------------------------------------------------------------------------------
  

// Add Primary Key with AspNetUsers---------------------------
          //  [Required]
            [StringLength(128)]
            [Column("RoleId")]
            public string AspNetRoleRoleId { get; set; }
            public AspNetRole AspNetRole { get; set; }
// -----------------------------------------------------------
            // public string RoleId { get; set; }

            public DateTime StartDate { get; set; }

            public DateTime EndDate { get; set; }

       

        
    }
}
