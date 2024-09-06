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

    public IActionResult Edit(int id)
    {
        ContactModel contact = _contatoRepository.ListById(id);
        return View(contact);
    }

    public IActionResult DeleteConfirmation(int id)
    {
        ContactModel contact = _contatoRepository.ListById(id);
        return View(contact);
    }

    public IActionResult Delete(int id)
    {
        _contatoRepository.Delete(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Create(ContactModel contact)
    {
        _contatoRepository.Add(contact);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Edit(ContactModel contact)
    {
        _contatoRepository.Update(contact);
        return RedirectToAction("Index");
    }
 }
