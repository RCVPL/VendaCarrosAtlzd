using Microsoft.AspNetCore.Mvc;
using VendaCarros.Models;

namespace VendaCarros.Controllers;

public class CompradorController : Controller 
{
     public readonly VendaCarrosContext _context;

     public CompradorController (VendaCarrosContext context)
     {
        _context = context;
     }

     public IActionResult Index()
     {
        return View(_context.Comprador);
     }

   //SHOW
     public IActionResult Show(int id)
     {
        Comprador comprador_context.Comprador.Find(id);

        if(comprador == null)
        {
            return NotFound();
        }
        return View(comprador);
     }

   //DELETE
     public IActionResult Delete(int id)
    {
        Comprador comprador = _context.Comprador.Find(id);

        if(comprador == null)
        {
            return NotFound();
        }
        _context.Comprador.Remove(comprador);
        _context.SaveChanges();
        return View(comprador);
    }

    //UPDATE
    public IActionResult Update (int id)
    {
        Comprador comprador  = _context.Comprador.Find(id);

        if(comprador == null)
        {
            return NotFound();
        }
        return View(comprador);
    }

    [HttpPost]
    public IActionResult Update
    (int id, [FromForm] string nome, [FromForm] string cpf, [FromForm] string modelo, [FromForm] double valor)
    {
        Comprador comprador = _context.Comprador.Find(id);
        if(comprador == null)
        {
            return NotFound();
        }
        comprador.Id = id;
        comprador.Nome = nome;
        comprador.CPF = cpf;
        comprador.Modelo = modelo;
        comprador.Valor = valor;
        
        _context.Comprador.Update(Comprador);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    //CREATE
    public IActionResult Create (Comprador comprador)
    {
        if(!ModelState.IsValid)
        {
           return View(comprador);
        } 
        
        _context.Comprador.Add(comprador);
        _context.SaveChanges();   

        return RedirectToAction("Index");
    }

  
}