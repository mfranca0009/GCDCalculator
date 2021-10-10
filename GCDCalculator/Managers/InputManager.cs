/************************************************************
 *                                                          *
 *  Author:        Matthew Franca                           *
 *  Course:        C# Programming                           *
 *  File:          InputManager.cs                          *
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

namespace GCDCalculator.Managers
{
    class InputManager
    {
        public InputManager() { }

        public int RetrieveIntInput(string numberCount)
        {
            int value = -1;

            while (value == -1)
            {
                Console.Write($"Enter {numberCount} number: ");
                value = ParseInt();
            }

            return value;
        }

        public char RetrieveCharInput()
        {
            char runInput = 'a';

            while (runInput != 'y' && runInput != 'n')
            {
                Console.Write("Would you like to continue?(y\\n): ");
                runInput = ParseChar();
            }

            return runInput;
        }

        private int ParseInt()
        {
            int value = -1;

            // Try to retrieve user input
            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                // Catch exception if the value passed is in an incorrect format to convert or empty
                Console.WriteLine("Incorrect input! Try again.\n");
                return -1; // error code, re-loop input
            }

            // Cannot be 0
            if (value == 0)
            {
                Console.WriteLine("Number must be greater than 1! Try again.\n");
                return -1; // error code, re-loop input
            }

            return value;
        }

        private char ParseChar()
        {
            char runInput;

            try
            {
                runInput = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception)
            {
                // Catch exception if the character passed is in an incorrect format to convert or empty
                Console.WriteLine("Invalid input! Try again.\n");
                return 'a'; // error character, re-loop input
            }

            // Make character into lowercase (in case Y or N was used)
            runInput = Char.ToLower(runInput);

            // input must be 'y' or 'n', if not then prompt input again.
            if (runInput != 'y' && runInput != 'n')
            {
                Console.WriteLine("Must be [y/Y] or [n/N]! Try again.\n");
                return 'a'; // error character, re-loop input
            }

            return runInput;
        }
    }
}
