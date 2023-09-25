using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ArrayTypeMissMatch
    {
        public void ArrayType()
        {
            string[] arrayOne =
            {
               "Sudheer","Kumar"
            };
            int[] arrayTwo =
            {
                1,2
            };
            try
            {
                Array.Copy(arrayOne, arrayTwo, 2);
            }

            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
