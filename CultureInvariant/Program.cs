﻿using System;
using System.Globalization;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor = 10.500;

            Console.WriteLine(valor);
            Console.WriteLine(valor.ToString("F2"));
            Console.WriteLine(valor.ToString("F3", CultureInfo.InvariantCulture));

            // CultureInfo.InvariantCulture = invariável de cultura... trás da forma padrão do sistema, e não da cultura do país ( , ou .) 


        }
    }
}

