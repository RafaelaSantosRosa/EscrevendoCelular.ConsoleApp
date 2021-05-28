using System;


namespace EscrevendoCelular.ConsoleApp
{
    public class Tradutor
    {
        string montagem = "";
        public string Traduz(char i)
        {
            string numero = Convert.ToString(i);

            switch (numero)
            {
                case "A": montagem = "2"; break;
                case "B": montagem = "22"; break;
                case "C": montagem = "222"; break;
                case "D": montagem = "3"; break;
                case "E": montagem = "33"; break;
                case "F": montagem = "333"; break;
                case "G": montagem = "4"; break;
                case "H": montagem = "44"; break;
                case "I": montagem = "444"; break;
                case "J": montagem = "5"; break;
                case "K": montagem = "55"; break;
                case "L": montagem = "555"; break;
                case "M": montagem = "6"; break;
                case "N": montagem = "66"; break;
                case "O": montagem = "666"; break;
                case "P": montagem = "7"; break;
                case "Q": montagem = "77"; break;
                case "R": montagem = "777"; break;
                case "S": montagem = "7777"; break;
                case "T": montagem = "8"; break;
                case "U": montagem = "88"; break;
                case "V": montagem = "888"; break;
                case "W": montagem = "9"; break;
                case "X": montagem = "99"; break;
                case "Y": montagem = "999"; break;
                case "Z": montagem = "9999"; break;
                case " ": montagem = "0"; break;
               
            }
            return montagem;
        }
    }
}
