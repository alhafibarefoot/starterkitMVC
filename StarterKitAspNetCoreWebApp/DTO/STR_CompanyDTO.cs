namespace StarterKitAspNetCoreWebApp.DTO
{
    public class STR_CompanyDTO
    {
       
            public int Id { get; set; }
            
      
        public string Company_Code { get; set; }

        

     
        public string CompanyNameEn { get; set; }

      
        public string CompanyNameAr { get; set; }

        


// Add Primary Key with LTDivision---------------------------
     
      
        public string LF_DivisionType_Code { get; set; }

     


//---------------------------------------------------------

        public byte[] CompanyLogo { get; set; }

        
        public string WebSite { get; set; }

        
        public string Address { get; set; }

      
        public string Building { get; set; }

        public string Country_Code { get; set; }

        public string Governorate_Code { get; set; }

        public string Region_Code { get; set; }

        public string Area_Code { get; set; }

        public string Road_Code { get; set; }

       
        public string FullAddress { get; set; }

        
        public string POBox { get; set; }

       
        public string ContactPerson { get; set; }

       
        public string ContactTelNo { get; set; }

      
        public string ContactMobileNo { get; set; }

      
        public string ContactFaxNo { get; set; }

     
        public string ContactEmail { get; set; }

        public string ReportHeader { get; set; }

        public string ReportFooter { get; set; }

       
        public string Vat_RegistrationNumber { get; set; }

        public bool? IsCostCentre { get; set; }

        public bool? IsWareHouse { get; set; }

        public bool? IsOutLet { get; set; }
    }
}