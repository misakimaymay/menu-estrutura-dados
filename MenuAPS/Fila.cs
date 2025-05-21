using System;
using System.Collections.Generic;

namespace EstruturasDeDadosConsole
{
    public class Fila
    {
        private Queue<int> elementos = new Queue<int>();

        public void Inserir(int valor)
        {
            elementos.Enqueue(valor);
            Console.WriteLine("Elemento inserido na fila.");
        }

        public void Remover()
        {
            if (elementos.Count > 0)
            {
                int removido = elementos.Dequeue();
                Console.WriteLine($"Elemento {removido} removido da fila.");
            }
            else
            {
                Console.WriteLine("Fila vazia.");
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Elementos na fila:");
            foreach (var item in elementos)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        public void Buscar(int valor)
        {
            if (elementos.Contains(valor))
                Console.WriteLine("Valor encontrado na fila.");
            else
                Console.WriteLine("Valor não encontrado.");
        }
    }
}