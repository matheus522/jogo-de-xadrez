using System.Text;

namespace JogoDeXadrez.Tabuleiro
{
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set;}


        public Posicao() { }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public void definePosicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Linha}, {Coluna}");

            return sb.ToString();
        }
    }
}
