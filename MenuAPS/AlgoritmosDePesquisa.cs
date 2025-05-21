namespace EstruturasDeDadosConsole
{
    public static class AlgoritmosDePesquisa
    {
        public static int PesquisaSequencial(int[] vetor, int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
                if (vetor[i] == valor)
                    return i;
            return -1;
        }

        public static int PesquisaBinaria(int[] vetor, int valor)
        {
            int inicio = 0, fim = vetor.Length - 1;
            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                if (vetor[meio] == valor)
                    return meio;
                else if (vetor[meio] < valor)
                    inicio = meio + 1;
                else
                    fim = meio - 1;
            }
            return -1;
        }
    }
}