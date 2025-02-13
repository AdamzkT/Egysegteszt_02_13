using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egysegteszt_AdamszkiTamas
{
    public class Rectangle
    {
        public double CalculateArea(double width, double height)
        {
            if(width < 0 || height < 0) { throw new Exception("Legth of sides can't be negative."); }
            return width * height;
        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            double a = inputDouble("A téglalap egyik oldala: ");
            double b = inputDouble("A téglalap másik oldala: ");
            Console.WriteLine("A téglalap területe: " + r.CalculateArea(a,b));

            Console.ReadKey();
        }

        private static double inputDouble(string text)
        {
            while (true) {
                try
                {
                    Console.Write(text);
                    double szam = Convert.ToDouble(Console.ReadLine());
                    if (szam < 0) { Console.WriteLine(" - Nem lehet az oldalhossz negatív"); }
                    else { return szam; }
                }
                catch { Console.WriteLine(" - Rossz bemenet."); }
            }
        }
    }
}
