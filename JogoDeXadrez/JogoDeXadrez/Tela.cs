

using JogoDeXadrez.Tabuleiro;
using JogoDeXadrez.Xadrez;
using System.Reflection.Metadata.Ecma335;

namespace JogoDeXadrez
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroInfo tab)
        {
             for (int i = 0; i < tab.Linhas;  i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j < tab.Colunas; j++)
                {
                    ImprimePeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }


        public static void ImprimirTabuleiro(TabuleiroInfo tab, bool[,] posicoesPosiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoesPosiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimePeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }


        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1].ToString());
            return new PosicaoXadrez(coluna, linha); 
        }

        public static void ImprimePeca(Peca peca)
        {

            if (peca == null )
            {
                Console.Write("-");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write($"{peca}");
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{peca}");
                    Console.ForegroundColor = aux;
                }
            }
            Console.Write(" ");
        }

    }
}
