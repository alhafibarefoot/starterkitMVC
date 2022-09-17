using System.Collections.Generic;
using StarterKitAspNetCoreWebApp.Models;

namespace StarterKitAspNetCoreWebApp.DTO
{
    public class LT_GovernorateDTO:BaseEntity
    {
        
        public int Id { get; set; }
        
        public string LF_Country_Code { get; set; }
        
        public string Governorate_Code { get; set; }
        public string GovernorateEN { get; set; }
        public string GovernorateAR { get; set; }

 //---------------------------Forign Tables
         public virtual ICollection<LT_RegionDTO> LT_Region { get; set; }


          
//--------------------------------------------------------       
        
    }
}