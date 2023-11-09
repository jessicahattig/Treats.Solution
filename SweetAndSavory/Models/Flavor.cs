using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Description { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}