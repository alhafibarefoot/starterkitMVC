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
    public class LT_DivisionTypeController : Controller
    {
        private readonly StarterKitProjectDBContext context;
        private readonly IMapper mapper;
        public LT_DivisionTypeController(StarterKitProjectDBContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

#region LT_DivisionType

// -------------------------------------------------------------------
         [HttpGet ("/api/DivisionTypes")]
        public async Task<IEnumerable<LT_DivisionTypeDTO>> GetDivisionTypes () {
        try
        {
            var DivisionTypes= await context.LT_DivisionType.OrderBy(x=>x.Id).ToListAsync ();
            return mapper.Map<List<LT_DivisionType>,List<LT_DivisionTypeDTO>>(DivisionTypes);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
        throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------
       //  [JsonIgnore]
    
         [HttpGet ("/api/DivisionTypesCompanies")]
        public async Task<IEnumerable<LT_DivisionTypeDTO>> GetDivisionTypesCompanies () {
        try
        {
            var DivisionTypes= await context.LT_DivisionType.Include (m => m.STR_Company).ToListAsync ();
            return mapper.Map<List<LT_DivisionType>,List<LT_DivisionTypeDTO>>(DivisionTypes);
        }
        catch(AutoMapperMappingException autoMapperException)
        {
             throw autoMapperException.InnerException; 
        
        }

        }


   // -------------------------------------------------------------------   

  // -------------------------------------------------------------------     
        [HttpGet ("/api/DivisionType")]
         public async Task<LT_DivisionTypeDTO> GetDivisionType (string DivisionType_Code) {
        try
        {

            
          
                var DivisionType = await context.LT_DivisionType.FirstOrDefaultAsync(x => x.DivisionType_Code == DivisionType_Code);
                return mapper.Map<LT_DivisionType,LT_DivisionTypeDTO>(DivisionType);
           

         
        }
        catch(AutoMapperMappingException autoMapperException)
        {
            throw autoMapperException.InnerException; 
        
        }

        }
// -------------------------------------------------------------------
       
 [HttpPost ("/api/AddDivisionType")]
        public async Task <LT_DivisionTypeDTO> AddDivisionType (LT_DivisionType DivisionType) {
        try
            {
                //if (!ModelState.IsValid)
                   // return BadRequest();

                   
               
                    var lastDivisionType = await context.LT_DivisionType.OrderByDescending(x => x.DivisionType_Code).FirstOrDefaultAsync();
                    var lastRefNO = await context.LT_LookupTableReferance.FirstOrDefaultAsync(x => x.LookupNameEn == "DivisionType");
                    string code = "";
                    if(lastDivisionType!= null)
                    {
                        if(int.TryParse(lastDivisionType.DivisionType_Code.Split('-')[1], out int lastCode))
                        {
                           // code = "DIV-" + (lastCode + 1).ToString().PadLeft(4, '0');
                            code = lastRefNO.LookupCode +"-"+  (lastRefNO.LastSerialNo + 1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                        }
                         else
                           // code = "DIV-" + (1).ToString().PadLeft(4, '0');
                           code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                    } 
                    else
                        //code = "DIV-" + (1).ToString().PadLeft(4, '0');
                        code = lastRefNO.LookupCode +"-"+ (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');

                    DivisionType.DivisionType_Code = code;
                    context.Entry(DivisionType).State = EntityState.Added;

                     lastRefNO.LastSerialNo = lastRefNO.LastSerialNo+1;
                    context.Entry(lastRefNO).State = EntityState.Modified;

                    
                    var result = await context.SaveChangesAsync();

                    return mapper.Map<LT_DivisionType,LT_DivisionTypeDTO>(DivisionType);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------

// -------------------------------------------------------------------


[HttpPut ("/api/UpdateDivisionType")]
        public async Task <LT_DivisionTypeDTO> UpdateDivisionType (LT_DivisionType DivisionType) {
        try
            {
                var DivisionTypeInDb = await context.LT_DivisionType.FirstOrDefaultAsync(x => x.DivisionType_Code == DivisionType.DivisionType_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    System.Net.IPAddress clientIp = (HttpContext.Features.Get<IHttpConnectionFeature>()?.LocalIpAddress);
                    //string clientIp = Environment.MachineName; //returns webserver
                   //string clientIp = System.Net.Dns.GetHostName(); //returns webserver
                    //string clientIp = System.Environment.GetEnvironmentVariable("COMPUTERNAME").ToString();//returns webserver


                    string userNameModified = Environment.GetEnvironmentVariable("USERNAME");
                   
                   
                    
                    DivisionTypeInDb.DivisionNameEn = DivisionType.DivisionNameEn ?? DivisionTypeInDb.DivisionNameEn;
                    DivisionTypeInDb.DivisionNameAr = DivisionType.DivisionNameAr ?? DivisionTypeInDb.DivisionNameAr;
                    
                   
                    

                    DivisionTypeInDb.ModifiedBy = userNameModified ;//Country.ModifiedBy ?? countryInDb.ModifiedBy;
                    DivisionTypeInDb.ModifiedOn = DivisionType.ModifiedOn ?? DateTime.Now;
                    DivisionTypeInDb.IPAddress = clientIp.ToString();  //Country.IPAddress ?? countryInDb.IPAddress;
                    DivisionTypeInDb.isActive = DivisionType.isActive==false?false:true;


                    
                    context.Entry(DivisionTypeInDb).State = EntityState.Modified;
                    var result =await  context.SaveChangesAsync();

                   return mapper.Map<LT_DivisionType,LT_DivisionTypeDTO>(DivisionTypeInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }

// -------------------------------------------------------------------

// -------------------------------------------------------------------

[HttpDelete ("/api/DeletedDivisionType")]
        public async Task <LT_DivisionTypeDTO> DeleteDivisionType (string DivisionType_Code) {
        try
            {
                 var DivisionTypeInDb = await context.LT_DivisionType.FirstOrDefaultAsync(x => x.DivisionType_Code == DivisionType_Code);
                    // if (countryInDb == null)
                    // {
                    //     return BadRequest();
                    // }

                    context.Entry(DivisionTypeInDb).State = EntityState.Deleted;
                    var result = await context.SaveChangesAsync();

                    

                    return mapper.Map<LT_DivisionType,LT_DivisionTypeDTO>(DivisionTypeInDb);

                     

            }
        catch(AutoMapperMappingException autoMapperException)
        {
                    throw autoMapperException.InnerException; 
        
        }

        }



// -------------------------------------------------------------------

#endregion LT_DivisionType
    }
}