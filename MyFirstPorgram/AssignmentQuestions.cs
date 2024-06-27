using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        //Write a JavaScript program to create a new string from a given string by changing the position of the first and last characters. The string length must be broader than or equal to 1.

        public void ExchangeCharacter()
        {
            Console.WriteLine("Enter the String");
            var str = Console.ReadLine();

            var firstCharacter = str[0];

            var lastCharacter = str[str.Length - 1];


        }
}
