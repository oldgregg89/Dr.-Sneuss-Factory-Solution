using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }
    public int MachineId {get; set; }
    public string Name { get; set;}
    public ICollection<EngineerMachine> Engineers {get;} 
  }
}