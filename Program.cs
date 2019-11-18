/* CODE OF HONOR: I have not discussed the source code in my program with anyone other than my 
 * instructor’s approved human sources. I have not used source code obtained from another student, 
 * or any other unauthorized source, either modified or unmodified. If any source code or documentation 
 * used in my program was obtained from another source, such as a textbook or course notes, that 
 * has been clearly noted with a proper citation in the comments of my program. I have not knowingly 
 * designed this program in such a way as to defeat or interfere with the normal operation of any 
 * machine it is graded on or to produce apparently correct results when in fact it does not. */

using System;


namespace ProgrammingAssignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] baseNumbers = new long[5];
            long[] exponents = new long[5];
            long[] results = new long[5];           
            Random rnd = new Random();

            // Populate arrays with 5 random numbers each
            for (int i = 0; i < 5; i++)
            {
                baseNumbers[i] = rnd.Next(1, 51);
                exponents[i] = rnd.Next(1, 11);
            }

            // Get the results of arrays (base^exponents)
            for (int i = 0; i < 5; i++)
            {
                results[i] = Power(baseNumbers[i], exponents[i]);
            }

            // Call PrintArrays() method to print our data
            PrintArrays(baseNumbers, exponents, results);


            // Wait for user to press the enter key before exiting
            Console.WriteLine("Press the [enter] key to continue.");
            // Intercept all other keys except enter key
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

        }
        
        /// <summary>
        /// Calculate the power a 5 number.
        /// </summary>
        /// <param name="baseNum">The number to multiply by itself.</param>
        /// <param name="exponent">The number of times to multiply baseNum.</param>
        /// <returns></returns>
        static long Power(long baseNum, long exponent)
        {
            // Have we reached end of recursion?
            if (exponent == 0)
            {
                // Escape recursion
                return 1;
            }
            else
            {
                // Multiply (base * base) until exponent == 0
                return baseNum * Power(baseNum, exponent - 1);
            }
        }

        /// <summary>
        /// Prints every element of array[] args.
        /// </summary>
        /// <param name="basenumbers"></param>
        /// <param name="exponents"></param>
        /// <param name="results"></param>
        static void PrintArrays(long[] basenumbers, long[] exponents, long [] results)
        {
            // Print headers
            Console.WriteLine("Base\t Exponent\t Result");
          
            // Print all 3 parameter arrays in the same loop since they all have  
            // the same length and we need to print the same number of elements
            for (int i = 0; i <=basenumbers.GetUpperBound(0); i++)
            {
                Console.WriteLine("{0}\t {1}\t\t {2}", basenumbers[i].ToString(), exponents[i].ToString(), results[i].ToString());
            }
        }
    }
}
