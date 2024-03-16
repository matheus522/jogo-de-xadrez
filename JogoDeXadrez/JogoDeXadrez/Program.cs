using JogoDeXadrez.Tabuleiro;

namespace JogoDeXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TabuleiroInfo tabuleiro = new TabuleiroInfo(8,8);
            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}
