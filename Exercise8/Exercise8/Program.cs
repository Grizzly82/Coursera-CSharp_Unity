using System;
using static Exercise8.Die;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die die1 = new Die();
            Die die2 = new Die();

            Console.WriteLine(die1.NumSides);

            // tell the dice to roll themselves
            die1.Roll();
            die2.Roll();

            // print the top sides and the sum of the dice
            int sum = die1.TopSide + die2.TopSide;
            Console.WriteLine("die1 top #: " + die1.TopSide + ", die2 top #: " + die2.TopSide + ", The SUM is: "
                + sum);
        }
    }
}
