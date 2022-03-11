using DevIo.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIo.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        public IActionResult Index()
        {
            var aluno = new Aluno {
                Nome = "Filipe",
                DataNascimento = DateTime.Now,
                Email = "teste@gmail.com"
            };

            return View();
        }
    }
}
