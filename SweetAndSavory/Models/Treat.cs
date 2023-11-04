using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
    public ApplicationUser User { get; set; } 
  }
}