using System;


namespace EscrevendoCelular.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Escreve texto = new Escreve();
            texto.VerificaTexto("SEMPRE ACESSO O DOJOPUZZLES");
            Console.ReadLine();
        }
    }
}
