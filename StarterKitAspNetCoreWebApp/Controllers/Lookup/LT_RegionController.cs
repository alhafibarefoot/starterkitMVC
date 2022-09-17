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
    public class LT_RegionController:Controller
    {
        

private readonly StarterKitProjectDBContext context;
        private readonly IMapper mapper;

        public LT_RegionController (StarterKitProjectDBContext context, IMapper mapper) {
            this.mapper = mapper;
            this.context = context;

        }
#region LT_Governorate
// -------------------------------------------------------------------
         [HttpGet ("/api/Regions")]
        public async Task<IEnumerable<LT_RegionDTO>> GetRegions () {
        try
        {
            var Regions= await context.LT_Region.OrderBy(x=>x.Id).ToListAsync ();
            return mapper.Map<List<LT_Region>,List<LT_RegionDTO>>(Regions);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
        throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------
       //  [JsonIgnore]
    
         [HttpGet ("/api/RegionsAreas")]
        public async Task<IEnumerable<LT_RegionDTO>> GetRegionsAreas () {
        try
        {
            var Regions= await context.LT_Region.Include (m => m.LT_Area).ToListAsync ();
            return mapper.Map<List<LT_Region>,List<LT_RegionDTO>>(Regions);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
             throw autoMapperException.InnerException; 
        
        }

        }


   // -------------------------------------------------------------------   

  // -------------------------------------------------------------------     
        [HttpGet ("/api/Region")]
         public async Task<LT_RegionDTO> GetRegion (string Region_Code) {
        try
        {

            
          
                var Region = await context.LT_Region.FirstOrDefaultAsync(x => x.Region_Code == Region_Code);
                return mapper.Map<LT_Region,LT_RegionDTO>(Region);
           

         
        }
        catch(AutoMapperMappingException autoMapperException)
        {
            throw autoMapperException.InnerException; 
        
        }

        }
// -------------------------------------------------------------------
       
 [HttpPost ("/api/AddRegion")]
        public async Task <LT_RegionDTO> AddRegion (LT_Region Region) {
        try
            {
                //if (!ModelState.IsValid)
                   // return BadRequest();

                   
               
                    var lastRegion = await context.LT_Region.OrderByDescending(x => x.Region_Code).FirstOrDefaultAsync();
                    var lastRefNO = await context.LT_LookupTableReferance.FirstOrDefaultAsync(x => x.LookupNameEn == "Region");


                    string code = "";
                    if(lastRegion!= null)
                    {
                        if(int.TryParse(lastRegion.Region_Code.Split('-')[1], out int lastCode))
                        {
                            //code = "REG-" + (lastCode + 1).ToString().PadLeft(4, '0');
                             code = lastRefNO.LookupCode +"-"+  (lastRefNO.LastSerialNo + 1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                        }
                         else
                           // code = "REG-" + (1).ToString().PadLeft(4, '0');
                           code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                    } 
                    else
                      //  code = "REG-" + (1).ToString().PadLeft(4, '0');
                      code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');

                    Region.Region_Code = code;
                    context.Entry(Region).State = EntityState.Added;

                    lastRefNO.LastSerialNo = lastRefNO.LastSerialNo+1;
                    context.Entry(lastRefNO).State = EntityState.Modified;

                    
                    var result = await context.SaveChangesAsync();

                    return mapper.Map<LT_Region,LT_RegionDTO>(Region);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------

// -------------------------------------------------------------------


[HttpPut ("/api/UpdateRegion")]
        public async Task <LT_RegionDTO> UpdateRegion (LT_Region Region) {
        try
            {
                var RegionInDb = await context.LT_Region.FirstOrDefaultAsync(x => x.Region_Code == Region.Region_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    System.Net.IPAddress clientIp = (HttpContext.Features.Get<IHttpConnectionFeature>()?.LocalIpAddress);
                    //string clientIp = Environment.MachineName; //returns webserver
                   //string clientIp = System.Net.Dns.GetHostName(); //returns webserver
                    //string clientIp = System.Environment.GetEnvironmentVariable("COMPUTERNAME").ToString();//returns webserver


                    string userNameModified = Environment.GetEnvironmentVariable("USERNAME");
                   
                   
                    

                    RegionInDb.RegionEN = Region.RegionEN ?? RegionInDb.RegionEN;
                    RegionInDb.RegionAR = Region.RegionAR ?? RegionInDb.RegionAR;
                    

                    RegionInDb.ModifiedBy = userNameModified ;//Country.ModifiedBy ?? countryInDb.ModifiedBy;
                    RegionInDb.ModifiedOn = Region.ModifiedOn ?? DateTime.Now;
                    RegionInDb.IPAddress = clientIp.ToString();  //Country.IPAddress ?? countryInDb.IPAddress;
                    RegionInDb.isActive = Region.isActive==false?false:true;


                    
                    context.Entry(RegionInDb).State = EntityState.Modified;
                    var result =await  context.SaveChangesAsync();

                   return mapper.Map<LT_Region,LT_RegionDTO>(RegionInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------

[HttpDelete ("/api/DeletedRegion")]
        public async Task <LT_RegionDTO> DeleteRegion (string Region_Code) {
        try
            {
                 var RegionInDb = await context.LT_Region.FirstOrDefaultAsync(x => x.Region_Code == Region_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    context.Entry(RegionInDb).State = EntityState.Deleted;
                    var result = await context.SaveChangesAsync();

                    

                    return mapper.Map<LT_Region,LT_RegionDTO>(RegionInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------




#endregion LT_Governorate
        
    }
}