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

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Edit()
    {
        return View();
    }

    public IActionResult DeleteConfirmation()
    {
        return View();
    }
 }
