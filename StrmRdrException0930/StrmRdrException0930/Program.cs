using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StrmRdrException0930
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"StrmRdrException0930\Smile";

            try
            {
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("File {0} successfully opened.", fileName);
                Console.WriteLine("File contents:");

                using(reader)
                {
                    Console.WriteLine(reader.ReadToEnd());

                }

            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}", fileName);
            }
            catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the open file", fileName);
            }
            catch(IOException)
            {
                Console.Error.WriteLine("Cannot open the file {0}", fileName);
            }
        }
    }
}
