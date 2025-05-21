using System;

namespace EstruturasDeDadosConsole
{
    public class Matriz
    {
        private int[,] elementos;

        public Matriz(int linhas, int colunas)
        {
            elementos = new int[linhas, colunas];
        }

        public void Inserir(int linha, int coluna, int valor)
        {
            if (linha >= 0 && linha < elementos.GetLength(0) &&
                coluna >= 0 && coluna < elementos.GetLength(1))
            {
                elementos[linha, coluna] = valor;
                Console.WriteLine("Elemento inserido.");
            }
            else
            {
                Console.WriteLine("Índice fora do alcance.");
            }
        }

        public void Remover(int linha, int coluna)
        {
            if (linha >= 0 && linha < elementos.GetLength(0) &&
                coluna >= 0 && coluna < elementos.GetLength(1))
            {
                elementos[linha, coluna] = 0;
                Console.WriteLine("Elemento removido (zerado).");
            }
            else
            {
                Console.WriteLine("Índice fora do alcance.");
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Elementos da matriz:");
            for (int i = 0; i < elementos.GetLength(0); i++)
            {
                for (int j = 0; j < elementos.GetLength(1); j++)
                {
                    Console.Write(elementos[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void Consultar(int linha, int coluna)
        {
            if (linha >= 0 && linha < elementos.GetLength(0) &&
                coluna >= 0 && coluna < elementos.GetLength(1))
            {
                Console.WriteLine($"Valor na posição ({linha},{coluna}): {elementos[linha, coluna]}");
            }
            else
            {
                Console.WriteLine("Índice fora do alcance.");
            }
        }
    }
}