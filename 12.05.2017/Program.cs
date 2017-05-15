using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masinin 100km-e ne qeder benzin isdetdiyin qeyd edin!");
            double serfiyat =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Yanacag ceninin hecmini qeyd edin!");
            int yanacaq_ceni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masini surmek ucun benzin elave edin(litrle)");
            double benzin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. Masini sur (paramter olaraq km olacaq sistem yoxlamasi gerekirki bak-da olan benzin-le bu qeder gede biler mi?)");
            Console.WriteLine("2. Benzin doldur (parametr olaraq litr alacaq. Yoxlayacaqki elave olunan litr bak-in kapasitesini asirmi? )");
            Console.WriteLine("3. Local Distance. Masinin local olaraq ne qeder yol getdiyini deyecek ve sifirlana bilecek");
            Console.WriteLine("4. Global Distance. Masinin global olaraq ne qeder getdiyini deyecek ve sifirlana bilinmeyecek");
            Console.WriteLine("0. Exit");
            Cars audi = new Cars();
            audi.FuelUsage = serfiyat;
            audi.FuelCapacity = yanacaq_ceni;
            audi.addFuel(benzin);
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                audi.possibleDistance();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(audi.possibleDistance().ToString() + "km gede bilersiniz");

            }
            else if(choose==2)
            {
                Console.WriteLine("Nece litr benzin daxil etmek isdediynizi daxil edin");
                int a;
                a = Convert.ToInt32(Console.ReadLine());
                if (audi.checkFuelAviable(a)==true)
                {
                    Console.WriteLine(a+"litr yanacag elave olundu");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Benzin tutumunu kecdiniz.Tutumdan artiq benzin elave oluna bilmez");
                }
            }
            else if (choose == 3)
            {
                audi.possibleDistance();
                audi.ascLocalDistance(audi.possibleDistance());
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(audi.LocalDistance.ToString()+"km gedmisiniz");
            }
            else if (choose == 4)
            {
                audi.possibleDistance();
                audi.ascGlobalDistance(audi.possibleDistance());
                Console.ForegroundColor = ConsoleColor.DarkCyan;
               Console.WriteLine(audi.GlobalDistance.ToString() + "km gedmisiniz");
            }
            Console.ReadLine();
        }
    }
}
