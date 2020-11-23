using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = 0;
            string bin = "";
            Console.WriteLine("Escriba su numero:");
            n = int.Parse(Console.ReadLine());

            while (true){
                if ((n % 2) != 0)
                    bin = "1" + bin;
                else
                    bin = "0" + bin;
                n /= 2;
                if (n <= 0)
                    break;


            }
            Console.WriteLine("Su resultado es:" + bin);
            Console.ReadKey();
        }
    }
}
