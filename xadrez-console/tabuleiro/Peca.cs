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

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
    }
}
