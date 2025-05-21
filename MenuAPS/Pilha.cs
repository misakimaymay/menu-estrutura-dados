using System;
using System.Collections.Generic;

namespace EstruturasDeDadosConsole
{
    public class Pilha
    {
        private Stack<int> elementos = new Stack<int>();

        public void Inserir(int valor)
        {
            elementos.Push(valor);
            Console.WriteLine("Elemento inserido na pilha.");
        }

        public void Remover()
        {
            if (elementos.Count > 0)
            {
                int removido = elementos.Pop();
                Console.WriteLine($"Elemento {removido} removido da pilha.");
            }
            else
            {
                Console.WriteLine("Pilha vazia.");
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Elementos na pilha:");
            foreach (var item in elementos)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        public void Buscar(int valor)
        {
            if (elementos.Contains(valor))
                Console.WriteLine("Valor encontrado na pilha.");
            else
                Console.WriteLine("Valor não encontrado.");
        }
    }
}