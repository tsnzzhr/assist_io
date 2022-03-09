using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using q1.Models;

namespace q1.Controllers;
public class q1Controller : Controller
{
    public IActionResult Index(int id)
    {
        return View(id);
    }

    public IActionResult Profile(int id)
    {
        return View(id);
    }
    
    public IActionResult Products(int id)
    {
        return View(id);
    }

    public IActionResult Collaborations(int id)
    {
        return View(id);
    }

    public IActionResult Company(int id)
    {
        return View(id);
    }

    public IActionResult SignIn(int id)
    {
        return View(id);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
