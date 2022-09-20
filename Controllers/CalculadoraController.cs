using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;
namespace Calculadora.Controllers;

public class CalculadoraController : Controller
{

    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }

    public IActionResult Calculadora()
    {        
        return View();
    }
    
    public IActionResult Resultado([FromForm] double n1, [FromForm] double n2,[FromForm] int operation )
    {    
        ViewData["n1"] = n1;
        ViewData["n2"] = n2;

        switch (operation)
        {

            case 1:
                ViewData["result"] = n1 - n2;
                ViewData["action"] = "-";
                break;

            case 2:
                ViewData["result"] = n1 + n2;
                ViewData["action"] = "+";
                break;
	
           case 3:
                ViewData["result"] = n1 * n2;
                ViewData["action"] = "*";
                break;   

            case 4:
                ViewData["result"] = n1 / n2;
                ViewData["action"] = "/";
                break;

            default:
                break;
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}