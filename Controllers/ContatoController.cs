using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContactsControl.Models;

namespace ContactsControl.Controllers;

public class ContatoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
 }
