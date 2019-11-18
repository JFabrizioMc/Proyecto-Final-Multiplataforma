using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final_Multiplataforma.Models;

namespace Proyecto_Final_Multiplataforma.Controllers
{
    
    
    public class ProductoController : Controller
    {
        private MongoContext _context;
        public ProductoController(MongoContext m) {
            _context = m;
        }
         public IActionResult Comprar(int codigo) {
            var producto = _context.Productos.Find(codigo);           
            
            return RedirectToAction("Index");
        }

        public IActionResult Index(){
            var lista = _context.Productos.ToList();
            return View(lista);

        }

        [Authorize(Roles="admin")]
        public IActionResult AgregarProd(){
            ViewBag.Categorias = _context.Categorias.ToList();            
            return View();
        }
       
        public IActionResult QuitarProd(){
            var lista = _context.Productos.ToList();
            return View(lista);
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
        [HttpPost]
         public IActionResult QuitarProd(int num)
        {
                _context.Productos.Remove(_context.Productos.Find(num));
                _context.SaveChanges();
                TempData["mensaje"] = "El producto fue removido exitosamente";
                return RedirectToAction("QuitarProd");
        }

        public IActionResult AgregarProm(){
            return View();
        }
        public IActionResult VerCategoria(int id){
    
            var productos = _context.Productos.Where(x => x.CategoriaId == id).ToList();
            

            return View(productos);

        }
 
    }
}