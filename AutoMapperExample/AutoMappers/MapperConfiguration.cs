using AutoMapper;
using Microsoft.Extensions.DependencyInjection;


namespace AutoMapperExample.AutoMappers
{
  public static class MapperConfiguration<TSource, TDestination>
  {
    public static IMapper GetSimpleCongfig()
    {
      var config = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<TSource, TDestination>()
        .ReverseMap();
      });
      return config.CreateMapper();

    }

    public static IMapper GetConfigWithProfile<TProfile>()where TProfile: Profile,new() {
      var config = new MapperConfiguration(cfg =>
      {
        cfg.AddProfile<TProfile>();
      //  cfg.CreateMap<TSource, TDestination>();
        
      });
      return config.CreateMapper();
    }

  
  }
}
