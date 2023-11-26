using System;
using System.Collections;
using System.IO;
using System.Threading;

Queue fila = new Queue();
bool sair = false;

while (!sair)
{
    Console.Clear();

    Console.WriteLine("Por favor, selecione uma opção:");
    Console.WriteLine("1 - Adicionar elemento à fila");
    Console.WriteLine("2 - Remover elemento da fila");
    Console.WriteLine("3 - Verificar o primeiro elemento da fila");
    Console.WriteLine("4 - Imprimir todo o conteúdo da fila");
    Console.WriteLine("5 - Verificar se a fila contém um elemento específico");
    Console.WriteLine("6 - Limpar toda a fila");
    Console.WriteLine("7 - Sair");

    String opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
                Console.WriteLine("Digite o elemento a ser adicionado à fila: ");
                fila.Enqueue(Console.ReadLine());
                break;
            case "2":
                if (fila.Count > 0)
                {
                    Console.WriteLine($"O elemento {fila.Dequeue()} foi removido.");
                }
                else
                {
                    Console.WriteLine("A fila está vazia. Nenhum elemento para remover.");
                }
                break;
            case "3":
                if (fila.Count > 0)
                {
                    Console.WriteLine($"O primeiro elemento da fila é: {fila.Peek()}");
                }
                else
                {
                    Console.WriteLine("A fila está vazia. Nenhum elemento para visualizar.");
                }
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Conteúdo da Fila:");
                foreach (object obj in fila)
                {
                    Console.WriteLine("{0}", obj);
                }
                break;
            case "5":
                Console.WriteLine("Digite o elemento a ser procurado na fila: ");
                string elementoProcurado = Console.ReadLine();
                if (fila.Contains(elementoProcurado))
                {
                    Console.WriteLine($"A fila contém o elemento '{elementoProcurado}'.");
                }
                else
                {
                    Console.WriteLine($"A fila não contém o elemento '{elementoProcurado}'.");
                }
                break;
            case "6":
                fila.Clear();
                Console.WriteLine("Todos os elementos foram removidos da fila.");
                break;
            case "7":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                break;
        }

        if (!sair)
        {
            Thread.Sleep(2500);
        }
    }
    catch (IOException ioex)
    {
        Console.WriteLine("Erro ao manipular a fila. Verifique e tente novamente.");
        Console.WriteLine($"Mensagem de erro: {ioex.Message}");
        Thread.Sleep(2500);
    }
}
