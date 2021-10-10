/************************************************************
 *                                                          *
 *  Author:        Matthew Franca                           *
 *  Course:        C# Programming                           *
 *  File:          Runner.cs                                *
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

using System;
using GCDCalculator.Managers;

namespace GCDCalculator.Objects
{
    class Runner
    {
        private InputManager inputManager;

        public Runner() { inputManager = new InputManager(); }

        public void InputDriver(Calculator calc)
        {
            char runInput = 'y';                                                               

            while (runInput == 'y')
            {
                // Clear console from previous results or error messages, helps with readability.
                //Console.Clear();

                // Prompt user for first and second number
                int firstNumber = inputManager.RetrieveIntInput("first");
                int secondNumber = inputManager.RetrieveIntInput("second");

                // Calculate result and display it
                int result = calc.GreatestCommonDivisor(firstNumber, secondNumber);
                Console.WriteLine("\nGreatest Common Divisor");
                Console.WriteLine("-----------------------------------------------\n");
                Console.WriteLine($"Greatest Common Divisor of {firstNumber} and {secondNumber}: {result}\n");
                Console.WriteLine("-----------------------------------------------\n");

                runInput = inputManager.RetrieveCharInput();
            }
        }
    }
}
