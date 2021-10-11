using System;

namespace TemperatureConverter
{
    class Util
    {
        public void Fah(double C)
        {
            double F;
            F = (C * 1.8) + 32;
            Console.WriteLine("temperature in Fahrenheit:{0}", F);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Enter temperature in deg C to get in Fahrenheit ");
            double C = Convert.ToDouble(Console.ReadLine());
            Util u = new Util();
            u.Fah(C);
        }
    }
}
