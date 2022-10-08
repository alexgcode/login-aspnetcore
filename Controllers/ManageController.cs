using Microsoft.AspNetCore.Mvc;
using aspLogin.Models;
using aspLogin.Repositories;

namespace aspLogin.Controllers
{
    public class ManageController : Controller
    {
        private RepositoryWeb repo;

        public ManageController(RepositoryWeb repo)
        {
            this.repo = repo;
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            UserModel usuario = this.repo.LogInUsuario(email, password);
            if(usuario == null)
            {
                ViewData["MENSAJE"] = "No tienes credenciales correctas";
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}