using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarterKitAspNetCoreWebApp.DTO;
using StarterKitAspNetCoreWebApp.Models;
using StarterKitAspNetCoreWebApp.Presistance;


namespace StarterKitAspNetCoreWebApp.Controllers.Lookup
{
    public class LT_AreaController : Controller
    {
        private readonly StarterKitProjectDBContext context;
        private readonly IMapper mapper;
        public LT_AreaController(StarterKitProjectDBContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

#region  LT_Area


// -------------------------------------------------------------------
         [HttpGet ("/api/Areas")]
        public async Task<IEnumerable<LT_AreaDTO>> GetAreas () {
        try
        {
            var Areas= await context.LT_Area.OrderBy(x=>x.Id).ToListAsync ();
            return mapper.Map<List<LT_Area>,List<LT_AreaDTO>>(Areas);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
        throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------
       //  [JsonIgnore]
    
         [HttpGet ("/api/AreasRoads")]
        public async Task<IEnumerable<LT_AreaDTO>> GetAreasRoads () {
        try
        {
            var Areas= await context.LT_Area.Include (m => m.LT_Road).ToListAsync ();
            return mapper.Map<List<LT_Area>,List<LT_AreaDTO>>(Areas);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
             throw autoMapperException.InnerException; 
        
        }

        }


   // -------------------------------------------------------------------   

  // -------------------------------------------------------------------     
        [HttpGet ("/api/Area")]
         public async Task<LT_AreaDTO> GetArea (string Area_Code) {
        try
        {

            
          
                var Area = await context.LT_Area.FirstOrDefaultAsync(x => x.Area_Code == Area_Code);
                return mapper.Map<LT_Area,LT_AreaDTO>(Area);
           

         
        }
        catch(AutoMapperMappingException autoMapperException)
        {
            throw autoMapperException.InnerException; 
        
        }

        }
// -------------------------------------------------------------------
       
 [HttpPost ("/api/AddArea")]
        public async Task <LT_AreaDTO> AddArea (LT_Area Area) {
        try
            {
                //if (!ModelState.IsValid)
                   // return BadRequest();

                   
               
                    var lastArea = await context.LT_Area.OrderByDescending(x => x.Area_Code).FirstOrDefaultAsync();
                    var lastRefNO = await context.LT_LookupTableReferance.FirstOrDefaultAsync(x => x.LookupNameEn == "Area");


                    string code = "";
                    if(lastArea!= null)
                    {
                        if(int.TryParse(lastArea.Area_Code.Split('-')[1], out int lastCode))
                        {
                           // code = "ARE-" + (lastCode + 1).ToString().PadLeft(4, '0');
                            code = lastRefNO.LookupCode +"-"+  (lastRefNO.LastSerialNo + 1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                        }
                         else
                            //code = "ARE-" + (1).ToString().PadLeft(4, '0');
                            code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                    } 
                    else
                       // code = "ARE-" + (1).ToString().PadLeft(4, '0');
                       code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');

                    Area.Area_Code = code;
                    context.Entry(Area).State = EntityState.Added;

                    lastRefNO.LastSerialNo = lastRefNO.LastSerialNo+1;
                    context.Entry(lastRefNO).State = EntityState.Modified;

                    var result = await context.SaveChangesAsync();

                    return mapper.Map<LT_Area,LT_AreaDTO>(Area);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------

// -------------------------------------------------------------------


[HttpPut ("/api/UpdateArea")]
        public async Task <LT_AreaDTO> UpdateArea (LT_Area Area) {
        try
            {
                var AreaInDb = await context.LT_Area.FirstOrDefaultAsync(x => x.Area_Code == Area.Area_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    System.Net.IPAddress clientIp = (HttpContext.Features.Get<IHttpConnectionFeature>()?.LocalIpAddress);
                    //string clientIp = Environment.MachineName; //returns webserver
                   //string clientIp = System.Net.Dns.GetHostName(); //returns webserver
                    //string clientIp = System.Environment.GetEnvironmentVariable("COMPUTERNAME").ToString();//returns webserver


                    string userNameModified = Environment.GetEnvironmentVariable("USERNAME");
                   
                   
                    

                    
                    AreaInDb.AreaNO =  Area.AreaNO==0?AreaInDb.AreaNO:Area.AreaNO; //cant use ??
                    

                    AreaInDb.ModifiedBy = userNameModified ;//Country.ModifiedBy ?? countryInDb.ModifiedBy;
                    AreaInDb.ModifiedOn = Area.ModifiedOn ?? DateTime.Now;
                    AreaInDb.IPAddress = clientIp.ToString();  //Country.IPAddress ?? countryInDb.IPAddress;
                    AreaInDb.isActive = Area.isActive==false?false:true;


                    
                    context.Entry(AreaInDb).State = EntityState.Modified;
                    var result =await  context.SaveChangesAsync();

                   return mapper.Map<LT_Area,LT_AreaDTO>(AreaInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------

[HttpDelete ("/api/DeletedArea")]
        public async Task <LT_AreaDTO> DeleteArea (string Area_Code) {
        try
            {
                 var AreaInDb = await context.LT_Area.FirstOrDefaultAsync(x => x.Area_Code == Area_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    context.Entry(AreaInDb).State = EntityState.Deleted;
                    var result = await context.SaveChangesAsync();

                    

                    return mapper.Map<LT_Area,LT_AreaDTO>(AreaInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------



#endregion LT_Area

    }
}