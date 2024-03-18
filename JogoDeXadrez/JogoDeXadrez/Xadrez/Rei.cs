using JogoDeXadrez.Tabuleiro;


namespace JogoDeXadrez.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroInfo tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
