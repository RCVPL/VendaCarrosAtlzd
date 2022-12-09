using Microsoft.AspNetCore.Mvc;
using VendaCarros.Models;

namespace VendaCarros.Controllers;

public class CarroController : Controller 
{
    private readonly VendaCarrosContext _context;

    public CarroController(VendaCarrosContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Carro);
    }

    public IActionResult Show(int id)
    {
        Carro carro = _context.Carro.Find(id);

        if(carro == null)
        {
            return NotFound();
        }

        return View(carro);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Carro carro)
    {
        if(!ModelState.IsValid) 
        {
            return View(carro);
        }

        _context.Carro.Add(carro);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
        [HttpGet]
    public IActionResult Update(int id)
    {
        Carro carro = _context.Carro.Find(id);

        if(carro == null)
        {
            return NotFound();
        }

        return View(carro);
    }

    [HttpPost]
    public IActionResult Update(Carro carro, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(carro);
        }
        
        Carro updateCarro = _context.Carro.Find(carro.Id);
        
        updateCarro.Nome = carro.Nome;
        updateCarro.Continente = carro.Continente;
        updateCarro.Vagas = carro.Vagas;

        _context.Carro.Update(updateCarro);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Carro carro = _context.Carro.Find(id);

        if(carro == null)
        {
            return NotFound();
        }
        
        _context.Carro.Remove(_context.Carro.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }


}
