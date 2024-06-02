using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_POO_smartphone.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string modelValue, string imei, int storageValue) : base(number, modelValue, imei, storageValue)
        {
        }

        public override void InstalApp(string appName)
        {
            Console.WriteLine($"Instalando {appName}");
            DisplayLoadingBar();
            Console.WriteLine($"\r{appName} instalado.                            ");
        }
    }
}