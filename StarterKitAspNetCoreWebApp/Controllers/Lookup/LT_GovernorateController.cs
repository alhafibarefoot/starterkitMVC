using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarterKitAspNetCoreWebApp.Models;
using StarterKitAspNetCoreWebApp.Presistance;

using System;
using System.Linq;
using Microsoft.AspNetCore.Http.Features;
using StarterKitAspNetCoreWebApp.DTO;

namespace StarterKitAspNetCoreWebApp.Controllers
{
    public class LT_GovernorateController : Controller
    {
        private readonly StarterKitProjectDBContext context;
        private readonly IMapper mapper;
        public LT_GovernorateController(StarterKitProjectDBContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }


#region LT_Governorate

// -------------------------------------------------------------------
         [HttpGet ("/api/Governorates")]
        public async Task<IEnumerable<LT_GovernorateDTO>> GetCountries () {
        try
        {
            var Govermenates= await context.LT_Governorate.OrderBy(x=>x.Id).ToListAsync ();
            return mapper.Map<List<LT_Governorate>,List<LT_GovernorateDTO>>(Govermenates);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
        throw autoMapperException.InnerException; 
        // this will break your call stack
        // you may not know where the error is called and rather
        // want to clone the InnerException or throw a brand new Exception
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------
         [HttpGet ("/api/GovermenatesRegions")]
        public async Task<IEnumerable<LT_GovernorateDTO>> GetCountriesGovermenates () {
        try
        {
            var Govermenates= await context.LT_Governorate.Include (m => m.LT_Region).ToListAsync ();
            return mapper.Map<List<LT_Governorate>,List<LT_GovernorateDTO>>(Govermenates);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
             throw autoMapperException.InnerException; 
        
        }

        }


   // -------------------------------------------------------------------   

    // -------------------------------------------------------------------     
        [HttpGet ("/api/Governorate")]
         public async Task<LT_GovernorateDTO> GetCountry (string Governorate_Code) {
        try
        {

            
          
                var Governorate = await context.LT_Governorate.FirstOrDefaultAsync(x => x.Governorate_Code == Governorate_Code);
                return mapper.Map<LT_Governorate,LT_GovernorateDTO>(Governorate);
           

         
        }
        catch(AutoMapperMappingException autoMapperException)
        {
            throw autoMapperException.InnerException; 
        
        }

        }
// -------------------------------------------------------------------
       
 [HttpPost ("/api/AddGovernorate")]
        public async Task <LT_GovernorateDTO> AddGovernorate (LT_Governorate Governorate) {
        try
            {
                //if (!ModelState.IsValid)
                   // return BadRequest();

                   
               
                    var lastGovernorate = await context.LT_Governorate.OrderByDescending(x => x.Governorate_Code).FirstOrDefaultAsync();
                    var lastRefNO = await context.LT_LookupTableReferance.FirstOrDefaultAsync(x => x.LookupNameEn == "Governorate");
                    string code = "";
                    if(lastGovernorate!= null)
                    {
                        if(int.TryParse(lastGovernorate.Governorate_Code.Split('-')[1], out int lastCode))
                        {
                            code = lastRefNO.LookupCode +"-"+  (lastRefNO.LastSerialNo + 1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                            //code = "GOV-" + (lastCode + 1).ToString().PadLeft(4, '0');
                        }
                         else
                          code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                            //code = "GOV-" + (1).ToString().PadLeft(4, '0');
                    } 
                    else
                    code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                        //code = "GOV-" + (1).ToString().PadLeft(4, '0');

                    Governorate.Governorate_Code = code;
                    context.Entry(Governorate).State = EntityState.Added;


                    lastRefNO.LastSerialNo = lastRefNO.LastSerialNo+1;
                    context.Entry(lastRefNO).State = EntityState.Modified;
                    
                    var result = await context.SaveChangesAsync();

                    return mapper.Map<LT_Governorate,LT_GovernorateDTO>(Governorate);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------

// -------------------------------------------------------------------


[HttpPut ("/api/UpdateGovernorate")]
        public async Task <LT_GovernorateDTO> UpdateGovernorate (LT_Governorate Governorate) {
        try
            {
                var GovernorateInDb = await context.LT_Governorate.FirstOrDefaultAsync(x => x.Governorate_Code == Governorate.Governorate_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    System.Net.IPAddress clientIp = (HttpContext.Features.Get<IHttpConnectionFeature>()?.LocalIpAddress);
                    //string clientIp = Environment.MachineName; //returns webserver
                   //string clientIp = System.Net.Dns.GetHostName(); //returns webserver
                    //string clientIp = System.Environment.GetEnvironmentVariable("COMPUTERNAME").ToString();//returns webserver


                    string userNameModified = Environment.GetEnvironmentVariable("USERNAME");
                   
                   
                    

                    GovernorateInDb.GovernorateEN = Governorate.GovernorateEN ?? GovernorateInDb.GovernorateEN;
                    GovernorateInDb.GovernorateAR = Governorate.GovernorateAR ?? GovernorateInDb.GovernorateAR;
                    

                    GovernorateInDb.ModifiedBy = userNameModified ;//Country.ModifiedBy ?? countryInDb.ModifiedBy;
                    GovernorateInDb.ModifiedOn = Governorate.ModifiedOn ?? DateTime.Now;
                    GovernorateInDb.IPAddress = clientIp.ToString();  //Country.IPAddress ?? countryInDb.IPAddress;
                    GovernorateInDb.isActive = Governorate.isActive==false?false:true;


                    
                    context.Entry(GovernorateInDb).State = EntityState.Modified;
                    var result =await  context.SaveChangesAsync();

                   return mapper.Map<LT_Governorate,LT_GovernorateDTO>(GovernorateInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------

[HttpDelete ("/api/DeletedGovernorate")]
        public async Task <LT_GovernorateDTO> DeleteGovernorate (string Governorate_Code) {
        try
            {
                 var GovernorateInDb = await context.LT_Governorate.FirstOrDefaultAsync(x => x.Governorate_Code == Governorate_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    context.Entry(GovernorateInDb).State = EntityState.Deleted;
                    var result = await context.SaveChangesAsync();

                    

                    return mapper.Map<LT_Governorate,LT_GovernorateDTO>(GovernorateInDb);

                     

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