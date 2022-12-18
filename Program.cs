using System;

namespace Moon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double srednaSkorost = double.Parse(Console.ReadLine());
            double litriGorivoZa100km = double.Parse(Console.ReadLine());
            int raztoqnie = 384400;

            double otivaneIvrushtane = raztoqnie * 2;
            double time = Math.Ceiling(otivaneIvrushtane / srednaSkorost);
            double totalTime = time + 3;
            double gorivo = (litriGorivoZa100km * otivaneIvrushtane) / 100;

            Console.WriteLine(totalTime);
            Console.WriteLine(gorivo);



        }
    }
}
