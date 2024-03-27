using JogoDeXadrez.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.Xadrez
{
    internal class PartidaDeXadrez
    {
        public TabuleiroInfo tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool terminada {  get; private set; }

        public PartidaDeXadrez()
        {
            tab = new TabuleiroInfo(8,8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExcMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeaca(origem);
            p.incrementarMovimento();
            Peca PecaCapturada = tab.retirarPeaca(destino);
            tab.ColocarPeca(p, destino);
        }


        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('c', 1).toPosition());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('b', 3).toPosition());
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('a', 2).toPosition());
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('d', 8).toPosition());
        }

    }
}
