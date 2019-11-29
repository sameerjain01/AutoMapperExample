using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperExample.ComplexDestinations
{
  public class DestinationComplexModelWithSamePropNames
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DestinationAddressWithSamePropNames Address { get; set; }

    public DestinationComplexModelWithSamePropNames(int id, string firstName, string lastName, DestinationAddressWithSamePropNames address)
    {
      Id = id;
      FirstName = firstName;
      LastName = lastName;
      Address = address;
    }
  }
}
