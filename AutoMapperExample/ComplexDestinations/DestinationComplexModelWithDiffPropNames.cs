using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperExample.ComplexDestinations
{
 public class DestinationComplexModelWithDiffPropNames
  {
    public int IdNbr { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }

    public DestinationAddressWithSamePropNames Addr { get; set; }

    public DestinationComplexModelWithDiffPropNames()
    {
    }

    public DestinationComplexModelWithDiffPropNames(int idNbr, string fName, string lName, DestinationAddressWithSamePropNames addr)
    {
      IdNbr = idNbr;
      FName = fName;
      LName = lName;
      Addr = addr;
    }
  }
}
