using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.


            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion
            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion
            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine("Max element = " + max);
            //Console.WriteLine("Min element = " + min);

            #endregion
            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            #endregion
            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.Write("Enter a character: ");
            //char ch = char.Parse(Console.ReadLine());

            //ch = char.ToLower(ch);

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion
            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i);
            //    if (i < number)
            //        Console.Write(", ");
            //}



            #endregion
            #region 7- Write a program that allows the user to insert an integer then 
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i);

            //    if (i < 12)
            //        Console.Write(" ");
            //}
            #endregion
            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i);

            //    if (i + 2 <= number)
            //        Console.Write(" ");
            //}
            #endregion
            #region 9- Write a program that takes two integers then prints the power.

            //Console.Write("Enter the base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= exponent; i++)
            //{
            //    result *= baseNum;
            //}

            //Console.WriteLine("Output: " + result);
            #endregion
            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] marks = new int[5];
            //int total = 0;

            //Console.WriteLine("Enter marks of five subjects:");

            //for (int i = 0; i < 5; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine());
            //    total += marks[i];
            //}

            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine("Total marks = " + total);
            //Console.WriteLine("Average Marks = " + average);
            //Console.WriteLine("Percentage = " + percentage);

            #endregion
            #region 11- Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //int days;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        days = 29; 
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return;
            //}

            //Console.WriteLine("Days in Month: " + days);
            #endregion
            #region 12- Write a program to create a Simple Calculator.
            //            Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //double result;

            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Cannot divide by zero!");
            //            return;
            //        }
            //        result = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        return;
            //}

            //Console.WriteLine("Result: " + result);
            #endregion
            #region 13 - Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine("Reversed string: " + reversed);
            #endregion
            #region 14- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine("Reversed number: " + reversed);
            #endregion
            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
            //i am not complete this equation 
            #endregion
            #region 16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());

            //string binary = "";

            //if (number == 0)
            //{
            //    binary = "0";
            //}
            //else
            //{
            //    while (number > 0)
            //    {
            //        int remainder = number % 2;
            //        binary = remainder + binary; 
            //        number /= 2;
            //    }
            //}

            //Console.WriteLine("The Binary of the number is: " + binary);
            #endregion
            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Enter y3: ");
            double y3 = double.Parse(Console.ReadLine());

            // this equation i dont understand it and i get it with gpt
            double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            if (area == 0)
            {
                Console.WriteLine("The points lie on the same straight line.");
            }
            else
            {
                Console.WriteLine("The points do NOT lie on the same straight line.");
            }

            #endregion
            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.- If the worker takes 3 to 4 hours, they are instructed to increase their speed.- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.- If the worker takes more than 5 hours, they are required to leave the company.To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            Console.Write("Enter time taken to complete the task (in hours): ");
            double hours = double.Parse(Console.ReadLine());

            if (hours >= 2 && hours < 3)
            {
                Console.WriteLine("Highly efficient.");
            }
            else if (hours >= 3 && hours < 4)
            {
                Console.WriteLine("Improve your speed.");
            }
            else if (hours >= 4 && hours <= 5)
            {
                Console.WriteLine("You need training to improve your speed.");
            }
            else if (hours > 5)
            {
                Console.WriteLine("You are to leave the company.");
            }
            else
            {
                Console.WriteLine("Invalid input. Time must be 2 hours or more.");
            }
            #endregion
            #region 19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++) // الصفوف
            //{
            //    for (int j = 0; j < n; j++) // الأعمدة
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine(); // سطر جديد بعد كل صف
            //}
            #endregion
            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Enter number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //int sum = 0;

            //Console.WriteLine("Enter the elements of the array:");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element " + (i + 1) + ": ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}

            //Console.WriteLine("Sum of all elements = " + sum);
            #endregion
            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //this used array 
            #endregion
            #region -22
            //this used array 

            #endregion
            #region -23
            //this used array 
            #endregion






        }
    }
}
