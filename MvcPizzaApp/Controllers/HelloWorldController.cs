using Microsoft.AspNetCore.Mvc;
using MvcPizzaApp.Models;

namespace MvcPizzaApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name="Sif",Age=2};
            return View(doggo);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
              return View(dogViewModel);
        }

        public string Hello()
        {
            return "Who's there";
        }
    }
}
