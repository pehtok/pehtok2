using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pehtok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует помощник Peh, по переходу на сайты ГДЗ. Ниже представлен список предметов: ");
            Console.WriteLine("1. Математика");
            Console.WriteLine("2. Русский язык");
            Console.WriteLine("3. Физика");
            Console.WriteLine("4. Информатика");
            Console.WriteLine("Выберите, что вас интересует: ");
            string sao;
            sao = Console.ReadLine();
            if (sao == "1")
            {
                Process.Start("https://gdz.ru/matematika");
            }
            if (sao == "2")
            {
                Process.Start("https://gdz.ru/russkii_yazik");
            }
            if (sao == "3")
            {
                Process.Start("https://gdz.ru/fizika");
            }
            if (sao == "4")
            {
                Process.Start("https://gdz.ru/informatika");
            }
        }
    }
}
