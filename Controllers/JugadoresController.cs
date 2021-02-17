using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FUTLex.Helpers;
using FUTLex.Models;
using FUTLex.Repositories;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Identity;
using ScrapySharp.Extensions;

namespace FUTLex.Controllers
{
    public class JugadoresController : Controller
    {
        private IRepositoryPlayers repository;
        public JugadoresController(IRepositoryPlayers repository)
        {
            this.repository = repository;
        }
        public  IActionResult Index(string nombre )
        {
            List<int> ids = this.repository.GetJuagoresFichadosIds();
            ViewData["IDS"] = ids;
            List<Player> jugadores = new List<Player>();
            if (nombre != null)
            {
                ViewData["SEARCH"] = nombre;

               jugadores =  this.repository.GetPlayersSearch(nombre);
             
            }

           
           

            return View( jugadores);
        }

        public IActionResult Details(int id , string search)
        {
            ViewData["SEARCH"] = search;
            Player player = this.repository.GetPlayer(id, search);
            List<int> stats = ToolkitService.GetSatats(id.ToString()).Select(int.Parse).ToList();
            player = ToolkitService.MapeoDeStats(player, stats);
          
            return View(player);
        }
        
        public IActionResult Fichar(int id , string search)
        {
            this.repository.FicharJugador(id, search);
            return RedirectToAction("Index", new { nombre = search });

        }
        public IActionResult Precios(int id , string search)
        {
            List<Prices> precios = this.repository.GetPrices(id);
            return View();
        }
       
    }
}