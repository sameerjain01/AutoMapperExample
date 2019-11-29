using AutoMapperExample.ComplexDestinations;
using AutoMapperExample.ComplexSources;

using AutoMapper;

namespace AutoMapperExample.Profiles
{
  public class ComplexProfilesWithDiffPropNames:Profile
  {
    public ComplexProfilesWithDiffPropNames()
    {
      CreateMap<ComplexAddress, DestinationAddressWithDiffPropNames>()
        .ForMember(dest => dest.AddressCountry, map => map.MapFrom(src => src.Country))
        .ForMember(dest => dest.AddressLine1, map => map.MapFrom(src => src.Line1))
        .ForMember(dest => dest.AddressLine2, map => map.MapFrom(src => src.Line2))
        .ForMember(dest => dest.AddressLine3, map => map.MapFrom(src => src.Line3))
        .ForMember(dest => dest.AddressState, map => map.MapFrom(src => src.State))
        .ReverseMap();

      CreateMap<ComplexSource, DestinationComplexModelWithDiffPropNames>()
         .ForMember(dest => dest.FName, map => map.MapFrom(src => src.FirstName))
         .ForMember(dest => dest.LName, map => map.MapFrom(src => src.LastName))
       //  .ForMember(dest => dest.Addr, map => map.MapFrom(src => src.Address))
          .ForMember(dest => dest.IdNbr, map => map.MapFrom(src => src.Id))
          .ReverseMap();
    }
   
  }
}
