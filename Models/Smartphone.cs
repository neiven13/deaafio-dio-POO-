using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_POO_smartphone.Models
{
    public abstract class Smartphone
    {
        private string phoneNumber;
        public string PhoneNumber 
        { 
            get => phoneNumber; 
            set
            {
                if(value.Length!=11 || value.Any(c => !char.IsDigit(c)))
                {
                    throw new Exception("Número de telefone inválido.");
                }
                phoneNumber = value;
            } 
        }
        private string model, IMEI;
        private int storage;

        public Smartphone(string number, string modelValue, string imei, int storageValue)
        {
            PhoneNumber = number;
            model = modelValue;
            IMEI = imei;
            storage = storageValue;
        }

        public void MakeACall()
        {
            Console.CursorVisible = false;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\rFazendo Ligação ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write('.');
                    Thread.Sleep(300);
                }
                Console.Write("\rFazendo Ligação       ");
                Thread.Sleep(50);
            }
            Console.Write("\rLigação encerrada.\n");
            Console.CursorVisible = true;
        }

        public void IncomingCall()
        {
            Console.CursorVisible = false;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\rRecebendo ligação ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write('.');
                    Thread.Sleep(300);
                }
                Console.Write("\rRecebendo ligação       ");
                Thread.Sleep(50);
            }
            Console.Write("\rLigação encerrada.\n");
            Console.CursorVisible = true;
        }

        protected void DisplayLoadingBar()
        {
            Console.CursorVisible = false;
            int total = 20;

            for (int i = 0; i <= total; i++)
            {
                Console.Write("\r[");

                for (int j = 0; j < i; j++)
                {
                    Console.Write('\u25a0'+" ");
                }
                for (int j = i; j < total; j++)
                {
                    Console.Write('\u25a1'+" ");
                }
                Console.Write(']');
                Thread.Sleep(200);
            }
            Console.CursorVisible = true;
        }

        public abstract void InstalApp(string appName);
    }
}