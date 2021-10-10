/************************************************************
 *                                                          *
 *  Author:        Matthew Franca                           *
 *  Course:        C# Programming                           *
 *  File:          Program.cs                               *
 *                                                          *
 *  Description:   Greatest Common Denominator calculator   *
 *                 displaying the GCD for the two numbers   *
 *                 given by the user.                       *
 *                                                          *
 *  Input:         User input to retrieve two numbers to    *
 *                 find the Greatest Common Denominator     *
 *                 between the two.                         *
 *                                                          *
 *  Output:        Finds the Greatest Common Denominator    *
 *                 of the two numbers given by the user     *
 *                 and displays the result.                 *
 *                                                          *
 ************************************************************/

using GCDCalculator.Objects;

namespace GCDCalculator
{
    class Program {

        static void Main(string[] args)
        {
            Runner runner = new Runner();
            Calculator calculator = new Calculator();

            // Run application driver for test with user interaction
            runner.InputDriver(calculator);
        }
    }
}
