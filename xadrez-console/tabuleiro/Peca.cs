namespace tabuleiro
{
    class Peca
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
    }
}
