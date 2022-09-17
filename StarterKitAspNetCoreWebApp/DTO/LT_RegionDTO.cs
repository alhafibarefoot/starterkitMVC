using System.Collections.Generic;

namespace StarterKitAspNetCoreWebApp.DTO
{
    public class LT_RegionDTO
    {
        
       public int Id { get; set; }

// Add Primary Key with Govermenate---------------------------
      
       
        public string LF_Governorate_Code { get; set; }

       


//---------------------------------------------------------

        
        public string Region_Code { get; set; }

       

       

      
        public string RegionEN { get; set; }



        
        public string RegionAR { get; set; }

//---------------------------Forign Tables
         public virtual ICollection<LT_AreaDTO> LT_Area { get; set; }


          
//--------------------------------------------------------       
        
    }
}