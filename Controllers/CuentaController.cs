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
       
        public CuentaController(MongoContext mg , SignInManager<IdentityUser> sim, UserManager<IdentityUser> um ) {
            _mg=mg;
            _sim=sim;
            _um=um;
           
        }

        public IActionResult CrearCuenta() {
            return View();
        }

        [HttpPost]
        public IActionResult CrearCuenta(CrearCuentaViewModel model) {
            if (ModelState.IsValid) {
                var usuario = new IdentityUser();
                usuario.UserName = model.Correo;
                usuario.Email = model.Correo;

                IdentityResult resultado = _um.CreateAsync(usuario, model.Password1).Result;
        
                if (resultado.Succeeded) {
                    TempData["mensaje"]="Cuenta registrada.";
                    return RedirectToAction("login", "cuenta");
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

        public IActionResult AccesoDenegado() {
            return View();
        }


        public IActionResult Login() {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model) {

            if (ModelState.IsValid) {

             
                var resultado = _sim.PasswordSignInAsync(model.Correo, model.Password, true, false).Result;

                if (resultado.Succeeded) {

                    return RedirectToAction("index", "home");
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