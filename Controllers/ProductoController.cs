using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final_Multiplataforma.Models;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net;
using System.Net.Mail;

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

        [HttpPost]
        public IActionResult Index(int id){
            var producto = _context.Productos.Find(id);
                      
            return RedirectToAction("Orden",producto);
        }

        
        public IActionResult Orden(Productos producto){                               
            return View(producto);
        }

        [HttpPost]
        public IActionResult Orden(string nombre){
           var correo= @User.Identity.Name;
            // Credentials
            var credentials = new NetworkCredential("MongoImports@gmail.com", "Monguito13");
            // Mail message
            var mail = new MailMessage()
            {
                From = new MailAddress("MongoImports@gmail.com"),
                Subject = "Email Sender App",
                Body = "Usted esta comprando un: "+ nombre 
            };
            mail.IsBodyHtml = true;
            mail.To.Add(new MailAddress(correo));
            // Smtp client
            var client = new System.Net.Mail.SmtpClient()
            {
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Credentials = credentials
            };
            client.Send(mail);                              
                                
            return RedirectToAction("Index");
        
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

        [HttpPost]
        public IActionResult VerCategoria(int id, decimal ez){
             var producto = _context.Productos.Find(id);                      
            return RedirectToAction("Orden",producto);

        }
 
    }
}