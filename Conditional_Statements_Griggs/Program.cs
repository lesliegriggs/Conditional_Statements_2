// Author: Leslie Griggs
// ISM 4300
// 6 September 2022
using System;

namespace Conditional_Statements_Griggs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300? Enter an integer: ");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                if (98 <= grade && grade <= 100)
                {
                    Console.WriteLine("Your grade is an A+");
                }
                else if (92 <= grade && grade <= 97) 
                    
                { 
                    Console.WriteLine("Your grade is an A");
                }
                else if (90 <= grade && grade <= 91)

                {
                    Console.WriteLine("Your grade is an A-");
                }
                else if (88 <= grade && grade <= 89)

                {
                    Console.WriteLine("Your grade is a B+");
                }
                else if (82 <= grade && grade <= 87)

                {
                    Console.WriteLine("Your grade is a B");
                }
                else if (80 <= grade && grade <= 81)

                {
                    Console.WriteLine("Your grade is a B-");
                }
                else if (78 <= grade && grade <= 79)

                {
                    Console.WriteLine("Your grade is a C+");
                }
                else if (72 <= grade && grade <= 77)

                {
                    Console.WriteLine("Your grade is a C");
                }
                else if (70 <= grade && grade <= 71)

                {
                    Console.WriteLine("Your grade is a C-");
                }
                else if (68 <= grade && grade <= 69)

                {
                    Console.WriteLine("Your grade is a D+");
                }
                else if (62 <= grade && grade <= 67)

                {
                    Console.WriteLine("Your grade is a D");
                }
                else if (60 <= grade && grade <= 62)

                {
                    Console.WriteLine("Your grade is a D-");
                }
                else if (grade <= 60)

                {
                    Console.WriteLine("Your grade is an F");
                }
            }

            catch
            {
                Console.WriteLine("Use integer data type for grade");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                
            }
        }
    }
}