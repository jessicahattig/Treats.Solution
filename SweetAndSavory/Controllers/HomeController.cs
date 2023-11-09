using Microsoft.AspNetCore.Mvc;
using SweetAndSavory.Models;
using System.Collections.Generic;
using System.Linq;

namespace SweetAndSavory.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetAndSavoryContext _db;

    public HomeController(SweetAndSavoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Flavor[] flavors = _db.Flavors.ToArray();
      Treat[] treats = _db.Treats.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("flavors", flavors);
      model.Add("treats", treats);
      return View(model);
    }
  }
}