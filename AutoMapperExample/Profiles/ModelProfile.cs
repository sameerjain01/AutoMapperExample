using AutoMapper;

using AutoMapperExample.Sources;
using AutoMapperExample.SimpleDestinations;

namespace AutoMapperExample.Profiles
{

  /// <summary>
  /// this Proile maps simple Source File to SimpleDestinationWithDiffPropNames
  /// which properties names that doesn't match the source properties
  /// </summary>
  public class SimpleProfile : Profile
  {
    public SimpleProfile()
    {
      CreateMap<SourceClassModel, SimpleDestinationWithDiffPropNames>()
        .ForMember(dest => dest.IdNbr, map => map.MapFrom(src => src.Id))
        .ForMember(dest => dest.FName, map => map.MapFrom(src => src.FirstName))
        .ForMember(dest => dest.LName, map => map.MapFrom(src => src.LastName))
        .ForMember(dest => dest.Add, map => map.MapFrom(src => src.Address))
        .ReverseMap();
    }
  }
}
