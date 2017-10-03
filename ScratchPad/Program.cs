using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //C SHARP FOR LOOP EXERCISES

                //Exercise 1
                //for(int i = 1; i < 11; i++)
                //{
                //    Console.WriteLine(i);
                //}

                ////Exercise2
                //int sum = 0;
                //Console.WriteLine("First 10 natural numbers");
                //for(int i = 1; i < 11; i++)
                //{
                //    Console.Write($"{i} ");
                //    sum += i;
                //}
                //Console.WriteLine($"\nThe sum is: {sum}");

                ////Exercise3
                //Console.Write("How many numbers to sum?");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int sum = 0;
                //Console.WriteLine($"The first {n} numbers are...\n");
                //for (int i = 0; i < n;)
                //{
                //    sum += (i + 1);
                //    Console.Write($"{++i} ");
                //}
                //Console.WriteLine($"\nThe sum of {n} numbers is {sum}");

                ////Exercise4
                //Console.WriteLine("Input ten numbers...\n");
                //int sum = 0;
                //float avg;
                //for (int i = 1; i < 11; i++)
                //{
                //    Console.Write($"Number {i}: ");
                //    sum += Convert.ToInt32(Console.ReadLine());
                //}
                //avg = sum / 10;
                //Console.WriteLine($"The sum of numbers is: {sum}\nThe Average is: {avg}");

                ////Exercise5
                //Console.WriteLine("Input number of terms to cube\n");
                //int n = Convert.ToInt32(Console.ReadLine());
                //for (int i = 1; i < n + 1; i++)
                //{
                //    Console.WriteLine($"Number is: {i} and cube of {i} is: {Math.Pow(i, 3)}");
                //}

                ////Exercise6
                //Console.WriteLine("Enter a number to display a 1-10 multiplication table\n");
                //int n = Convert.ToInt32(Console.ReadLine());
                //for (int i = 1; i < 11; i++)
                //{
                //    Console.WriteLine($"{n} x {i} = {n * i}");
                //}

                ////Exercise7
                //Console.WriteLine("Enter a number to display a 1-10 multiplication table\n");
                //int n = Convert.ToInt32(Console.ReadLine());
                //for (int i = 1; i < 11; i++)
                //{
                //    for (int j = 1; j < n + 1; j++)
                //    {
                //        Console.Write($"{j} x {i} = {j * i}, ");
                //    }
                //    Console.WriteLine();
                //}

                ////Exercise8
                //Console.WriteLine("How Many odd numbers to count?");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int sum = 0;
                //Console.Write("\nThe odd Numbers are: ");
                //for(int i = 1; i < (n * 2) + 1; i += 2)
                //{
                //    Console.Write($"{i} ");
                //    sum += i;
                //}
                //Console.WriteLine($"\nThe sum of odd numbers up to {n} terms: {sum}");

                ////Exercise9
                //for (int i = 1; i < 5; i++)
                //{
                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write('*');
                //    }
                //    Console.WriteLine();
                //}

                //Exercise10
                //for (int i = 1; i < 5; i++)
                //{
                //    for (int j = 1; j < i + 1; j++)
                //    {
                //        Console.Write(j);
                //    }
                //    Console.WriteLine();
                //}

                ////Exercise11
                //for (int i = 1; i < 5; i++)
                //{
                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write(i);
                //    }
                //    Console.WriteLine();
                //}

                ////Exercise12
                //Console.WriteLine("Specify a number");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int count = 1;
                //for (int i = 1; i < n; i++)
                //{
                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write($"{count++} ");
                //    }
                //    Console.WriteLine();
                //}

                ////Exercise13
                //Console.Write("input number of rows : ");
                //int rows = Convert.ToInt32(Console.ReadLine());
                //int spc = rows - 1;
                //int count = 1;
                //for (int i = 1; i <= rows; i++, spc--)
                //{
                //    for (int k = 0; k < spc; k++)
                //    {
                //        Console.Write(" ");
                //    }
                //    for (int j = 0; j < i; j++)
                //        Console.Write($"{count++} ");
                //    Console.Write("\n");
                //}

                ////Exercise14
                //Console.WriteLine("How many rows of asterisks? ");
                //int rows = Convert.ToInt32(Console.ReadLine());
                //int spaces = (rows - 1);
                //for (int i = 1; i < rows + 1; i++, spaces--)
                //{
                //    for (int k = 0; k < spaces; k++)
                //    {
                //        Console.Write(" ");
                //    }
                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write("* ");
                //    }
                //    Console.WriteLine();
                //}

                ////Exercise15
                //Console.WriteLine("Input a number to get the factorial");
                //int num = Convert.ToInt32(Console.ReadLine());
                //int factorial = 1;
                //for (int i = 1; i <= num; i++)
                //{
                //    factorial *= i;
                //}
                //Console.WriteLine($"The factorial of {num} is {factorial}");

                ////Exercise16
                //Console.WriteLine("Enter a number to get as many even terms and their sum");
                //int num = Convert.ToInt32(Console.ReadLine());
                //int current = 2;
                //int sum = 0;
                //Console.Write($"The first {num} even numbers are: ");
                //for (int i = 0; i < num; i++)
                //{
                //    Console.Write($"{current}{(i == (num - 1) ? "" : ",")} ");
                //    sum += current;
                //    current += 2;
                //}
                //Console.WriteLine($"\nThe sum is: {sum}");

                ////Exercise17
                //Console.WriteLine("How many rows?");
                //int rows = Convert.ToInt32(Console.ReadLine());
                //int spaces = rows - 1;
                //for (int i = 1; i <= rows; i++, spaces--)
                //{
                //    for (int k = 0; k < spaces; k++)
                //    {
                //        Console.Write(" ");
                //    }
                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write($"{i} ");
                //    }
                //    Console.WriteLine();
                //}

                ////Exercise18
                //Console.WriteLine("Give an x value" );
                //int x = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("How many terms? ");
                //int terms = Convert.ToInt32(Console.ReadLine());
                //double currentTerm = 1, sum = 1, denominator = 1;
                //Console.WriteLine("Term 1: 1");
                //for (int i = 1; i < terms; i++)
                //{
                //    denominator *= (2 * i) * (2 * i - 1);
                //    currentTerm = -(Math.Pow(x, 2 * i)) / denominator;
                //    sum += currentTerm;
                //    Console.WriteLine($"Term {i + 1}: {currentTerm}");
                //}
                //Console.WriteLine($"Sum of terms is {sum}");



                ////Exercise19
                //Console.WriteLine("How many terms for harmonic series? ");
                //int terms = Convert.ToInt32(Console.ReadLine());
                //double sum = 0;
                //for (int i = 1; i <= terms; i++)
                //{
                //    Console.Write($"1/{i}{(i == terms ? "" : " + ")}");
                //    sum += (1 / (double)i);
                //}
                //Console.WriteLine($"\nSum of harmonic series of {terms} terms is: {sum}");

                ////Exercise20
                //Console.WriteLine("How many rows of asterisks?");
                //int rows = Convert.ToInt32(Console.ReadLine());
                //int spaces = rows - 1;
                //for (int i = 1; i <= rows; i++, spaces--)
                //{
                //    for (int k = 0; k < spaces; k++)
                //    {
                //        Console.Write(" ");
                //    }
                //    for (int j = 0; j < (i * 2) - 1; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                ////Exercise21
                //Console.WriteLine("How many terms?");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int t = 9, sum = 0;
                //Console.Write("Terms: ");
                //for (int i = 0; i < n; i++)
                //{
                //    t = t * 10 + 9;
                //    Console.Write($"{t} ");
                //    sum += t;
                //}
                //Console.WriteLine($"\nThe sum of the series = {sum}");

                ////Exercise22
                //Console.WriteLine("How many rows?");
                //int rows = Convert.ToInt32(Console.ReadLine());
                //bool one;
                //for (int i = 1; i <= rows; i++)
                //{
                //    one = (i % 2 == 0 ? false : true);
                //    for (int j = 0; j < i; j++)
                //    {
                //        Console.Write((one ? 1 : 0));
                //        one = !one;
                //    }
                //    Console.WriteLine();
                //}

                ////Exercise23
                //Console.WriteLine("Input the (integer) value of x");
                //int x = Convert.ToInt16(Console.ReadLine());
                //Console.WriteLine("Input the number of terms");
                //int terms = Convert.ToInt32(Console.ReadLine());
                //double sum = 1, lastValue = 1;
                //for (int i = 1; i < terms; i++)
                //{
                //    lastValue *= (x / i);
                //    sum += lastValue;
                //}
                //Console.WriteLine($"The sum is {sum}\nNumber of terms: {terms}\nvalue of x: {x}");

                ////Exercise24
                //Console.WriteLine("How many terms? ");
                //int terms = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Specify a value for x ");
                //int x = Convert.ToInt32(Console.ReadLine());
                //bool minus = false;
                //double sum = 0;
                //for (int i = 1; i <= terms * 2; i += 2, minus = !minus)
                //{
                //    if (minus == true)
                //    {
                //        sum -= Math.Pow(x, i);
                //    }
                //    else
                //    {
                //        sum += Math.Pow(x, i);
                //    }
                //}
                //Console.WriteLine($"The sum is {sum}");

                ////Exercise25
                //Console.WriteLine("How many terms to square? ");
                //int terms = Convert.ToInt32(Console.ReadLine());
                //double sum = 0;
                //Console.Write("Squares : ");
                //for (int i = 1; i <=terms; i++)
                //{
                //    sum += Math.Pow(i, 2);
                //    Console.Write($"{Math.Pow(i, 2)} ");
                //}
                //Console.WriteLine($"\nSum of all squares up to {terms} terms is : {sum}");

                ////Exercise26
                //Console.WriteLine("How many terms? ");
                //int terms = Convert.ToInt32(Console.ReadLine());
                //long sum = 0, current = 0;
                //for (int i = 0; i < terms; i++)
                //{
                //    current = current * 10 + 1;
                //    sum += current;
                //    Console.Write($"{current} {(i + 1 == terms ? "" : "+ ")}");
                //}
                //Console.WriteLine($"\nThe sum is {sum}");

                ////Exercise27
                //Console.WriteLine("Input a number to see if it is perfect ");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int sum = 0;
                //Console.Write($"Divisors of {n}: ");
                //for (int i = 1; i < n; i++)
                //{
                //    if (n % i == 0)
                //    {
                //        sum += i;
                //        Console.Write($"{i} ");
                //    }
                //}
                //Console.Write($"\nThe sum is {sum}, {(sum == n ? $"so {n} is a perfect number" : $"so {n} is not a perfect number")}\n");

                ////Exercise28
                //Console.WriteLine("Input beginning of range ");
                //int begin = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Input end of range ");
                //int end = Convert.ToInt32(Console.ReadLine());
                //Queue<int> perfectNums = new Queue<int>();
                //for (int i = begin; i <= end; i++)
                //{
                //    int sum = 0;
                //    for (int j = 1; j < i; j++)
                //    {
                //        if (i % j == 0)
                //        {
                //            sum += j;
                //        }
                //    }
                //    if (sum == i)
                //    {
                //        perfectNums.Enqueue(i);
                //    }
                //}
                //StringBuilder results = new StringBuilder();
                //foreach(int i in perfectNums)
                //{
                //    results.Append($"{i} ");
                //}
                //Console.WriteLine($"The perfect numbers within the range {begin}-{end} are: {results}");

                ////Exercise29
                //Console.WriteLine("Enter a number to see if it is an Armstrong Number ");
                //string inputString = Console.ReadLine();
                //double sum = 0;
                //foreach (char c in inputString)
                //{
                //    sum += Math.Pow(char.GetNumericValue(c), 3);
                //}
                //Console.WriteLine($"The sum is {sum}");
                //Console.WriteLine($"{inputString} is {(sum == Convert.ToInt32(inputString) ? "" : "not ")}an Armstrong number");

                ////Exercise30
                //Console.WriteLine("Input beginning of range ");
                //int begin = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Input end of range ");
                //int end = Convert.ToInt32(Console.ReadLine());
                //Queue<int> armstrongNums = new Queue<int>();
                //for (int i = begin; i <= end; i++)
                //{
                //    double sum = 0;
                //    string currentNum = i.ToString();
                //    foreach (char c in currentNum)
                //    {
                //        sum += Math.Pow(char.GetNumericValue(c), 3);
                //    }
                //    if (sum == i)
                //    {
                //        armstrongNums.Enqueue(i);
                //    }
                //}
                //StringBuilder results = new StringBuilder($"The armstrong numbers from {begin}-{end} are ");
                //foreach (int i in armstrongNums)
                //{
                //    results.Append($"{i} ");
                //}
                //Console.WriteLine(results);
            }
        }
    }
}
