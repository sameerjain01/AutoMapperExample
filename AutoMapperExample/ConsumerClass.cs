using AutoMapper;
using AutoMapperExample.AutoMappers;
using AutoMapperExample.ComplexDestinations;
using AutoMapperExample.ComplexSources;
using AutoMapperExample.Profiles;
using AutoMapperExample.SimpleDestinations;
using AutoMapperExample.Sources;
using Newtonsoft.Json;
using System;


namespace AutoMapperExample
{
  public static class ConsumerClass
  {
    public static void AutoMappingUsingProfilesOnSimpleModel(SourceClassModel sourceClassModel)
    {
      Console.WriteLine("**** Starting Automap using Profile On Simple object  ***");
      Console.WriteLine("Starting Naive Mapping using AutoMapper where Property names between source and destination are NOT identical");
      Console.WriteLine("This is the Original Values");
      Console.WriteLine(JsonConvert.SerializeObject(sourceClassModel));

      IMapper mapper = MapperConfiguration<SourceClassModel, SimpleDestinationWithDiffPropNames>.GetConfigWithProfile<SimpleProfile>();

      var simpleDestinationDiff = mapper.Map<SimpleDestinationWithDiffPropNames>(sourceClassModel);
      Console.WriteLine("Output Model");
      Console.WriteLine(JsonConvert.SerializeObject(simpleDestinationDiff));
      Console.WriteLine("**** Ending Automap using Profile On Simple objec   ***");
    }

    public static void NaiveAutoMappingForSimpleModel(SourceClassModel sourceClassModel)
    {
      Console.WriteLine("This is the Original Values");
      Console.WriteLine(JsonConvert.SerializeObject(sourceClassModel));

      Console.WriteLine("**** Starting Naive Automap   ***");
      Console.WriteLine("Starting Naive Mapping using AutoMapper where Property names between source and destination are identical");
      IMapper simpleMapper = MapperConfiguration<SourceClassModel, SimpleDestination>.GetSimpleCongfig();

      var simpleDestination = simpleMapper.Map<SimpleDestination>(sourceClassModel);

      Console.WriteLine("Output Model");
      Console.WriteLine(JsonConvert.SerializeObject(sourceClassModel));
      Console.WriteLine("**** Ending Naive Automap   ***");
    }

    public static void AutoMappingUsingProfilesForComplexModelDifferentPropNames(ComplexSource sourceCLass)
    {
      Console.WriteLine("This is the Original Values");
      Console.WriteLine(JsonConvert.SerializeObject(sourceCLass));

      Console.WriteLine("**** Starting AutoMapping Using Profiles For Complex Model Different PropNames  ***");
      IMapper cpxProfileWithSamePropNames = MapperConfiguration<ComplexSource, DestinationComplexModelWithDiffPropNames>.GetConfigWithProfile<ComplexProfilesWithDiffPropNames>();

      var cmplxDest = cpxProfileWithSamePropNames.Map<DestinationComplexModelWithDiffPropNames>(sourceCLass);

      Console.WriteLine("Output Model");
      Console.WriteLine(JsonConvert.SerializeObject(sourceCLass));
      Console.WriteLine("**** Ending AutoMapping Using Profiles For Complex Model Different PropNames    ***");
    }

    public static void NaiveAutoMappingForComplexModel(ComplexSource sourceCLass)
    {
      Console.WriteLine("This is the Original Values");
      Console.WriteLine(JsonConvert.SerializeObject(sourceCLass));

      Console.WriteLine("**** Starting Naive AutoMapping For ComplexModel  ***");
      Console.WriteLine("Starting Naive Mapping using AutoMapper where Property names between source and destination are identical");
      IMapper cpxProfileWithSamePropNames = MapperConfiguration<ComplexSource, DestinationComplexModelWithSamePropNames>.GetConfigWithProfile<ComplexProfilesWithSamePropNames>();

      var cmplxDest = cpxProfileWithSamePropNames.Map<DestinationComplexModelWithSamePropNames>(sourceCLass);

      Console.WriteLine("Output Model");
      Console.WriteLine(JsonConvert.SerializeObject(sourceCLass));
      Console.WriteLine("**** Ending Naive AutoMapping For ComplexModel   ***");
    }
  }
}
