using System;
using System.IO;

namespace LStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\MY_DESKTOP\RemediosDoly.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
               /*
                fs = new FileStream(path, FileMode.Open);
                // IMPORTANTE TER A REFERÊNCIA DO FILESTREAM PRA PODER FECHAR ELE NO FINAL
                sr = new StreamReader(fs);
               */
               sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();                
            }
        }
    }
}