using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KorneevaEA.Sprint0.Task7.V0.Lib
{
    public class DataServise
    {
        
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resuliArray = new int[5];
            for (var i = 0; i < resuliArray.Length; i++)
            {
                resuliArray[i] = numOne[i] + numTwo[i];
            }
            return resuliArray;
        }
    }
}
