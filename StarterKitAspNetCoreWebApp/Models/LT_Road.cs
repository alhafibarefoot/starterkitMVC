namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class LT_Road:BaseEntity
    {
       
            
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            
        [Key]
        [StringLength(12)]
        public string Road_Code { get; set; }

       

       

// Add Primary Key with Area---------------------------
      
        [Required]
        [StringLength(12)]
        [Column("LF_Area_Code",Order=1)]
        public string LT_AreaArea_Code { get; set; }

        public LT_Area LT_Area { get; set; }


//---------------------------------------------------------

        public int RoadNO { get; set; }

        [Required]
        [StringLength(80)]
        public string RoadNameEN { get; set; }

        [StringLength(80)]
        public string RoadNameAR { get; set; }

        
    }
}
