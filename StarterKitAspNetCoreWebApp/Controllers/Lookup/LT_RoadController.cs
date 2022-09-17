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
    public class LT_RoadController : Controller
    {
        private readonly StarterKitProjectDBContext context;
        private readonly IMapper mapper;

        public LT_RoadController(StarterKitProjectDBContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

#region LT_Road
// -------------------------------------------------------------------
         [HttpGet ("/api/Roads")]
        public async Task<IEnumerable<LT_RoadDTO>> GetRoads () {
        try
        {
            var Roads= await context.LT_Road.OrderBy(x=>x.Id).ToListAsync ();
            return mapper.Map<List<LT_Road>,List<LT_RoadDTO>>(Roads);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
        throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------


  // -------------------------------------------------------------------     
        [HttpGet ("/api/Road")]
         public async Task<LT_RoadDTO> GetRoad (string Road_Code) {
        try
        {

            
          
                var Road = await context.LT_Road.FirstOrDefaultAsync(x => x.Road_Code == Road_Code);
                return mapper.Map<LT_Road,LT_RoadDTO>(Road);
           

         
        }
        catch(AutoMapperMappingException autoMapperException)
        {
            throw autoMapperException.InnerException; 
        
        }

        }
// -------------------------------------------------------------------
       
 [HttpPost ("/api/AddRoad")]
        public async Task <LT_RoadDTO> AddRoad (LT_Road Road) {
        try
            {
                //if (!ModelState.IsValid)
                   // return BadRequest();

                   
               
                    var lastRoad = await context.LT_Road.OrderByDescending(x => x.Road_Code).FirstOrDefaultAsync();
                      var lastRefNO = await context.LT_LookupTableReferance.FirstOrDefaultAsync(x => x.LookupNameEn == "Road");
                    string code = "";
                    if(lastRoad!= null)
                    {
                        if(int.TryParse(lastRoad.Road_Code.Split('-')[1], out int lastCode))
                        {
                           // code = "ROD-" + (lastCode + 1).ToString().PadLeft(4, '0');
                            code = lastRefNO.LookupCode +"-"+  (lastRefNO.LastSerialNo + 1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                        }
                         else
                            //code = "ROD-" + (1).ToString().PadLeft(4, '0');
                            code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                    } 
                    else
                        //code = "ROD-" + (1).ToString().PadLeft(4, '0');
                        code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');

                    Road.Road_Code = code;
                    context.Entry(Road).State = EntityState.Added;

                    lastRefNO.LastSerialNo = lastRefNO.LastSerialNo+1;
                    context.Entry(lastRefNO).State = EntityState.Modified;

                    var result = await context.SaveChangesAsync();

                    return mapper.Map<LT_Road,LT_RoadDTO>(Road);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------

// -------------------------------------------------------------------


[HttpPut ("/api/UpdateRoad")]
        public async Task <LT_RoadDTO> UpdateRoad (LT_Road Road) {
        try
            {
                var RoadInDb = await context.LT_Road.FirstOrDefaultAsync(x => x.Road_Code == Road.Road_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    System.Net.IPAddress clientIp = (HttpContext.Features.Get<IHttpConnectionFeature>()?.LocalIpAddress);
                    //string clientIp = Environment.MachineName; //returns webserver
                   //string clientIp = System.Net.Dns.GetHostName(); //returns webserver
                    //string clientIp = System.Environment.GetEnvironmentVariable("COMPUTERNAME").ToString();//returns webserver


                    string userNameModified = Environment.GetEnvironmentVariable("USERNAME");
                   
                   
                    

                    
                    RoadInDb.RoadNO =  Road.RoadNO==0?RoadInDb.RoadNO:Road.RoadNO; //cant use ??

                    RoadInDb.RoadNameEN = Road.RoadNameEN ?? RoadInDb.RoadNameEN;
                    RoadInDb.RoadNameAR = Road.RoadNameAR ?? RoadInDb.RoadNameAR;
                    

                    RoadInDb.ModifiedBy = userNameModified ;//Country.ModifiedBy ?? countryInDb.ModifiedBy;
                    RoadInDb.ModifiedOn = Road.ModifiedOn ?? DateTime.Now;
                    RoadInDb.IPAddress = clientIp.ToString();  //Country.IPAddress ?? countryInDb.IPAddress;
                    RoadInDb.isActive = Road.isActive==false?false:true;


                    
                    context.Entry(RoadInDb).State = EntityState.Modified;
                    var result =await  context.SaveChangesAsync();

                   return mapper.Map<LT_Road,LT_RoadDTO>(RoadInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------

[HttpDelete ("/api/DeletedRoad")]
        public async Task <LT_RoadDTO> DeleteRoad (string Road_Code) {
        try
            {
                 var RoadInDb = await context.LT_Road.FirstOrDefaultAsync(x => x.Road_Code == Road_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    context.Entry(RoadInDb).State = EntityState.Deleted;
                    var result = await context.SaveChangesAsync();

                    

                    return mapper.Map<LT_Road,LT_RoadDTO>(RoadInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------


#endregion LT_Road

    }
}