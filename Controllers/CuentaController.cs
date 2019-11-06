using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Final_Multiplataforma.Models;

namespace Proyecto_Final_Multiplataforma
{
    public class CuentaController : Controller
    {
        private MongoContext _mg;
        private SignInManager<IdentityUser> _sim;
        private UserManager<IdentityUser> _um;
        private RoleManager<IdentityRole> _rm;

        public CuentaController(MongoContext mg , SignInManager<IdentityUser> sim, UserManager<IdentityUser> um , RoleManager<IdentityRole> rm) {
            _mg=mg;
            _sim=sim;
            _um=um;
            _rm=rm;
        }
        
         public IActionResult AsociarRol(){
            ViewBag.Usuarios = _um.Users.ToList();
            ViewBag.Roles = _rm.Roles.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AsociarRol(string usuario, string rol) {
            var user = _um.FindByIdAsync(usuario).Result;
            var resultado = _um.AddToRoleAsync(user, rol).Result;
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

            return RedirectToAction("index", "home");
        }

        public IActionResult CrearCuenta() {
            return View();
        }

        public IActionResult AccesoDenegado() {
            return View();
        }

        [HttpPost]
        public IActionResult CrearCuenta(CrearCuenta model) {
            if (ModelState.IsValid) {
                var usuario = new IdentityUser();
                usuario.UserName = model.Correo;
                usuario.Email = model.Correo;

                IdentityResult resultado = _um.CreateAsync(usuario, model.Contraseña1).Result;
                var r = _um.AddToRoleAsync(usuario,"Usuario").Result;


                if (resultado.Succeeded) {
                    return RedirectToAction("index", "home");
                }
                else {
                    foreach (var item in resultado.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }                
            }

            return View(model);
        }

        public IActionResult Login() {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login model) {

            if (ModelState.IsValid) {

             
                var resultado = _sim.PasswordSignInAsync(model.Correo, model.Contraseña, true, false).Result;

                if (resultado.Succeeded) {

                    return RedirectToAction("index","home");
                }
                else {
                    
                    ModelState.AddModelError("", "Datos incorrectos");
                }
            }        

            return View(model);
        }

        public IActionResult Logout() {
            _sim.SignOutAsync();

            return RedirectToAction("index","home");
        }
    }
}