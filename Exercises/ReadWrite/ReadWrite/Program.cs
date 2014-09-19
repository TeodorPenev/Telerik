using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Teodor\Desktop\ReadWrite\ReadWrite\text.txt";
            var read = new StreamReader(path);
            string temp = string.Empty;
            using (read)
            {
                temp = read.ReadToEnd();
            }

            Console.WriteLine(temp);

            var write = new StreamWriter(path, true);
            string text = "this is new line";
            using (write)
            {
                write.Write(text);
            }

        }
    }
}
