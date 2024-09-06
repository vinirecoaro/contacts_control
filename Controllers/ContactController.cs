using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContactsControl.Models;
using ContactsControl.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        try
        {
            bool deleted = _contatoRepository.Delete(id);
            if(deleted){
                TempData["SuccessMessage"] = "Contato excluido com sucesso";
            }else{
                TempData["ErrorMessage"] = $"Não foi possível excluir seu contato, tente novamente";
            }
            return RedirectToAction("Index");
        }
        catch (System.Exception error)
        {
            TempData["ErrorMessage"] = $"Não foi possível excluir seu contato, tente novamente, detalhe do erro: {error.Message}";
            throw;
        }
    }

    [HttpPost]
    public IActionResult Create(ContactModel contact)
    {
        try
        {
            if(ModelState.IsValid){
                _contatoRepository.Add(contact);
                TempData["SuccessMessage"] = "Contato cadastrado com sucesso";
                return RedirectToAction("Index");
            }
            return View(contact);
        }
        catch (System.Exception error)
        {
            TempData["ErrorMessage"] = $"Não foi possível cadastrar seu contato, tente novamente, detalhe do erro: {error.Message}";
            throw;
        }
    }

    [HttpPost]
    public IActionResult Edit(ContactModel contact)
    {
       try
       {
        if(ModelState.IsValid){
            _contatoRepository.Update(contact);
            TempData["SuccessMessage"] = "Contato alterado com sucesso";
            return RedirectToAction("Index");
       }
        return View(contact);
       }
       catch (System.Exception error)
       {
            TempData["ErrorMessage"] = $"Não foi possível alterar seu contato, tente novamente, detalhe do erro: {error.Message}";
            throw;
       }
    }
 }
