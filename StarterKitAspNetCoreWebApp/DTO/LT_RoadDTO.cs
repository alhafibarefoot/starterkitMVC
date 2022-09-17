

namespace StarterKitAspNetCoreWebApp.DTO
{
    public class LT_RoadDTO
    {
             
       
        public int Id { get; set; }
            
       
        public string Road_Code { get; set; }

       

       

// Add Primary Key with Area---------------------------
      
        public string LF_Area_Code { get; set; }

       

//---------------------------------------------------------

        public int RoadNO { get; set; }

       
        public string RoadNameEN { get; set; }

       
        public string RoadNameAR { get; set; }
        
    }
}