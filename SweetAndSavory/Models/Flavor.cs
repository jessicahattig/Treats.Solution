using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweetAndSavory.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The Flavor's description can't be empty!")]
    public string Description { get; set; }

    public List<TreatFlavor> JoinEntities { get; }
  }
}