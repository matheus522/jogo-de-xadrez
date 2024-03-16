using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QuantidadeMovimento { get; protected set; }
        public TabuleiroInfo tabuleiro { get; protected set; }


        public Peca() { }

        public Peca(Posicao posicao, Cor cor, TabuleiroInfo tabuleiro)
        {
            this.Posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.QuantidadeMovimento = 0;
        }
    }
}
