using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperExample.Sources
{
 public class SourceClassModel
  {

    public int Id { get; set; }
    public string FirstName { get; set; }
    public  string LastName { get; set; }

    public string Address { get; set; }

    public SourceClassModel(int id, string firstName, string lastName, string address)
    {
      Id = id;
      FirstName = firstName;
      LastName = lastName;
      Address = address;
    }
  }
}
