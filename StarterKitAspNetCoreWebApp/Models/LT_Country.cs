namespace StarterKitAspNetCoreWebApp.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class LT_Country : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(12)]
        [DisplayName("Country.Code")]
        public string Country_Code { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Country English.Name")]
        public string CountryNameEn { get; set; }

        [StringLength(50)]
        [DisplayName("Country Arabic.Name")]
        public string CountryNameAr { get; set; }

        [StringLength(50)]
        public string Capital { get; set; }

        [StringLength(50)]
        [DisplayName("Nationality Arabic.Name")]
        public string NationalityDescAr { get; set; }

        [StringLength(50)]
        [DisplayName("Nationality English.Name")]
        public string NationalityDescEn { get; set; }

        [DisplayName("Is GCC Country?")]
        public bool IsGCC { get; set; }

        [DisplayName("IACO.Region")]
        public int IACOCode { get; set; }

        [StringLength(5)]
        [DisplayName("Alpha2.Code")]
        public string Alpha2Code { get; set; }

        [StringLength(5)]
        [DisplayName("Alpha3.Code")]
        public string Alpha3Code { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        [DisplayName("Sub.Region")]
        public string SubRegion { get; set; }

        [StringLength(8)]
        [DisplayName("Region.Code")]
        public string Region_Code { get; set; }

        [StringLength(8)]
        [DisplayName("Sub.Region/City.Code")]
        public string SubRegion_Code { get; set; }

        [StringLength(8)]
        [DisplayName("Dail.Code")]
        public string DialCode { get; set; }

        //---------------------------Forign Tables
        public virtual ICollection<LT_Governorate> LT_Governorate { get; set; }

        //--------------------------------------------------------
    }
}
