using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeuPrimeiroMVC.Models;

namespace MeuPrimeiroMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Sobre()
    {
        return View();
    }

    // NOVA ACTION ADICIONADA AQUI
    public IActionResult Boletim()
    {
        // Listas com nomes de disciplinas e notas enviadas via ViewBag
        List<string> disciplinas = new List<string>
        {
            "Programação Web",
            "Banco de Dados",
            "Estrutura de Dados",
            "Engenharia de Software",
            "Redes de Computadores"
        };

        List<double> notas = new List<double>
        {
            8.5,
            5.5,
            9.0,
            7.0,
            4.5
        };

        ViewBag.Disciplinas = disciplinas;
        ViewBag.Notas = notas;

        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}