namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class LT_Region:BaseEntity
    {
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

// Add Primary Key with Govermenate---------------------------
      
        [Required]
        [StringLength(12)]
        [Column("LF_Governorate_Code",Order=1)]
        public string LT_GovernorateGovernorate_Code { get; set; }

        public LT_Governorate LT_Governorate { get; set; }


//---------------------------------------------------------

        [Column(Order=2)]    
        [Key]
        [StringLength(12)]
        public string Region_Code { get; set; }

       

       

        [StringLength(50)]
        public string RegionEN { get; set; }



        [Required]
        [StringLength(50)]
        public string RegionAR { get; set; }

//---------------------------Forign Tables
         public virtual ICollection<LT_Area> LT_Area { get; set; }


          
//--------------------------------------------------------       

       
    }
}
