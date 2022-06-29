namespace tabuleiro
{
    abstract class Peca
    //Classe abstrata não pode ser instanciada, apenas herdada
    {
        public Posicao posicao { get; set; }
        //Acessada e alterada pelas outras classes
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }
        //Acessada por outras classes e alterada por ela mesma e pelas subclasses

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
            //Diz qual é o tabuleiro e qual é a cor
            //Posição iniciando nula e e movimentos zero
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tab.linhas; i++)
            {
                for (int j=0; j<tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
        //Marca na matriz verdadeiro para um movimento possível e falso para onde não for
        //Abstrato pq não pode ser implementado na Peça, pq a regra de movimentos depende de cada peça específica

    }
}
