using System.Collections.Generic;

namespace StarterKitAspNetCoreWebApp.DTO
{
    public class LT_DivisionTypeDTO
    {
        
            public int Id { get; set; }
       
        public string DivisionType_Code { get; set; }

        

        
        public string DivisionNameEn { get; set; }

      
        public string DivisionNameAr { get; set; }



//---------------------------Forign Tables
        public virtual ICollection<STR_CompanyDTO> STR_Company { get; set; }



//--------------------------------------------------------   
        
    }
}