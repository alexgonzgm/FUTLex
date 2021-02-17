using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FUTLex.Data;
using FUTLex.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FUTLex.Controllers
{
    public class UsuariosController : Controller
    {
        private ApplicationDbContext context;
        public UsuariosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var usuarioActual = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return View(this.context.Users.ToList());
        }
    }
}