using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class SaveMemberView
    {
        public InputData RequestData()
        {
            return GetData();
        }

        private InputData GetData()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el id del nuevo socio: ");
            input.fields.Add("ID", Console.ReadLine());
            Console.WriteLine("1. Ingrese el nombre del nuevo socio: ");
            input.fields.Add("FirstName", Console.ReadLine());
            Console.WriteLine("1. Ingrese el Apellido del nuevo socio: ");
            input.fields.Add("SecondName", Console.ReadLine());
            return input;
        }
        private void Error()
        {
            Console.WriteLine("El id del nuevo socio debe ser unico y mayor a 5000");
        }
        
    }
}
