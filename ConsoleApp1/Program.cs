using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Массив базового типа Printer
            Printer[] printers = new Printer[]
            {
                new Printer(),
                new RedPrinter(),
                new GreenPrinter(),
                new BluePrinter()
            };

           for (int i = 0;i< 4; i++)
            {
               
                Console.ResetColor();

                Console.WriteLine("Доброго времени суток");
            }
            
            
            //// Перебираем и вызываем метод Print 
            //foreach (var printer in printers)
            //{
            //    // приведение к типу Printer 
            //    Printer p = (Printer)printer;
            //    p.Print("Доброго времени суток!");
            //}

           
            Console.ReadKey();
        }
    }
}

