using jquery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace jquery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
        public IActionResult PersonelEkle()
        {
           
            return Ok();
        }
        [HttpPost]
        public IActionResult PersonelEkle(kisiler kisiler)
        {
            Context context = new Context();
            context.kisilers.Add(kisiler);
            context.SaveChanges();
            return Ok();
        }


        [HttpPost]
        public IActionResult PersonelGetir()
        {

            Context context = new Context();
            var kisiler = context.kisilers.ToList();

            //List<Personel> model = new List<Personel>
            //{
            //    new Personel{ isim="samet",soyisim="yorgun",yas=21},
            //    new Personel{ isim="ahmet",soyisim="başdan",yas=25},
            //};

            return Ok(kisiler);  ///model

        }

      
    }
    //public class Personel
    //{
    //    public string isim { get; set; }
    //    public string soyisim { get; set; }
    //    public int yas { get; set; }
    //}


        

}
