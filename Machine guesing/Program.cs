using System;

namespace Machine_guesing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool g = false;
            int min = 0;
            int max = 100;

            do
            {

                try
                {


                    int test = (max - min) / 2 + min;
                    write(test);
                    int red = int.Parse(Console.ReadLine());

                    if (red == 0)
                    {
                        max = test;
                    }
                    if (red == 1)
                    {
                        min = test;
                    }
                    if (red == 2)
                    {
                        g = true;
                    }
                }
                catch
                {
                    Main(null);
                }
            }
            while (g == false);


            Console.SetCursorPosition(1,11);
            Console.WriteLine("Press enter to play again...");
            Console.ReadLine();
            Main(null);


        }
        static void write(int text)
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("   Console guesing game  ");
            Console.WriteLine("=========================");
            Console.WriteLine("  0 - is bigger");
            Console.WriteLine("  1 - is smaller");
            Console.WriteLine("  2 - it is this number");
            Console.WriteLine("=========================");
            Console.WriteLine("The number: " + text);
            Console.WriteLine("=========================");
            Console.WriteLine("Your input:");
            Console.WriteLine("=========================");
            Console.SetCursorPosition(12, 9);
        }
    }
}
