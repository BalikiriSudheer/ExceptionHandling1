using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class FileNotFound
    {
        public void Efile()
        {
            var file = "Sudheer.txt";
            try
            {
                var txt = File.ReadAllText(file);
                Console.WriteLine(txt);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
