using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace assignment2q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter the number");
            //string str = Console.ReadLine();

            //int b;
            //bool res = int.TryParse(str,out b);

            //if (res)
            //{
            //    Console.WriteLine("Covernted to integer" + b);
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}


            //use convet method from string to double

            //string myvar;
            //myvar = Console.ReadLine();
            //try
            //{
            //    double mydouble = Convert.ToDouble(myvar);
            //    Console.WriteLine("converted to double" + mydouble.GetType());
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);   
            //}
            //finally
            //{
            //    Console.WriteLine("end of program");
            //}

            //string str2;
            //decimal d;

            //    try {
            //             Console.WriteLine("enter a value");
            //            str2 = Console.ReadLine();
            //                d = Convert.ToDecimal(str2);
            //            Console.WriteLine("Stored value is \t{0} and datatype is{1}");
            //   }
            //catch (Exception ex)
            //{
            //      Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("enter the number");
            //string str = Console.ReadLine();
            //int b;
            //bool res = int.TryParse(str, out b);
            //if (res)
            //{
            //       Console.WriteLine("Covernted to integer" + b*5);
            //}
            //else
            //    {
            //        Console.WriteLine("Error");
            //    }



            //            Convert a string to a DateTime object using the Convert method.Handle any exceptions that may occur during the conversion and print an appropriate error message.Then, subtract 1 month from the obtained DateTime object and display the result.

            //string dateString = Console.ReadLine();

            //try
            //{
            //    DateTime date = Convert.ToDateTime(dateString);
            //    Console.WriteLine("Original Date: " + date);

            //    // Subtract 1 month from the obtained DateTime
            //    date = date.AddMonths(-1);
            //    Console.WriteLine("Date with 1 month subtracted: " + date);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid date format. Please enter a valid date.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}

//            Convert a string to a TimeSpan object using the Parse method.Handle any exceptions that may occur during the conversion and print an appropriate error message.Then, add 2 hours to the obtained TimeSpan object and display the result.

            //string timeString = Console.ReadLine();

            //try
            //{
            //    TimeSpan timeSpan = TimeSpan.Parse(timeString);
            //    Console.WriteLine("Original TimeSpan: " + timeSpan);

            //    // Add 2 hours to the obtained TimeSpan
            //    timeSpan = timeSpan.Add(new TimeSpan(2, 0, 0));
            //    Console.WriteLine("TimeSpan with 2 hours added: " + timeSpan);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid time format. Please enter a valid time span.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The provided time span is too large or too small.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}

            Console.ReadKey();
        }
    }
}
