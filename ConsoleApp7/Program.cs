using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the Number");
            i = Convert.ToInt32(Console.ReadLine());
            if(i % 2 == 0)
            {
                Console.WriteLine("Number is Even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is Odd");
                Console.ReadLine();
            }
        }
    }
}
