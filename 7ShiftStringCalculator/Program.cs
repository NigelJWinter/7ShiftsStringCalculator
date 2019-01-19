using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Nigel Winter

namespace _7ShiftStringCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringCalculator.Add("1,2,3"));
            Console.WriteLine(StringCalculator.Add("\n1,2,3"));
            Console.WriteLine(StringCalculator.Add("//@\n1@2@3"));
            Console.WriteLine(StringCalculator.Add("//###,!!!\n1###2!!!3"));
            Console.ReadLine();
        }

    }

    
}
