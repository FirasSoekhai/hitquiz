using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hitquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vraag 1:");
            Console.WriteLine("In welk jaar begon de productie van de 'Mazda MX-5 NA?'");
            Console.WriteLine("A: 1986");
            Console.WriteLine("B: 1987");
            Console.WriteLine("C: 1988");
            Console.WriteLine("D: 1989");
            string name = Console.ReadLine();
            if(name.ToLower() == "d")
            {
                Console.WriteLine("Goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. Het antwoord is D.");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 2:");
            Console.WriteLine("Wat was de snelste auto in de jaren 80?");
            Console.WriteLine("A: Ferarri F40");
            Console.WriteLine("B: Porsche 959");
            Console.WriteLine("C: Lamborghini Countach");
            Console.WriteLine("D: Dodge Viper Concept ");
            name = Console.ReadLine();
            if (name.ToLower() == "a")
            {
                Console.WriteLine("Goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. Het antwoord is A.");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 3:");
            Console.WriteLine("Hoeveel pk heeft de Mazda RX-7 FC uit 1987?");
            Console.WriteLine("A: 176 PK");
            Console.WriteLine("B: 181 PK");
            Console.WriteLine("C: 193 PK");
            Console.WriteLine("D: 206 PK");
            name = Console.ReadLine();
            if (name.ToLower() == "b")
            {
                Console.WriteLine("Goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. Het antwoord is B.");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 4:");
            Console.WriteLine("Wat is de topsnelheid van de 3e generatie Toyota Supra?");
            Console.WriteLine("A: 200 KMH");
            Console.WriteLine("B: 217 KMH");
            Console.WriteLine("C: 225 KMH");
            Console.WriteLine("A: 232 KMH");
            name = Console.ReadLine();
            if (name.ToLower() == "c")
            {
                Console.WriteLine("Goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. Het antwoord is C.");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 5:");
            Console.WriteLine("Wat voor motor gebruikt de Porsche 959?");
            Console.WriteLine("A: 2.8 liter twin turbocharged flat 6");
            Console.WriteLine("B: 2.9 liter twin turbocharged V8");
            Console.WriteLine("C: 3.9 liter V12");
            Console.WriteLine("D: 8.0 liter V10");
            name = Console.ReadLine();
            if (name.ToLower() == "a")
            {
                Console.WriteLine("goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. Volgende vraag.");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 6:");
            Console.WriteLine("Waar staat de Toyota MR2 bekend voor?");
            Console.WriteLine("A: Het uiterlijk");
            Console.WriteLine("B: Overstuur");
            Console.WriteLine("C: De PK's");
            Console.WriteLine("D: De motorligging ");
            name = Console.ReadLine();
            if (name.ToLower() == "b") 
            {
                Console.WriteLine("Goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. Het antwoord is B.");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 7:");
            Console.WriteLine("Wie was de beste coureur van de jaren 80?");
            Console.WriteLine("A: Nelson Piquet");
            Console.WriteLine("B: Jacques Laffite");
            Console.WriteLine("C: Nelson Piquet");
            Console.WriteLine("D: Alan Jones");

            name = Console.ReadLine();
            if (name.ToLower() == "d")
            {
                Console.WriteLine("Goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. Het antwoord is D.");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 8:");
            Console.WriteLine("Wie was het meeste uitgevallen in f1 van de jaren 80?");
            Console.WriteLine("A: Jean-Piere Jabouille");
            Console.WriteLine("B: Nelson Piquet");
            Console.WriteLine("C: Jacques Laffite");
            Console.WriteLine("D: Keke Rosberg");
            name = Console.ReadLine();
            if (name.ToLower() == "a")
            {
                Console.WriteLine("Goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. Het antwoord is a.");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 9:");
            Console.WriteLine("Hoeveel kostte de Ferrari F40 in de jaren 80?");
            Console.WriteLine("A: $330,000");
            Console.WriteLine("B: $340,000");
            Console.WriteLine("C: $350,000");
            Console.WriteLine("D: $360,000");
            name = Console.ReadLine();
            if (name.ToLower() == "b")
            {
                Console.WriteLine("Goed! Volgende vraag.");
            }
            else
            {
                Console.WriteLine("Fout. het antwoord is C");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Vraag 10:");
            Console.WriteLine("Hoe word de Citroen 2CV ook wel genoemd?");
            Console.WriteLine("A: De lelijke eend");
            Console.WriteLine("B: De trage eend");
            Console.WriteLine("C: De misvormde eend");
            Console.WriteLine("D: De achterlijke eend");
            name = Console.ReadLine();
            if (name.ToLower() == "a")
            {
                Console.WriteLine("Goed! Dit was de laatste vraag. Hoeveel had Jij goed?");
            }
            else
            {
                Console.WriteLine("Fout. Het andwoord was A");
                Console.WriteLine("Dit was de laatste vraag. Hoeveel had jij goed?");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("1-3 vragen goed: best wel shit");
                Console.WriteLine("4-6 vragen goed: gemiddeld");
                Console.WriteLine("7-9 vragen goed: goed gedaan");
                Console.WriteLine("10 vragen goed: perfecte score");
                name = Console.ReadLine();
                if (name.ToLower() == "1" || name.ToLower() == "2" || name.ToLower() == "3")
                {
                    Console.WriteLine("Volgende keer beter");
                }
                if (name.ToLower() == "4" || name.ToLower() == "5" || name.ToLower() == "6")
                {
                    Console.WriteLine("Niet verkeerd, maar het kan beter");
                }
                if (name.ToLower() == "7" || name.ToLower() == "8" || name.ToLower() == "9")
                {
                    Console.WriteLine("Goed gedaan");
                }
                if (name.ToLower() == "10")
                {
                    Console.WriteLine("Lekker dan, perfecte score");
                }
            }

            Console.ReadLine();
            
        }
    }
}
