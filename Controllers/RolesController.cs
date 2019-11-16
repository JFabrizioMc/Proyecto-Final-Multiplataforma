using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Final_Multiplataforma.Models;


namespace Proyecto_Final_Multiplataforma.Controllers
{
    [Authorize(Roles="admin")]
    public class RolesController : Controller
    {
        private MongoContext _context;
        private SignInManager<IdentityUser> _sim;
        private UserManager<IdentityUser> _um;
        private RoleManager<IdentityRole> _rm;
        public RolesController(
            MongoContext c,  
            SignInManager<IdentityUser> s,
            UserManager<IdentityUser> um,
            RoleManager<IdentityRole> rm) {

            _context = c;
            _sim = s;
            _um = um;
            _rm = rm;
        }

        public IActionResult AsociarRol()
        {
            ViewBag.Usuarios = _um.Users.ToList();
            ViewBag.Roles = _rm.Roles.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AsociarRol(string usuario, string rol) {
            var user = _um.FindByIdAsync(usuario).Result;

            var resultado = _um.AddToRoleAsync(user, rol).Result;
            TempData["mensaje"] = "Cuenta asociada";

            return RedirectToAction("index", "home");
        }

        public IActionResult CrearRol()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearRol(string nombre)
        {
            var rol = new IdentityRole();
            rol.Name = nombre;

            var resultado = _rm.CreateAsync(rol).Result;
            TempData["mensaje"] = "Rol creado";
            return RedirectToAction("index", "home");
        }
        
    }
}