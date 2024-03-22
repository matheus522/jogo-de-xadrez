using JogoDeXadrez.Tabuleiro;
using JogoDeXadrez.Xadrez;

namespace JogoDeXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                TabuleiroInfo tabuleiro = new TabuleiroInfo(8, 8);

                tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(0, 2));
                tabuleiro.ColocarPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(5, 2));

                Tela.ImprimirTabuleiro(tabuleiro);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
