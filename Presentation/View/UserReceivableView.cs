using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class UserReceivableView
    {
        public InputData RequestData()
        {
            return this.GetData();
        }

        private InputData GetData()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            return input;
        }

        public void ShowResult(int id,int totalCubes, double total, string nombre)
        {
            Console.WriteLine("El consumo del socio {0},correspondiente a {3} , es de {1} cubos. La deuda actual es de {2} Bs.", id,totalCubes, total, nombre);
            Console.WriteLine("R. La deuda total del socio es: {0}",total);
            Console.WriteLine("======================================");
        }
    }
}
