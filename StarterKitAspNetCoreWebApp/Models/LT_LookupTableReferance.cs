using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StarterKitAspNetCoreWebApp.Models
{
    public class LT_LookupTableReferance:BaseEntity
    {
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

        
        [Required(ErrorMessage = "Enter the Lookup Code")]
        [DisplayName("Lookup Code")]
        [MaxLength(2, ErrorMessage = "Length cannot be more than 2")]
        [StringLength(3)]
        public string LookupCode { get; set; }

        [Required(ErrorMessage = "Enter the Lookup Name English")]
        [DisplayName("Lookup Name En")]
        [MaxLength(50, ErrorMessage = "Length cannot be more than 50")]
        [StringLength(50)]
        public string LookupNameEn { get; set; }

        [DisplayName("Lookup Name Ar")]
        [MaxLength(50, ErrorMessage = "Length cannot be more than 50")]
        [StringLength(50)]
        public string LookupNameAr { get; set; }

        [DefaultValue("0")]
        public int? LastSerialNo { get; set; }

        [DefaultValue("0")]
        public int? TemporarySerialNo { get; set; }

         [DefaultValue(4)] 
          public int PadLeftNo { get; set; }

    }
}