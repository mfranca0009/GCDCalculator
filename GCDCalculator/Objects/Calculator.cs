/************************************************************
 *                                                          *
 *  Author:        Matthew Franca                           *
 *  Course:        C# Programming                           *
 *  File:          Calculator.cs                            *
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

namespace GCDCalculator.Objects
{
    class Calculator
    {
        public Calculator() { }
        public int GreatestCommonDivisor(int a, int b)
        {

            int temp;
            int remainder;

            if (b > a)
            {

                temp = a;
                a = b;
                b = temp;
            }

            while (b > 0)
            {

                remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }
    }
}
