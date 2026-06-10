using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>
            {
                "Notebook Gamer",
                "Mouse Sem Fio",
                "Teclado Mecânico",
                "Monitor 24 polegadas",
                "Headset HyperX"
            };

            List<double> precos = new List<double>
            {
                4500.00,
                150.50,
                320.00,
                899.90,
                420.00
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}