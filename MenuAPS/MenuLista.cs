using System;

namespace EstruturasDeDadosConsole
{
    public static class MenuLista
    {
        private static Lista lista = new Lista();

        public static void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU LISTA ====");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos os elementos");
                Console.WriteLine("4. Consultar/Buscar elemento");
                Console.WriteLine("5. Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o valor a ser inserido: ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                        {
                            lista.Inserir(valor);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;
                    case "2":
                        Console.Write("Digite o valor a ser removido: ");
                        if (int.TryParse(Console.ReadLine(), out int valRemover))
                        {
                            lista.Remover(valRemover);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;
                    case "3":
                        lista.Exibir();
                        break;
                    case "4":
                        Console.Write("Digite o valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int busca))
                        {
                            lista.Buscar(busca);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
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