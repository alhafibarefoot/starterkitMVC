using System.Collections.Generic;


namespace StarterKitAspNetCoreWebApp.DTO
{
    public class LT_AreaDTO
    {
        
        public int Id { get; set; } 


        

// Add Primary Key with Region---------------------------

        
        public string LF_Region_Code { get; set; }

       


//---------------------------------------------------------
            
       
        public string Area_Code { get; set; }

        

        

        public int AreaNO { get; set; }



        //---------------------------Forign Tables
         public virtual ICollection<LT_RoadDTO> LT_Road { get; set; }


          
//--------------------------------------------------------       
        
    }
}