using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarterKitAspNetCoreWebApp.Models;
using StarterKitAspNetCoreWebApp.Presistance;
using StarterKitAspNetCoreWebApp.DTO;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http.Features;

namespace StarterKitAspNetCoreWebApp.Controllers {
    public class LT_CountryController : Controller {
        private readonly StarterKitProjectDBContext context;
        private readonly IMapper mapper;




        public LT_CountryController (StarterKitProjectDBContext context, IMapper mapper) {
            this.mapper = mapper;
            this.context = context;

        }


        #region LT_CountryAPI

        // -------------------------------------------------------------------
        [HttpGet("/api/Countries")]
        public async Task<IEnumerable<LT_CountryDTO>> GetCountries()
        {
            try
            {
                var Countries = await context.LT_Country.OrderBy(x => x.Id).ToListAsync();
                return mapper.Map<List<LT_Country>, List<LT_CountryDTO>>(Countries);
            }
            catch (AutoMapperMappingException autoMapperException)
            {
                throw autoMapperException.InnerException;
                // this will break your call stack
                // you may not know where the error is called and rather
                // want to clone the InnerException or throw a brand new Exception
            }

        }

        // -------------------------------------------------------------------
        [HttpGet("/api/CountriesGovermenates")]
        public async Task<IEnumerable<LT_CountryDTO>> GetCountriesGovermenates()
        {
            try
            {
                var Countries = await context.LT_Country.Include(m => m.LT_Governorate).ToListAsync();
                return mapper.Map<List<LT_Country>, List<LT_CountryDTO>>(Countries);
            }
            catch (AutoMapperMappingException autoMapperException)
            {
                throw autoMapperException.InnerException;

            }

        }


        // -------------------------------------------------------------------     
        [HttpGet("/api/Country")]
        public async Task<LT_CountryDTO> GetCountry(string Country_Code)
        {
            try
            {



                var country = await context.LT_Country.FirstOrDefaultAsync(x => x.Country_Code == Country_Code);
                return mapper.Map<LT_Country, LT_CountryDTO>(country);



            }
            catch (AutoMapperMappingException autoMapperException)
            {
                throw autoMapperException.InnerException;

            }

        }
        // -------------------------------------------------------------------

