using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting

            /*  int myInt = 9;
              double myDouble = myInt;       // Automatic casting: int to double

              Console.WriteLine(myInt);      // Outputs 9
              Console.WriteLine(myDouble);  // Outputs 9

            */

            // Explicit Casting

            /* double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);    // Outputs 9
            */

            // Implicit Casting(automatically) -converting a smaller type to a larger type size
            // char -> int -> long -> float -> double

            // Explicit Casting(manually) - converting a larger type to a smaller size type
            // double -> float -> long -> int -> char

            // Type Conversion Methods

            // int num = 10;
            // double myDouble = 78.65;
            // bool flag = false;

            // Console.WriteLine(Convert.ToInt32(myDouble));
            // Console.WriteLine(Convert.ToString(num));
            // Console.WriteLine(Convert.ToString(flag));

            /* ************************************************************************* */

            UC1.EmpolyeeWage();

            //EmpWageBuilderObject dmart = new EmpWageBuilderObject("d mart", 20, 2, 10);
            //EmpWageBuilderObject realinace = new EmpWageBuilderObject("realinace", 10, 4, 20);
            //dmart.EmpolyeeAttendences();
            //Console.WriteLine(dmart.toString());
            //realinace.EmpolyeeAttendences();
            //Console.WriteLine(realinace.toString());

            Console.ReadLine();
        }
    }
}
