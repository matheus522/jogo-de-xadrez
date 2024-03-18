using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.Tabuleiro
{
    class TabuleiroInfo
    {
        public int Linhas {  get; set; }
        public int Colunas { get; set; }
        public Peca[,] pecas;

        public TabuleiroInfo() { }

        public TabuleiroInfo(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.pecas = new Peca[Linhas, Colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao= pos;
        }
    }
}
