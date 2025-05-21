using System;
using System.Collections.Generic;

namespace EstruturasDeDadosConsole
{
    public class Lista
    {
        private List<int> elementos = new List<int>();

        public void Inserir(int valor)
        {
            elementos.Add(valor);
            Console.WriteLine("Elemento inserido.");
        }

        public void Remover(int valor)
        {
            if (elementos.Remove(valor))
                Console.WriteLine("Elemento removido.");
            else
                Console.WriteLine("Valor não encontrado.");
        }

        public void Exibir()
        {
            Console.WriteLine("Elementos da lista:");
            foreach (var item in elementos)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        public void Buscar(int valor)
        {
            int pos = elementos.IndexOf(valor);
            if (pos >= 0)
                Console.WriteLine($"Valor {valor} encontrado na posição {pos}.");
            else
                Console.WriteLine("Valor não encontrado.");
        }
    }
}