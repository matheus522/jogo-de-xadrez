using JogoDeXadrez.Tabuleiro;


namespace JogoDeXadrez.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroInfo tab) : base(cor, tab)
        {

        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0,0);

            //N
            pos.definePosicao(Posicao.Linha - 1, Posicao.Coluna);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //NE
            pos.definePosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //E
            pos.definePosicao(Posicao.Linha, Posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //SE
            pos.definePosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //S
            pos.definePosicao(Posicao.Linha + 1, Posicao.Coluna);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //SO
            pos.definePosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //O
            pos.definePosicao(Posicao.Linha, Posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //NO
            pos.definePosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;


        }

        public override string ToString()
        {
            return "R";
        }
    }
}
