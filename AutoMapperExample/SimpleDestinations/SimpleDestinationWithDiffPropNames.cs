using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperExample.SimpleDestinations
{
 public class SimpleDestinationWithDiffPropNames
  {
    public int IdNbr { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }

    public string Add { get; set; }

    public SimpleDestinationWithDiffPropNames()
    { }
    public SimpleDestinationWithDiffPropNames(int idNbr, string fName, string lName, string add)
    {
      IdNbr = idNbr;
      FName = fName;
      LName = lName;
      Add = add;
    }
  }
}
