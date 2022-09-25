using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace Operacoes.Controllers;

public class OperacoesController : Controller
{

    private readonly ILogger<OperacoesController> _logger;

    public OperacoesController(ILogger<OperacoesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Soma()
    {
        return View();
    }

    public IActionResult Subtração()
    {
        return View();
    }

    public IActionResult Multiplicação()
    {
        return View();
    }

    public IActionResult Divisão()
    {
        return View();
    }
    
     public IActionResult ResultadoSoma([FromForm] double n1, [FromForm] double n2)
     {
        ViewData["n1"] = n1;
        ViewData["n2"] = n2;
        ViewData["resultado"] = n1 + n2;
        return View();
     }
    
     public IActionResult ResultadoSubtracao([FromForm] double n1, [FromForm] double n2)
     {
        ViewData["n1"] = n1;
        ViewData["n2"] = n2;
        ViewData["resultado"] = n1 - n2;
        return View();
     }
    
      public IActionResult ResultadoMultiplicacao([FromForm] double n1, [FromForm] double n2)
      {
        ViewData["n1"] = n1;
        ViewData["n2"] = n2;
        ViewData["resultado"] = n1 * n2;
        return View();
      }
    
      public IActionResult ResultadoDivisao([FromForm] double n1, [FromForm] double n2)
      {
        ViewData["n1"] = n1;
        ViewData["n2"] = n2;
        ViewData["resultado"] = n1 / n2;
        return View();
      }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
