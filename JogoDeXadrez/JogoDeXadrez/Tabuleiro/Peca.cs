

namespace JogoDeXadrez.Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QuantidadeMovimento { get; protected set; }
        public TabuleiroInfo tabuleiro { get; protected set; }

        public Peca(Cor cor, TabuleiroInfo tabuleiro)
        {
            this.Posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.QuantidadeMovimento = 0;
        }
    }
}
