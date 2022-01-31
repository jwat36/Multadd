/*Think Sharp: How to Think Like a Computer Scientist
 * By Allen B. Downey and Peter J. Knaggs
 * 
 * This code is in reference to Chapter 5, exercise 5.2, pages 56-57
 * Exercise 5.2. Many computations can be expressed concisely using the “multadd” opera-
tion, which takes three operands and computes a * b + c. Some processors even provide

a hardware implementation of this operation for floating-point numbers.
1. Create a new program called Multadd.cs.
2. Write a method called Multadd that takes three doubles as parameters and that returns their multadditionization.
3. Write a Main method that tests Multadd by invoking it with a few simple parameters, like 1.0, 2.0, 3.0.
4. Also in Main, use multadd to compute the following values:
sin π/4 + (cos π/4)/2
log 10 + log 20
5. Write a method called Yikes that takes a double as a parameter and that uses multadd to calculate
xe^−x + √(1 − e^−x)
Hint: the Math.Exp method can be used for raising e to a power.
In the last part, you get a chance to write a method that invokes a method you wrote.
Whenever you do that, it is a good idea to test the first method carefully before you start
working on the second. Otherwise, you might find yourself debugging two methods at the
same time, which can be difficult.
One of the purposes of this exercise is to practice pattern-matching: the ability to recognize
a specific problem as an instance of a general category of problems.
 */

using System;

namespace Multadd
{
    class Program
    {
        //Corresponds with step 2
        public static double Multadd(double a, double b, double c) 
        {
            double multadditionization = a * b + c;
            return multadditionization;
        }

        //Corresponds with step 3, but prompts for user input instead of using a constant
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Multadd!\n");
            
            double a, b, c;
            Console.WriteLine("Please input a value for A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a value for B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a value for C");
            c = double.Parse(Console.ReadLine());

            //Displays the user inputs and the answer from the Multadd method                        
            double compute = Multadd(a, b, c);
            Console.WriteLine($"The multadditionization of {a} * {b} + {c} is: {compute}\n");
      
            //Corresponds with step 4 part 1
            double a1, b1, c1;
            a1 = Math.Sin(Math.PI / 4);
            b1 = 1.0 / 2.0;
            c1 = Math.Cos(Math.PI / 4) / 2;
            double compute1 = Multadd(a1, b1, c1);
            Console.WriteLine("sin(pi/4) + cos(pi/4)/2 = {0}\n", compute1);

            //Corresponds with step 4 part 2
            double a2, b2, c2;
            a2 = 1.0;
            b2 = Math.Log(10);
            c2 = Math.Log(20);
            double compute2 = Multadd(a2, b2, c2);
            Console.WriteLine("log(10) + log(20) = {0}\n", compute2);
            
            //Calls Yikes method from step 5, to see the result
            Yikes(compute);
        }
        //Corresponds with step 5
        public static void Yikes(double x)
        {
            double a3 = x;
            double b3 = Math.Exp(-x);
            double c3 = Math.Sqrt(1.0 - b3);
            Console.WriteLine("xe^(-x) + sqrt(1 - e^(-x)) = {0}", Multadd(a3, b3, c3));
        }
    }
}
