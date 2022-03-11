using DevIo.UI.Site.Data;
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
        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }
        private readonly MeuDbContext _contexto; 
        public IActionResult Index()
        {
            var aluno = new Aluno {
                Nome = "Filipe",
                DataNascimento = DateTime.Now,
                Email = "teste@gmail.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a=>a.Email == "teste@gmail.com"); //o primeiro dado
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Filipe");//todos os resultados

            aluno.Nome = "joão";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}
