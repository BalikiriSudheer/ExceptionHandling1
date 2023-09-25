using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class DivisionByZerocs
    {
        public void DevidedByzero()
        {
            int a = 0;


            try
            {
                int b = 10 / a;
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}