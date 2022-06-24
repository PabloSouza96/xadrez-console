namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        //não pode ser acessada por "alguém" de fora

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
            //criando tabuleiro, instanciando a matriz de peças e definindo número de linhas e colunas
        }

        public Peca peca(int linha, int coluna)
        //método público que pode acessar uma peça
        {
            return pecas[linha, coluna];
        }
    }
}
