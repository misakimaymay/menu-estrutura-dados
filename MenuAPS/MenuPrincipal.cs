using System;

namespace EstruturasDeDadosConsole
{
    public static class MenuPrincipal
    {
        public static void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU PRINCIPAL ====");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("3. Trabalhar com Lista");
                Console.WriteLine("4. Trabalhar com Fila");
                Console.WriteLine("5. Trabalhar com Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("7. Encerrar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuVetor.Exibir();
                        break;
                    case "2":
                        MenuMatriz.Exibir();
                        break;
                    case "3":
                        MenuLista.Exibir();
                        break;
                    case "4":
                        MenuFila.Exibir();
                        break;
                    case "5":
                        MenuPilha.Exibir();
                        break;
                    case "6":
                        MenuPesquisa.Exibir();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}