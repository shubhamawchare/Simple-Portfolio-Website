using Microsoft.AspNetCore.Mvc;
using ShubhamPortfolio.Models;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult About() => View();
    public IActionResult Contact() => View();

    public IActionResult Projects()
    {
        var projects = new List<Project>
        {
            new Project {
                Id = 1,
                Title = "Future Shock",
                Description = "A third-person shooter using Photon Engine.",
                Technologies = "Unity, C#",
                Link = "https://github.com/shubhamawchare/Future-Shock"
            },
            new Project {
                Id = 2,
                Title = "Drone Shooter ",
                Description = "A drone shooting first person game in unreal engine 5 using blueprints.",
                Technologies = "Unreal Engine 5, Blueprints",
                Link = "https://github.com/shubhamawchare/Killer-Drones"
            },
            new Project {
                Id = 3,
                Title = "Notes App",
                Description = "Developed a full-featured CRUD web application to create, read, update, and delete personal notes using ASP.NET Core MVC.",
                Technologies = "ASP.NET Core MVC, Bootstrap 5, Razor Pages, Entity Framework Core",
                Link = "https://github.com/shubhamawchare/Notes-App"
            }
        };

        return View(projects);
    }
}
