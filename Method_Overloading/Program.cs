using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 32.0m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(1,100, false);

            Console.WriteLine($"int add: {answer}; decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);


        }

        public static int Add(int num1, int num2)
        {

            return num1 + num2;

        }

        public static decimal Add(decimal num1, decimal num2)
        {

            return num1 + num2;

        }

        public static string Add(int num1, int num2, bool isValid)
        {
            
            var numSum = num1 + num2;

            if (numSum == 1 && isValid == true)
            {
                return $"{numSum} dollar";

            }
            else if (num1 + num2 != 1 && isValid == true)
            {

                return $"{numSum} dollars";

            }
            else
            {

                return numSum.ToString();

            }

        }

    }
}