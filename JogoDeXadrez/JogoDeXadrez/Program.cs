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
               PartidaDeXadrez partida = new PartidaDeXadrez();
               Tela.ImprimirTabuleiro(partida.tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
