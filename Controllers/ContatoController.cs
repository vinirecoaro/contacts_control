using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContactsControl.Models;
using ContactsControl.Repository;

namespace ContactsControl.Controllers;

public class ContatoController : Controller
{

    private readonly IContactRepository _contatoRepository;

    public ContatoController(IContactRepository contactRepository)
    {
        _contatoRepository = contactRepository;
    }

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

    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ContactModel contact)
    {
        _contatoRepository.Add(contact);
        return RedirectToAction("Index");
    }
 }
