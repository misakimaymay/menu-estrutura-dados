using System;

namespace EstruturasDeDadosConsole
{
    public static class MenuMatriz
    {
        private static Matriz matriz = new Matriz(3, 3);

        public static void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU MATRIZ ====");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos os elementos");
                Console.WriteLine("4. Consultar elemento");
                Console.WriteLine("5. Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Linha: ");
                        int.TryParse(Console.ReadLine(), out int linha);
                        Console.Write("Coluna: ");
                        int.TryParse(Console.ReadLine(), out int coluna);
                        Console.Write("Valor: ");
                        int.TryParse(Console.ReadLine(), out int valor);
                        matriz.Inserir(linha, coluna, valor);
                        break;
                    case "2":
                        Console.Write("Linha: ");
                        int.TryParse(Console.ReadLine(), out int lRem);
                        Console.Write("Coluna: ");
                        int.TryParse(Console.ReadLine(), out int cRem);
                        matriz.Remover(lRem, cRem);
                        break;
                    case "3":
                        matriz.Exibir();
                        break;
                    case "4":
                        Console.Write("Linha: ");
                        int.TryParse(Console.ReadLine(), out int lBus);
                        Console.Write("Coluna: ");
                        int.TryParse(Console.ReadLine(), out int cBus);
                        matriz.Consultar(lBus, cBus);
                        break;
                    case "5":
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