namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class STR_Company:BaseEntity
    {
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            
        [Key]
        [StringLength(12)]
        public string Company_Code { get; set; }

        

        [Required]
        [StringLength(100)]
        public string CompanyNameEn { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyNameAr { get; set; }

        


// Add Primary Key with LTDivision---------------------------
     
        [Required]
        [StringLength(12)]
        [Column("LF_DivisionType_Code",Order=1)]
        public string LT_DivisionTypeDivisionType_Code { get; set; }

        public LT_DivisionType LT_DivisionType { get; set; }


//---------------------------------------------------------

        public byte[] CompanyLogo { get; set; }

        [StringLength(75)]
        public string WebSite { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Building { get; set; }

        public string Country_Code { get; set; }

        public string Governorate_Code { get; set; }

        public string Region_Code { get; set; }

        public string Area_Code { get; set; }

        public string Road_Code { get; set; }

        [StringLength(200)]
        public string FullAddress { get; set; }

        [StringLength(75)]
        public string POBox { get; set; }

        [StringLength(100)]
        public string ContactPerson { get; set; }

        [StringLength(15)]
        public string ContactTelNo { get; set; }

        [StringLength(15)]
        public string ContactMobileNo { get; set; }

        [StringLength(15)]
        public string ContactFaxNo { get; set; }

        [StringLength(75)]
        public string ContactEmail { get; set; }

        public string ReportHeader { get; set; }

        public string ReportFooter { get; set; }

        [StringLength(50)]
        public string Vat_RegistrationNumber { get; set; }

        public bool? IsCostCentre { get; set; }

        public bool? IsWareHouse { get; set; }

        public bool? IsOutLet { get; set; }

        
    }
}
