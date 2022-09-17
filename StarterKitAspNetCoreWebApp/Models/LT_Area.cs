namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class LT_Area:BaseEntity
    {
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; } 


        

// Add Primary Key with Region---------------------------

        [Required]
        [StringLength(12)]
        [Column("LF_Region_Code",Order=1)]
        public string LT_RegionRegion_Code { get; set; }

        public LT_Region LT_Region { get; set; }


//---------------------------------------------------------
            
        [Key]
        [Column(Order=1)]
        [StringLength(12)]
        public string Area_Code { get; set; }

        

        

        public int AreaNO { get; set; }



        //---------------------------Forign Tables
         public virtual ICollection<LT_Road> LT_Road { get; set; }


          
//--------------------------------------------------------       


        
    }
}
