using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
            //Converter para uma posição interna de matriz
        }

        public override string ToString()
        {
            return "" + coluna + linha;
            //Transforma o obj em string
            //Macete para forçar a conversão coluna + linha
            //Vai imprimir grudado a letra e o número
        }
    }
}
