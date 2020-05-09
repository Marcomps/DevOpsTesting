using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsTesting.WebApp.Models;
using DevOpsTesting.WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsTesting.WebApp.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            var calculadoraViewModel = new CalculadoraViewModel()
            {
                CalculadoraModel = new CalculadoraModel()
                {
                    Numero1 = 0,
                    Numero2 = 0,
                    Resultado = 0
                }
            };

            return View(calculadoraViewModel);
        }

        [HttpPost]
        public IActionResult Calcular([FromForm]CalculadoraViewModel calculadoraViewModel)
        {
            calculadoraViewModel.Sumar();

            return View(calculadoraViewModel);
        }
    }
}