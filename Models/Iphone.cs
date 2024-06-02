using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_POO_smartphone.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string modelValue, string imei, int storageValue) : base(number, modelValue, imei, storageValue)
        {
        }

        public override void InstalApp(string appName)
        {
            Console.CursorVisible = false;
            Console.Write($"Verificando arquivo");
            Thread.Sleep(1300);
            Console.WriteLine($"\rInstalando {appName}                           "                        );
            DisplayLoadingBar();
            Console.WriteLine($"\r{appName} instalado.                            ");
            Console.CursorVisible = true;
        }
    }
}