using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q3.Entities;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automato automato = new Automato();
            char[] palavra = PedirCadeiaCaracteres();
            bool resposta = automato.ReconhecidoPeloAutomato(palavra);

            ImprimeResposta(resposta);

            Console.ReadLine();
        }
        static char[] PedirCadeiaCaracteres()
        {
            Console.Write("Insira uma palavra: ");
            string palavra = Console.ReadLine();
            char[] caracteres = new char[palavra.Length];

            for(int i = 0; i < palavra.Length; i++)
                caracteres[i] = palavra[i];

            return caracteres;
        }
        static void ImprimeResposta(bool resp)
        {
            if (resp)
                Console.WriteLine("O autômato reconhece esta palavra!");
            else
                Console.WriteLine("O autômato não reconhece esta palavra!");
        }
    }
}
