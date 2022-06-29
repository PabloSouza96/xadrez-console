namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        //Não pode ser acessada por "alguém" de fora

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
            //Criando tabuleiro, instanciando a matriz de peças e definindo número de linhas e colunas
        }

        public Peca peca(int linha, int coluna)
        //Método público que pode acessar uma peça
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
            //Se der erro de validação de posição, lança a exceção "Posição inválida!"
            //Se a peça na posição não for nula, significa que tem uma peça na posição
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
            //Acessa a matriz na posição linha e coluna
        }

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
                //Se não tiver peça pra ser retirada, retorna nulo
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
            //Retira a peça e marca a posição no tabuleiro como nula
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
            //Método para testar se uma posição é valida ou não
            //Não foi preciso colocar o else, pq o return corta o método
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
            //Se a posição passada não for válida, vai lançar uma exceção
            //Lança a exceção e corta a execução
        }
    }
}
