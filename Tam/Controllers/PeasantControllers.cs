using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class PeasantController : Controller
    {
        [HttpGet("/peasants")]
        public ActionResult Index()
        {
          List<Peasant> allPeasants = Peasant.GetAll();
          return View(allPeasants);
        }

        [HttpGet("/peasants/new")]
        public ActionResult CreateForm()
        {
          return View();
        }

        [HttpPost("/peasants/")]
        public ActionResult Create()
        {
          Peasant newPeasant = new Peasant();
          List<Peasant> allPeasants = Peasant.GetAll();
          return View("Index", allPeasants);
        }
        [HttpGet("/peasants/{id}")]
        public ActionResult Details(int id)
        {
          Peasant peasant = Peasant.Find(id);
          return View(peasant);
        }




    }
}
