namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class LT_Governorate:BaseEntity
    {
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

// Add Primary Key with Country---------------------------
     
        [Required]
        [StringLength(12)]
        [Column("LF_Country_Code",Order=1)]
        public string LT_CountryCountry_Code { get; set; }

        public LT_Country LT_Country { get; set; }


//---------------------------------------------------------
        
        [Column(Order=2)]    
        [Key]
        [StringLength(12)]
        public string Governorate_Code { get; set; }



        [StringLength(50)]
        public string GovernorateEN { get; set; }



        [Required]
        [StringLength(50)]
        public string GovernorateAR { get; set; }


 //---------------------------Forign Tables
         public virtual ICollection<LT_Region> LT_Region { get; set; }


          
//--------------------------------------------------------       

      

        
    }
}
