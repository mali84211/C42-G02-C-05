namespace C42_G02_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            int valueType = 10;
            ModifyValueType(valueType);
            Console.WriteLine("After ModifyValueType: " + valueType); // Output: 10

            ModifyValueTypeByRef(ref valueType);
            Console.WriteLine("After ModifyValueTypeByRef: " + valueType); // Output: 20

            // Passing by value
            static void ModifyValueType(int value)
            {
                value = 20;
            }

            // Passing by reference
            static void ModifyValueTypeByRef(ref int value)
            {
                value = 20;
            }
            #endregion
            #region 3
            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            var result = Calculate(num1, num2, num3, num4);

            Console.WriteLine("Summation result: " + result.Item1);
            Console.WriteLine("Subtraction result: " + result.Item2);

            static Tuple<double, double> Calculate(double a, double b, double c, double d)
            {
                double sum = a + b;
                double difference = c - d;
                return Tuple.Create(sum, difference);
            }
            #endregion

            #region 4
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sumOfDigits = CalculateSumOfDigits(number);

            Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");

            static int CalculateSumOfDigits(int number)
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }
            #endregion

            #region 5
            //Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            Console.Write("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            bool result2 = IsPrime(number2);

            if (result2)
            {
                Console.WriteLine($"The number {number2} is prime.");
            }
            else
            {
                Console.WriteLine($"The number {number2} is not prime.");
            }

            static bool IsPrime(int number2)
            {
                if (number2 <= 1) return false;
                if (number2 == 2) return true;
                if (number2 % 2 == 0) return false;

                int boundary = (int)Math.Floor(Math.Sqrt(number2));

                for (int i = 3; i <= boundary; i += 2)
                {
                    if (number2 % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            #endregion

            #region 6
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            int[] numbers = { 5, 2, 9, 1, 7, 3 };

            int minValue, maxValue;
            MinMaxArray(numbers, out minValue, out maxValue);

            Console.WriteLine("Min value: " + minValue);
            Console.WriteLine("Max value: " + maxValue);

            static void MinMaxArray(int[] arr, out int min, out int max)
            {
                if (arr.Length == 0)
                {
                    throw new ArgumentException("Array must not be empty");
                }


                min = max = arr[0];


                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                        min = arr[i];

                    else if (arr[i] > max)
                        max = arr[i];
                }
            }
            #endregion

            #region 7
            //Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            int n = 3;

            long factorial = CalculateFactorial(n);

            Console.WriteLine($"Factorial of {n} is: {factorial}");

            static long CalculateFactorial(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentException("Factorial is not defined for negative numbers");
                }

                long factorial = 1;

                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }
            #endregion

            #region 8
            //Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            string originalString = "hello";
            int position = 1;
            char newChar = 'a';

            string modifiedString = ChangeChar(originalString, position, newChar);

            Console.WriteLine($"Original String: {originalString}");
            Console.WriteLine($"Modified String: {modifiedString}");

            static string ChangeChar(string inputString, int position, char newChar)
            {
                if (inputString == null)
                {
                    throw new ArgumentNullException(nameof(inputString), "Input string cannot be null");
                }

                if (position < 0 || position >= inputString.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range");
                }

                char[] chars = inputString.ToCharArray();
                chars[position] = newChar;

                return new string(chars);
            }
            #endregion
        }
    }
}
