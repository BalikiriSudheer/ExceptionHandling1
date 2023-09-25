using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DivisionByZerocs ds=new DivisionByZerocs();
            ds.DevidedByzero();
            //FileNotFound f = new FileNotFound();
            //f.Efile();
            IndexOutOfRange i=new IndexOutOfRange();
            i.IndexOut();
            ArrayTypeMissMatch at=new ArrayTypeMissMatch();
            at.ArrayType();
          Console.ReadLine();
        }
    }
}
