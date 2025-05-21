using System;

namespace EstruturasDeDadosConsole
{
    public static class MenuFila
    {
        private static Fila fila = new Fila();

        public static void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU FILA ====");
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
                            fila.Inserir(valor);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;
                    case "2":
                        fila.Remover();
                        break;
                    case "3":
                        fila.Exibir();
                        break;
                    case "4":
                        Console.Write("Digite o valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int busca))
                        {
                            fila.Buscar(busca);
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