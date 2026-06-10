using Microsoft.AspNetCore.Mvc;

namespace MeuPrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Tiago Tavares";
            ViewBag.Curso = "Analise e Desenvolvimento de Software";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;
            
            ViewBag.Nome = "Aluno ID " + id;
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Situacao = "Matriculado";

            return View();
        }
    }
}