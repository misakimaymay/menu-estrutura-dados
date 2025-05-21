using System;

namespace EstruturasDeDadosConsole
{
    public static class MenuPesquisa
    {
        private static int[] exemplo = { 1, 3, 5, 7, 9, 11, 13 };

        public static void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU PESQUISA ====");
                Console.WriteLine("1. Pesquisa Sequencial");
                Console.WriteLine("2. Pesquisa Binária");
                Console.WriteLine("3. Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o valor a buscar: ");
                        int.TryParse(Console.ReadLine(), out int valorSeq);
                        int posSeq = AlgoritmosDePesquisa.PesquisaSequencial(exemplo, valorSeq);
                        if (posSeq >= 0)
                            Console.WriteLine($"Valor encontrado na posição {posSeq}.");
                        else
                            Console.WriteLine("Valor não encontrado.");
                        break;
                    case "2":
                        Console.Write("Digite o valor a buscar: ");
                        int.TryParse(Console.ReadLine(), out int valorBin);
                        int posBin = AlgoritmosDePesquisa.PesquisaBinaria(exemplo, valorBin);
                        if (posBin >= 0)
                            Console.WriteLine($"Valor encontrado na posição {posBin}.");
                        else
                            Console.WriteLine("Valor não encontrado.");
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}