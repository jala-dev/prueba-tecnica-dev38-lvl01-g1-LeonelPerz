﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class SavePaymentView
    {
        public InputData RequestData()
        {
            return Show();
        }

        private InputData Show()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio a pagar deudas: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());

            return input;
        }
    }
}
