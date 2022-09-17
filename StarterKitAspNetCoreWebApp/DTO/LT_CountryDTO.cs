using System.Collections.Generic;

using StarterKitAspNetCoreWebApp.Models;

namespace StarterKitAspNetCoreWebApp.DTO
{
    public class LT_CountryDTO : BaseEntity
    {
        public int Id { get; set; }

        public string Country_Code { get; set; }

        public string CountryNameEn { get; set; }

        public string CountryNameAr { get; set; }

        public string Capital { get; set; }

        public string NationalityDescAr { get; set; }

        public string NationalityDescEn { get; set; }

        public bool IsGCC { get; set; }

        public int IACOCode { get; set; }

        public string Alpha2Code { get; set; }

        public string Alpha3Code { get; set; }

        public string Region { get; set; }

        public string SubRegion { get; set; }

        public string Region_Code { get; set; }

        public string SubRegion_Code { get; set; }

        public string DialCode { get; set; }

        //---------------------------Forign Tables
        public virtual ICollection<LT_GovernorateDTO> LT_Governorate { get; set; }

        // public LT_CountryDTO()
        // {
        //    LT_Governorate = new Collection<LT_GovernorateDTO>();
        // }
    }
}
