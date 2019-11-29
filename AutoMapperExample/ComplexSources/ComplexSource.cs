using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperExample.ComplexSources
{
  public class ComplexSource
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ComplexAddress Address { get; set; }

    public ComplexSource()
    {
    }
    public ComplexSource(int id, string firstName, string lastName, ComplexAddress address)
    {
      Id = id;
      FirstName = firstName;
      LastName = lastName;
      Address = address;
    }
  }
}
