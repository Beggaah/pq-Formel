using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqFormel
{
    class Program
    {
        double a, p, q, d, w;
        static void Main(string[] args)
        {
            Program pqFormel = new Program();
            pqFormel.eingabeWerte();
            pqFormel.teileDurchA();
            pqFormel.berechneDeterminante();
            pqFormel.berechneWurzel();
            pqFormel.berechneNullstellen();
            Console.ReadKey();
        }

        public void teileDurchA()
        {
            if (a > 1)
            {
                p = p / a;
                q = q / a;
            }
        }

        public void berechneDeterminante()
        {
            d = Math.Pow((p / 2.0), 2) - q;
        }

        public void berechneWurzel()
        {
            if (d >= 0)
            {
                w = Math.Sqrt(d);
            }
            else
                Console.WriteLine("wurzel ist negativ!");
        }

        public void berechneNullstellen()
        {
            if (w == 0)
            {
                Console.WriteLine("Einzige Nullstelle ist: " + (-(p / 2)));
            }
            else
            {
                Console.WriteLine("Erste Nullstelle ist: " + (-(p / 2) + w));
                Console.WriteLine("Zweite Nullstelle ist: " + (-(p / 2) - w));
            }
        }

        public void eingabeWerte()
        {
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("p = ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("q = ");
            q = Convert.ToDouble(Console.ReadLine());
        }
    }
}
