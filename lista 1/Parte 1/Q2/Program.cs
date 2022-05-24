using System;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = PedirInformacoes();
            Console.WriteLine("O número que você informou é do tipo " + VerificaPrecisao(n));

            Console.ReadLine();
        }
        static string PedirInformacoes()
        {
            Console.Write("Informe um número: ");
            string num = Console.ReadLine();

            return num;
        }
        static string VerificaPrecisao(string num)
        {
            string resp = "";
            foreach(char c in num)
                if (c == ',')
                    resp = "flutuante";

            if (resp != "flutuante")
                resp = "inteiro";

            return resp;
        }
    }
}
