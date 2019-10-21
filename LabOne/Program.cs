using System;

namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            string awnser = "y";

            do
            {
                Console.WriteLine("Enter Length:");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                width = double.Parse(Console.ReadLine());

                double parameter = 2 * width + 2 * length;
                double area = length * width;

                Console.WriteLine("Area:" + area);
                Console.WriteLine("Parameter:" + parameter);
                Console.WriteLine("Continue? y/n");
                awnser = Console.ReadLine().ToLower();


                if (awnser == "n")
                {
                    Console.WriteLine("Goodbye");
                }
                else if (awnser != "y" && awnser != "n") //promts user to enter correct input
                {
                    Console.WriteLine("Please enter a y or n");
                    awnser = Console.ReadLine().ToLower();
                }
            } while (awnser == "y");
        }
    }
}
