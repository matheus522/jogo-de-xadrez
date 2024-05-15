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

                while (!partida.terminada)
                {
                    
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosition();

                    bool[,] posicoesPosiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab, posicoesPosiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosition();

                    partida.ExcMovimento(origem, destino);
                }

               

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
