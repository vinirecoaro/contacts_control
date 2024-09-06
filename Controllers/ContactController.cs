using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContactsControl.Models;
using ContactsControl.Repository;

namespace ContactsControl.Controllers;

public class ContactController : Controller
{

    private readonly IContactRepository _contatoRepository;

    public ContactController(IContactRepository contactRepository)
    {
        _contatoRepository = contactRepository;
    }

    public IActionResult Index()
    {
        List<ContactModel> contacts = _contatoRepository.FetchAll();
        return View(contacts);
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
