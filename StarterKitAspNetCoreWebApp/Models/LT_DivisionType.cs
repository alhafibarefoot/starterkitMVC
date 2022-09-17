namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class LT_DivisionType:BaseEntity
    {
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            
        [Key]
        [StringLength(12)]
        public string DivisionType_Code { get; set; }

        

        [Required]
        [StringLength(50)]
        public string DivisionNameEn { get; set; }

        [StringLength(50)]
        public string DivisionNameAr { get; set; }



//---------------------------Forign Tables
        public virtual ICollection<STR_Company> STR_Company { get; set; }



//--------------------------------------------------------     

       
    }
}
