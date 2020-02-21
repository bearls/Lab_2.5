using System;

namespace ConsoleApp2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets do math!");
            int num1= Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num2 - num1);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num2/num1);



            Console.WriteLine("Hello");
            string greeting1 = Console.ReadLine();

            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num3 * num4 * num5);


            int guessedAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("You look younger than" + " " + guessedAge);
            Console.ReadLine();


        }
    }
}
