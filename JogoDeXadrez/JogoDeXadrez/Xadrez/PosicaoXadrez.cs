using JogoDeXadrez.Tabuleiro;

namespace JogoDeXadrez.Xadrez
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }


        public PosicaoXadrez(char coluna, int linha)
        {
            this.Coluna = coluna;
            this.Linha = linha;
        }


        public Posicao toPosition()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return $"{Coluna.ToString() + Linha.ToString()}";
        }
    }
}
