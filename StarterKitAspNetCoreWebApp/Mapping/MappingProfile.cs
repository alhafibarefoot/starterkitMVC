using AutoMapper;
using StarterKitAspNetCoreWebApp.Models;
using StarterKitAspNetCoreWebApp.DTO;


namespace StarterKitAspNetCoreWebApp.Mapping
{
    public class MappingProfile:Profile
    {
         
          

          public MappingProfile()
        {
            CreateMap<LT_Country,LT_CountryDTO>().ReverseMap();
           //   CreateMap<LT_CountryDTO,LT_Country>();
            CreateMap<LT_CountryDTO, LT_Country>().ForMember(c => c.Country_Code, opt => opt.Ignore());

           // CreateMap<LT_Country,LT_CountryDTO>().ReverseMap();

            CreateMap<LT_Governorate, LT_GovernorateDTO>()
                .ForMember(dest =>
                dest.LF_Country_Code,
                opt => opt.MapFrom(src => src.LT_CountryCountry_Code))

                .ReverseMap();


                CreateMap<LT_Region, LT_RegionDTO>()
                .ForMember(dest =>
                dest.LF_Governorate_Code,
                opt => opt.MapFrom(src => src.LT_GovernorateGovernorate_Code))

                .ReverseMap();

                 CreateMap<LT_Area, LT_AreaDTO>()
                .ForMember(dest =>
                dest.LF_Region_Code,
                opt => opt.MapFrom(src => src.LT_RegionRegion_Code))

                .ReverseMap();


                 CreateMap<LT_Road, LT_RoadDTO>()
                .ForMember(dest =>
                dest.LF_Area_Code,
                opt => opt.MapFrom(src => src.LT_AreaArea_Code))

                .ReverseMap();


                  CreateMap<LT_DivisionType,LT_DivisionTypeDTO>().ReverseMap();

                 CreateMap<STR_Company, STR_CompanyDTO>()
                .ForMember(dest =>
                dest.LF_DivisionType_Code,
                opt => opt.MapFrom(src => src.LT_DivisionTypeDivisionType_Code))

                .ReverseMap();

                
              

            


           
           
            
             
             
        }
    }
}