using System;
using System.Globalization;
using System.Text;

namespace FivePointedStar
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введите значение длины стороны правильной пятиконечной звезды: ");

            if (Double.TryParse(Console.ReadLine(), out double length))
            {
                FivePointedStar star = new FivePointedStar(length);

                Console.WriteLine($"Result:\n{star}");
            }
            else
            {
                Console.WriteLine("Fatal error...");
            }
        }
    }
}
