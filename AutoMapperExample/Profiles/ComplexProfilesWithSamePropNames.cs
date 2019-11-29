using AutoMapper;
using AutoMapperExample.ComplexDestinations;
using AutoMapperExample.ComplexSources;


namespace AutoMapperExample.Profiles
{
  public class ComplexProfilesWithSamePropNames : Profile
  {

    public ComplexProfilesWithSamePropNames()
    {
      CreateMap<ComplexAddress, DestinationAddressWithSamePropNames>()
        .ReverseMap();

      CreateMap<ComplexSource, DestinationComplexModelWithSamePropNames>()
        .ReverseMap();
    }
  }
}