        [HttpPost("/api/AddCountry")]
        public async Task<LT_CountryDTO> AddCountry(LT_Country Country)
        {
            try
            {
                //if (!ModelState.IsValid)
                // return BadRequest();



                var lastCountry = await context.LT_Country.OrderByDescending(x => x.Country_Code).FirstOrDefaultAsync();
                var lastRefNO = await context.LT_LookupTableReferance.FirstOrDefaultAsync(x => x.LookupNameEn == "Country");

                string code = "";
                if (lastCountry != null)
                {
                    if (int.TryParse(lastCountry.Country_Code.Split('-')[1], out int lastCode))
                    {
                        code = lastRefNO.LookupCode + "-" + (lastRefNO.LastSerialNo + 1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                    }
                    else
                        code = lastRefNO.LookupCode + "-" + (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');
                }
                else
                    code = lastRefNO.LookupCode + "-" + (1).ToString().PadLeft(lastRefNO.PadLeftNo, '0');

                Country.Country_Code = code;
                context.Entry(Country).State = EntityState.Added;

                lastRefNO.LastSerialNo = lastRefNO.LastSerialNo + 1;
                context.Entry(lastRefNO).State = EntityState.Modified;



                var result = await context.SaveChangesAsync();

                return mapper.Map<LT_Country, LT_CountryDTO>(Country);



            }
            catch (AutoMapperMappingException autoMapperException)
            {
                throw autoMapperException.InnerException;

            }

        }



        // -------------------------------------------------------------------


        [HttpPut("/api/UpdateCountry")]
        public async Task<LT_CountryDTO> UpdateCountry(LT_Country Country)
        {
            try
            {
                var countryInDb = await context.LT_Country.FirstOrDefaultAsync(x => x.Country_Code == Country.Country_Code);
                // if (countryInDb == null)
                // {
                //     return BadRequest();
                // }

                System.Net.IPAddress clientIp = (HttpContext.Features.Get<IHttpConnectionFeature>()?.LocalIpAddress);
                //string clientIp = Environment.MachineName; //returns webserver
                //string clientIp = System.Net.Dns.GetHostName(); //returns webserver
                //string clientIp = System.Environment.GetEnvironmentVariable("COMPUTERNAME").ToString();//returns webserver


                string userNameModified = Environment.GetEnvironmentVariable("USERNAME");




                countryInDb.CountryNameAr = Country.CountryNameAr ?? countryInDb.CountryNameAr;
                countryInDb.CountryNameEn = Country.CountryNameEn ?? countryInDb.CountryNameEn;
                countryInDb.Capital = Country.Capital ?? countryInDb.Capital;
                countryInDb.NationalityDescAr = Country.NationalityDescAr ?? countryInDb.NationalityDescAr;
                countryInDb.NationalityDescEn = Country.NationalityDescEn ?? countryInDb.NationalityDescEn;
                countryInDb.IsGCC = Country.IsGCC == false ? false : true;
                countryInDb.IACOCode = Country.IACOCode == 0 ? countryInDb.IACOCode : Country.IACOCode;
                countryInDb.Alpha2Code = Country.Alpha2Code ?? countryInDb.Alpha2Code;
                countryInDb.Alpha3Code = Country.Alpha3Code ?? countryInDb.Alpha3Code;
                countryInDb.DialCode = Country.DialCode ?? countryInDb.DialCode;

                countryInDb.ModifiedBy = userNameModified;//Country.ModifiedBy ?? countryInDb.ModifiedBy;
                countryInDb.ModifiedOn = Country.ModifiedOn ?? DateTime.Now;
                countryInDb.IPAddress = clientIp.ToString();  //Country.IPAddress ?? countryInDb.IPAddress;
                countryInDb.isActive = Country.isActive == false ? false : true;



                context.Entry(countryInDb).State = EntityState.Modified;
                var result = await context.SaveChangesAsync();

                return mapper.Map<LT_Country, LT_CountryDTO>(countryInDb);



            }
            catch (AutoMapperMappingException autoMapperException)
            {
                throw autoMapperException.InnerException;

            }

        }

        // -------------------------------------------------------------------

        [HttpDelete("/api/DeletedCountry")]
        public async Task<LT_CountryDTO> DeleteCountry(string Country_Code)
        {
            try
            {
                var countryInDb = await context.LT_Country.FirstOrDefaultAsync(x => x.Country_Code == Country_Code);
                // if (countryInDb == null)
                // {
                //     return BadRequest();
                // }

                context.Entry(countryInDb).State = EntityState.Deleted;
                var result = await context.SaveChangesAsync();



                return mapper.Map<LT_Country, LT_CountryDTO>(countryInDb);



            }
            catch (AutoMapperMappingException autoMapperException)
            {
                throw autoMapperException.InnerException;

            }

        }



        // -------------------------------------------------------------------


        #endregion  LT_CountryAPI

        #region LT_CountryView





        [Route("/Lookup/Country")]
        public ActionResult index()
        {
            var Model = new LT_Country();
            return View(Model);
            //  return View();
        }

        [Route("/Lookup/Country/Form")]
        public async Task<ActionResult> form(string countryCode = null)
        {
            if (countryCode == null)
            {
                return View(new LT_Country());
            }
            else
            {
                var countryToEdit = await context.LT_Country.FirstOrDefaultAsync(x => x.Country_Code == countryCode);
                if (countryToEdit == null)
                    return RedirectToAction("index");
                return View(countryToEdit);
            }
        }

        #endregion LT_CountryView



    }
}