using DevOpsTesting.WebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevOpsTesting.WebApp.ViewModels
{
    public class CalculadoraViewModel
    {
        public CalculadoraViewModel()
        {

        }

        public CalculadoraModel CalculadoraModel { get; set; }
        public bool EsCalculado { get; set; }

        public void Sumar()
        {
            if (CalculadoraModel == null)
                throw new ArgumentNullException(nameof(CalculadoraModel), "Se espera el modelo.");

            CalculadoraModel.Resultado = CalculadoraModel.Numero1 + CalculadoraModel.Numero2;
            EsCalculado = true;
        }
    }
}
