using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FUTLex.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FUTLex.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            var apikey = "7d2efef2-bc8a-45b6-8bbc-770a4d497b96";
            HttpWebRequest request = WebRequest.Create("https://futdb.app/api/clubs") as HttpWebRequest;
            request.Method = "GET";
            request.Headers.Add("X-AUTH-TOKEN", apikey);
            request.ContentType = "application/json; charset=utf-8";
            // request.Headers["Authorization"] = "X-AUTH-TOKEN" + apikey;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            StreamReader reader = new StreamReader(response.GetResponseStream());
            var jsonstring = reader.ReadToEnd();

            JObject json = JObject.Parse(jsonstring);
            IList<JToken> data = json["items"].Children().ToList();
            IList<Club> listaClubes = new List<Club>();
            foreach (var item in data)
            {
                Club nuevoc = JsonConvert.DeserializeObject<Club>(item.ToString());
                listaClubes.Add(nuevoc);
            }

            return View(listaClubes);
           // return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
