using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Final_Multiplataforma.Models;

namespace Proyecto_Final_Multiplataforma.Controllers
{
    public class ProductoController : Controller
    {
        private MongoContext _context;
        public ProductoController(MongoContext m) {
            _context = m;
        }

        public IActionResult Index(){
            var lista = _context.Productos.ToList();
            return View(lista);
        }
        public IActionResult AgregarProd(){
            ViewBag.Categorias = _context.Categorias.ToList();            
            return View();
        }
        [HttpPost]
        public IActionResult AgregarProd(Productos p)
        {
            if (ModelState.IsValid) {
                _context.Add(p);
                _context.SaveChanges();
                TempData["mensaje"] = "El producto fue registrado exitosamente";
                return RedirectToAction("Index");
            }
            ViewBag.Categorias = _context.Categorias.ToList();
            return View(p);
        }
 
    }
}