using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperExample.ComplexDestinations
{
  public class DestinationAddressWithDiffPropNames
  {
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public string AddressState { get; set; }
    public string AddressCountry { get; set; }

    public DestinationAddressWithDiffPropNames(string addressLine1, string addressLine2, string addressLine3, string addressState, string addressCountry)
    {
      AddressLine1 = addressLine1;
      AddressLine2 = addressLine2;
      AddressLine3 = addressLine3;
      AddressState = addressState;
      AddressCountry = addressCountry;
    }
  }
}
