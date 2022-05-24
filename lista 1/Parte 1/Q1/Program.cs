using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = PerguntarPath();
            ProcuraComentario(path);

            Console.ReadLine();
        }
        static string PerguntarPath()
        {
            Console.Write("Insira o diretório: ");
            string dir = Console.ReadLine();

            return dir;
        }
        static void ProcuraComentario(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            Console.Clear();
            Console.WriteLine("Comentários: \n");

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("/*"))
                {
                    while(!lines[i].EndsWith(@"*/"))
                    {
                        Console.WriteLine(lines[i]);

                        i++;
                    }
                    Console.WriteLine(lines[i] + "\n");
                }
            }
        }
    }
}
