using System;

namespace EstruturasDeDadosConsole
{
    public class Vetor
    {
        private int[] elementos;
        private int tamanho;

        public Vetor(int capacidade)
        {
            elementos = new int[capacidade];
            tamanho = 0;
        }

        public void Inserir(int valor)
        {
            if (tamanho < elementos.Length)
            {
                elementos[tamanho++] = valor;
                Console.WriteLine("Elemento inserido.");
            }
            else
            {
                Console.WriteLine("Vetor está cheio.");
            }
        }

        public void Remover(int indice)
        {
            if (indice >= 0 && indice < tamanho)
            {
                for (int i = indice; i < tamanho - 1; i++)
                    elementos[i] = elementos[i + 1];
                tamanho--;
                Console.WriteLine("Elemento removido.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Elementos do vetor:");
            for (int i = 0; i < tamanho; i++)
                Console.Write(elementos[i] + " ");
            Console.WriteLine();
        }

        public void Buscar(int valor)
        {
            for (int i = 0; i < tamanho; i++)
            {
                if (elementos[i] == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado na posição {i}.");
                    return;
                }
            }
            Console.WriteLine("Valor não encontrado.");
        }
    }
}