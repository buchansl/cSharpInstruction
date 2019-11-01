using System;

namespace BootcampCSharpDay1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("C# Day 1!");

            int a = 5;
            int b = 10;
                int sum = a + b;

            Console.WriteLine("sum = "+sum);

            string choice = "y";
           /* while (choice.Equals("y")) {
                Console.WriteLine("ina while loop");
                Console.Write("Choice?");
                choice = Console.ReadLine();
                Console.WriteLine("choice =" + choice);
            }*/
            if( sum > 10) {
                Console.WriteLine("sum greater than 10");
            }
            else {
                Console.WriteLine("sum less than or equal to 10");
            }
           
           /* Console.WriteLine("Enter a number: ");
            String nbrStr = Console.ReadLine();
            int nbr = Convert.ToInt32(nbrStr);
            Console.WriteLine("nbr = "+nbr);*/
            double d1 = 4.5;
            double d2 = 5.7;
            int sum2 = (int)(d1 + d2);
            Console.WriteLine(sum2);


            Random random = new Random();
            int r1 = random.Next();
            Console.WriteLine("r1 = "+r1);

            int r2 = random.Next(10);
            Console.WriteLine("r2 = " + r2);
            while (r2 != 10) {
                r2 = random.Next(10);
                r2++;
                Console.WriteLine("r2=" + r2);

            }
            double d3 = 75.73884774;
            Console.WriteLine(Math.Round(d3));
            Console.WriteLine(Math.Round(d3,2));


            double price = 15.99;
            double pdt = .03467;
                Console.WriteLine("price form " + price.ToString("C2"));
            Console.WriteLine("pct form " + price.ToString("P3"));
            Console.WriteLine("bye");
        }
    }
}
