using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperExample.ComplexSources
{
  public class ComplexAddress
  {
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string Line3 { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public ComplexAddress()
    { }
    public ComplexAddress(string line1, string line2, string line3, string state, string country)
    {
      Line1 = line1;
      Line2 = line2;
      Line3 = line3;
      State = state;
      Country = country;
    }
  }
}
