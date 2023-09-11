using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KorneevaEA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KorneevaEA.Sprint0.Task5.New_English_file__pre_intermediate0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplikation(10, 10));
            Console.WriteLine("A / B = " + DataService.Division(9, 3));
            Console.ReadLine();
        }
    }
}
