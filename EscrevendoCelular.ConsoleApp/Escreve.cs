using System;

namespace EscrevendoCelular.ConsoleApp
{
    public class Escreve
    {
        Tradutor traduz = new Tradutor();
        string montagem = "";

 
        public string VerificaTexto(string texto)
        {
            texto.ToUpper();
            char[] letras = texto.ToCharArray();

            if (letras.Length > 255)
                throw new ArgumentOutOfRangeException("texto", "Sistema não suporta mais do que 255 caracteres");

            for (int i = 0; i < letras.Length; i++)
            {
                if (i > 0)
                    montagem += Verifica_(letras[i], letras[i - 1]);

                montagem += traduz.Traduz(letras[i]);
            }
            return montagem;
        }

        public string Verifica_(char atual, char anterior)
        {
            if ((atual == 'A' || atual == 'B' || atual == 'C') && (anterior == 'A' || anterior == 'B' || anterior == 'C'))
                return "_";
            if ((atual == 'D' || atual == 'E' || atual == 'F') && (anterior == 'D' || anterior == 'E' || anterior == 'F'))
                return "_";
            if ((atual == 'G' || atual == 'H' || atual == 'I') && (anterior == 'G' || anterior == 'H' || anterior == 'I'))
                return "_";
            if ((atual == 'J' || atual == 'K' || atual == 'L') && (anterior == 'J' || anterior == 'K' || anterior == 'L'))
                return "_";
            if ((atual == 'M' || atual == 'N' || atual == 'O') && (anterior == 'M' || anterior == 'N' || anterior == 'O'))
                return "_";
            if ((atual == 'P' || atual == 'Q' || atual == 'R' || atual == 'S') && (anterior == 'P' || anterior == 'Q' || anterior == 'R' || anterior == 'S'))
                return "_";
            if ((atual == 'T' || atual == 'U' || atual == 'V') && (anterior == 'T' || anterior == 'U' || anterior == 'V'))
                return "_";
            if ((atual == 'W' || atual == 'X' || atual == 'Y' || atual == 'Z') && (anterior == 'W' || anterior == 'X' || anterior == 'Y' || anterior == 'Z'))
                return "_";
            return null;
        }
    }

}

