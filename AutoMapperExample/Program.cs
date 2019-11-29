using System;
using AutoMapperExample.ComplexSources;
using AutoMapperExample.Sources;


namespace AutoMapperExample
{
  class Program
  {
    static void Main(string[] args)
    {


      var sourceClassModel = new SourceClassModel(50, "John", "Doe", "100 main Street");

      ConsumerClass.NaiveAutoMappingForSimpleModel(sourceClassModel);

      ConsumerClass.AutoMappingUsingProfilesOnSimpleModel(sourceClassModel);


      var cmpAddress = new ComplexAddress("100 Main St", "West Zone", "", "AM", "ZZ");
      var compSource = new ComplexSource(90, "Jane", "Doe", cmpAddress);

      ConsumerClass.NaiveAutoMappingForComplexModel(compSource);
      ConsumerClass.AutoMappingUsingProfilesForComplexModelDifferentPropNames(compSource);

      Console.ReadKey();
    }


  }
}
