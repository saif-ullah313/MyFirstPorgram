using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPorgram
{
    public class AssignmentQuestions
    {
        //Question No 1:



        //public void Sum()
        //{
        //    Console.WriteLine("Enter First Integer");
        //    var num1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter Second Integer");
        //    var num2 = Convert.ToInt32(Console.ReadLine());

        //    var sum = num1 + num2;
        //    Console.WriteLine("The Sum of Two number is : " + sum);

        //}

        //***********************************************************************************************************
        //Question No 2: 

        //

        ////public void Table()
        ////{
        ////    Console.WriteLine("Enter the Number");
        ////    var number = int.Parse(Console.ReadLine());

        ////    Console.WriteLine("Enter the Last number");
        ////    var lastNumber = int.Parse(Console.ReadLine());

        ////    for (int i = 1; i <= lastNumber; i++)
        ////    {
        ////        var value = number * i;

        ////        Console.WriteLine(number + " X " + i + " = " + value);

        ////    }
        ////}
        /////********************************************************************************************

        //Question No 3: 
        //public void EvenOddNumber()
        //{
        //    Console.WriteLine("Enter the First Number");
        //    var num1 = Convert.ToInt32(Console.ReadLine());

        //    //Console.WriteLine("Enter the last Number");
        //    //var num2 = Convert.ToInt32(Console.ReadLine());

        //    for(int i = 1; i<= num1; i++)
        //    {
        //        if(i%2 == 0)
        //        {
        //            Console.WriteLine($"{i} is an even number");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{i} is an odd number");
        //        }
        //    }
        //}

        //**************************************************************************************

        //Question No 4:
        //Show the that start with py?

        //public void AddPy()
        //{
        //    Console.WriteLine("Enter any String");
        //    var str = Console.ReadLine();

        //    if (str.StartsWith("Py") || str.StartsWith("py") || str.StartsWith("PY")) 
        //    {
        //        Console.WriteLine(str);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Py" + str);
        //    }
        //}


        //*****************************************************************************


        //Question No 5:
        //Remove a character at the specified position of a given string and return the new string


        //public void RemoveCharacter()
        //{
        //    Console.WriteLine("Enter the String");
        //    var str = Console.ReadLine();

        //    Console.WriteLine("Enter an Index");
        //    var index = Convert.ToInt32(Console.ReadLine());
        //    if (index < 0 || index > str.Length)
        //    {
        //        Console.WriteLine("Invalid Index ");
        //    }
        //    else
        //    {
        //        string result = str.Remove(index, 1);

        //        Console.WriteLine("The New String is " + result);
        //    }
        //}

        //*******************************************************************************************

        //Question No 6:
        //Write a C# program to create a new string from a given string by changing the position of the first and last characters. The string length must be broader than or equal to 1.

        //public void ExchangeCharacter()
        //{
        //    Console.WriteLine("Enter the String");
        //    var str = Console.ReadLine();

        //    var firstCharacter = str[0];

        //    var lastCharacter = str[str.Length - 1];

        //    var newStr = lastCharacter + str.Substring(1, str.Length - 2) + firstCharacter;
        //    Console.WriteLine("The New string is : " + newStr);
        //}

        //***********************************************************************************************

        //Question No 7:
        // Write a C# program to create another string from a given string with the first character of the given string added to the front and back.  

        //public void AddFrontBackCharacter()
        //{
        //    Console.WriteLine("Enter the String");
        //    var str = Console.ReadLine();

        //    var firstCharacter = str[0];



        //    var newStr = firstCharacter + str + firstCharacter;
        //    Console.WriteLine("The New string is : " + newStr);
        //}

        //Question No 8:
        //Write a C# program to check whether a given positive number is a multiple of 3 or 7.

        //public void MultipleOfThreeAndSeven()
        //{
        //    Console.WriteLine("Enter the Number:");
        //    var num = int.Parse(Console.ReadLine());
        //    if(num<0)
        //    {
        //        Console.WriteLine("Please Enter a Positive Number");
        //    }
        //    else if(num%3 == 0 || num%7 == 0)
        //    {
        //        Console.WriteLine($"{num} is multiple of 3 or 7");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num} is not the multiple of 3 or 7");
        //    }
        //}


        //*******************************************************************************************************

        //Question No 9:
        // Write a C# program to create a string from a given string. This is done by taking the last 3 characters and adding them at both the front and back. The string length must be 3 or more.

        //public void AddLastThreeCharacter()
        //{
        //    Console.WriteLine("Enter the String");
        //    var str = Console.ReadLine();
        //    var lastThreeCharacters = str.Substring(str.Length - 3);

        //    var newStr = lastThreeCharacters + str + lastThreeCharacters;
        //       Console.WriteLine("The New String is " + newStr);
        //}

        //*******************************************************************************************************

        //Question No 10
        // Write a C# program to find the largest of three given integers.  

        //public void FindLargestInteger()
        //{
        //    Console.WriteLine("Enter the first integer");
        //    var num1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the second integer");
        //    var num2 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the third integer");
        //    var num3 = int.Parse(Console.ReadLine());

        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        Console.WriteLine($"{num1} is the largest number.");
        //    }
        //    else if (num2 >= num1 && num2 >= num3)
        //    {
        //        Console.WriteLine($"{num2} is the largest number.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num3} is the largest number.");
        //    }
        //}

        //************************************************************************

        //Question no 11;

        // Write a C# program to compute the sum of the two given integers. If the sum is in the range 50..80 return 65 otherwise return 80.

        //public void FindSum()
        //{
        //    Console.WriteLine("Enter First number");
        //    var num1 = int.Parse(Console.ReadLine());


        //    Console.WriteLine("Enter second number");
        //    var num2 = int.Parse(Console.ReadLine());


        //    int sum = num1 + num2;

        //    if(sum>=50 && sum<= 80)
        //    {
        //        Console.WriteLine("65");
        //    }
        //    else
        //    {
        //        Console.WriteLine("80");
        //    }
        //}

        //********************************************************************************

        //Question no 12:
        // Write a C# for loop that iterates from 0 to 15. For each iteration, it checks if the current number is odd or even, and displays a message on the screen.

        //public void FindEvenOddNumber()
        //{
        //    Console.WriteLine("Enter the number");
        //    var num = int.Parse(Console.ReadLine());

        //    for(int i=1;i<=num;i++)
        //    {
        //        if(i%2 == 0)
        //        {
        //            Console.WriteLine($"{i} is an even number");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{i} is an odd number");
        //        }
        //    }
        //}


        //********************************************************************************

        //Question No 13:
        //Write a C# program that iterates integers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for multiples of five print "Buzz". For numbers multiples of both three and five print "FizzBuzz".

        //public void FindEvenOddFizzBuzz()
        //{
        //    Console.WriteLine("Enter the number");
        //    var num = int.Parse(Console.ReadLine());

        //    for (int i = 1; i <= num; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            Console.WriteLine($"{i} is an FizzBuzz number");
        //        }

        //        else if(i%5 == 0)
        //        {
        //            Console.WriteLine($"{i} is an Buzz number");
        //        }
        //        else if (i % 3 == 0)
        //        {
        //            Console.WriteLine($"{i} is an Fizz number");
        //        }
        //    }
        //}


        //Question No 14:
        // Write a C# program to sum 3 and 5 multiples under 1000.

        //public void FindSumOfThreeAndFiveMultiple()
        //{
        //    Console.WriteLine("Enter the number");
        //    var num = int.Parse(Console.ReadLine());
        //    int i, Sum = 0;
        //    for (i = 1; i < num; i++)
        //    {

        //        if (i % 3 == 0 || i % 5 == 0)
        //        {
        //            Console.WriteLine("Multiple of 3 or 7 is : "  +i);
        //            Sum = Sum + i;
        //        }
        //    }
        //    Console.WriteLine("The Sum of Multiple of three and five is  " + Sum);


        //}

        //****************************************************************************************
        //Question 15:
        // Calculate the sum of all the numbers in the following array
        //
        //public void FindSumOfArray()
        // {
        //     int[] numbersArray = { 1, 13, 22, 123, 49 };
        //     int sum = numbersArray.Sum();
        //     Console.WriteLine("The Sum of all element of array is " + sum);

        // }



        //Or
        //public void FindSumOfArray()
        //{
        //int sum = 0;
        //int[] numbersArray = {1, 13, 22, 123, 49};
        //    foreach(int num in numbersArray)
        //        {
        //        int sum = sum + num;
        //}
        //Console.log("The Sum is :" + sum);
        //    }

        //*******************************************************************************************
        //Question No 16:
        //Write a program that determines whether a given number is positive or negative.

        //public void FindNumberPositiveOrNegative()
        //{
        //    Console.WriteLine("Enter the number");
        //    var num = int.Parse(Console.ReadLine());

        //    if(num>0)
        //    {
        //        Console.WriteLine($" {num} is a positive number.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($" {num} is a negative number.");
        //    }
        //}
        //*******************************************************************************************
        //Question No 17:
        //Write a program that calculates the ticket price based on age with the following conditions: age below 12 pay a ticket price of 5, age below 18 pay a ticket price of 10, age below 60 pay a ticket price of 20, age over 60 play a ticket price of 15.

        //public void CalculateTicketPrice()
        //{
        //    Console.WriteLine("Enter your Age:");
        //    var age = int.Parse(Console.ReadLine());

        //    if(age>0 && age<=12)
        //    {
        //        Console.WriteLine("Pay a ticket price of 5.");
        //    }
        //    else if (age>12 && age<=18)
        //    {
        //        Console.WriteLine("Pay a ticket price of 10.");
        //    }
        //    else if(age>18 && age<=60)
        //    {
        //        Console.WriteLine("Pay a ticket price of 20.");
        //    }
        //    else if (age > 60)
        //    {
        //        Console.WriteLine("Pay a ticket price of 15.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please Enter a Positive Number.");
        //    }
        //}

        //************************************************************************
        //Question No 18:
        //Write a program that calculates a discount based on the purchase amount.Prices equal or over 100 discount have a discount of 20. Prices equal or over 50 have a discount of 10. Otherwise discount is 0.

        //public void FindDiscountBasedOnPrice()
        //{
        //    Console.WriteLine("Enter a Price");
        //    var price = int.Parse(Console.ReadLine());

        //    if(price>=100)
        //    {
        //        Console.WriteLine("Congralution! Your Discount on purchased items is 20%.");
        //    }
        //    else if (price >= 50 && price<100)
        //    {
        //        Console.WriteLine("Congralution! Your Discount on purchased items is 10%.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your Discount on purchased items is 0%.");
        //    }

        //}

        //*****************************************************************************************************
        //Question No 19:
        //Get the sum of two arrays…actually the sum of all their elements.

        //public void FindSumOfTwoArray()
        //{
        //    int[] arr_1 = [3, 5, 22, 5, 7, 2, 45, 75, 89, 21, 2]; // --> 276
        //    int[] arr_2 = [9, 2, 42, 55, 71, 22, 4, 5, 90, 25, 26]; // --> 351

        //    int sumarr_1 = arr_1.Sum();
        //    int sumarr_2 = arr_2.Sum();
        //    int sum = sumarr_1 + sumarr_2;
        //    Console.WriteLine("The sum of two array is " + sum);
        //}
        //*******************************************************************************************************
        //Question No 20:
        //Write a C# program to evaluate a student's total marks across various examinations and determine their grade. The grading criteria are as follows:

        //public void FindGradeWithTotalMasks()
        //{
        //    Console.WriteLine("Enter total marks");
        //    var total_marks = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Is Final Exam?");
        //    var is_final_exam = bool.Parse(Console.ReadLine());

        //    if (total_marks >= 89 && total_marks <= 100)
        //    {
        //        if (is_final_exam)
        //        {
        //            Console.WriteLine($"Marks with {total_marks} and Final Exam status {is_final_exam} is Grade A+");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Marks with {total_marks} is Grade A+");
        //        }

        //    }
        //    else if (total_marks >= 90 && total_marks <= 100 && is_final_exam)
        //    {
        //        Console.WriteLine($"marks with {total_marks} and {is_final_exam} is Grade A+");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"marks with {total_marks}  is No Grade ");
        //    }

        //}
        //*****************************************************************************************************
        //Question No 21:
        //Using a for loop output the elements in reverse order

        //public void FindReverseOrderOfElements()
        //{

        //    object[] array = { 43, "what", 9, true, "cannot", false, "be", 3, true };

        //    object[] reverse = Enumerable.Reverse(array).ToArray();
        //    Console.WriteLine("Reverse array is  [" + String.Join(',', reverse) + " ]");
        //}
        //****************************************************************************************
        //Question No 22;
        //Given a number n Calculate the factorial of the number

        //public void FindFactorial()
        //{
        //    Console.WriteLine("Enter the Number");
        //    var number = int.Parse(Console.ReadLine());
        //    long factorial = 1;

        //    for(int i=1; i<= number;i++)
        //    {
        //        factorial *=i;
        //    }
        //    Console.WriteLine($"Factorial of {number} is: {factorial}");

        //}
        //*******************************************************************************************
        //Question No 23:
        //Make an array of numbers that are doubles of the first array

        //public void MakeDoublesOfArray()
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6 };

        //    foreach (int num in arr)
        //    {
        //        Console.WriteLine(num*2);
        //    }
        //}

        //*************************************************************************************************
        //Question No 24:
        //public void CheckEmailAndPassword()
        //{
        //    Console.WriteLine("Enter your Email");
        //    string email = Console.ReadLine();

        //    if (email == "saifullahkhanjadoon1998@gmail.com")

        //    {
        //        Console.WriteLine("Enter Your Password");
        //        string password = Console.ReadLine();
        //        if(password == "1234567890")
        //        {
        //            Console.WriteLine("Login Successfully!");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid Password");
        //        }
        //    }
        // else
        //    {
        //        Console.WriteLine("Invalid Email:");
        //    }
        //}
        //**********************************************************************
        //Question No 25:
        //Take an array of numbers and make them strings
        public void ConvertNumberToStrings()
        {
            Console.WriteLine("Enter an Array of Numbers");
            string arr = Console.ReadLine();
            string[] newArray = arr.Split(',');

            Console.WriteLine(arr.ToString());

        }

    }
}
