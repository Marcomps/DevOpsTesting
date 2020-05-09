using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsTesting.WebApp.Models;
using DevOpsTesting.WebApp.ViewModels;
using System;

namespace DevOpsTesting.UnitTests.WebApp.ViewModels
{
    [TestClass]
    public class CalculadoraViewModelUnitTest
    {
        [TestMethod]
        public void CalcularSumaDosNumeros()
        {
            CalculadoraViewModel calculadoraViewModel = new CalculadoraViewModel
            {
                CalculadoraModel = new CalculadoraModel()
                {
                    Numero1 = 1,
                    Numero2 = 2,
                    Resultado = 0
                }
            };

            calculadoraViewModel.Sumar();

            Assert.AreEqual(calculadoraViewModel.EsCalculado, true, "Se espera que el resultado cambie de estado.");
            Assert.AreEqual(calculadoraViewModel.CalculadoraModel.Resultado, 3, "La suma de los números no es el esperado.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CalcularSumaDosNumerosFail()
        {
            CalculadoraViewModel calculadoraViewModel = new CalculadoraViewModel
            {
                CalculadoraModel = null
            };

            calculadoraViewModel.Sumar();

            Assert.Fail("Se espera que el método falle.");
        }
    }
}
