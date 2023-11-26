using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable tabelaHash = new Hashtable();

        while (true)
        {
            Console.WriteLine("Digite um par de Chave e Valor (CPF NOME), ou 'sair' para encerrar:");
            string entrada = Console.ReadLine();

            if (entrada == null)
                break;

            string[] dados = entrada.Split(' ');
            if (dados.Length == 2)
            {
                string cpf = dados[0];
                string nome = dados[1];

                if (!tabelaHash.ContainsKey(cpf))
                {
                    tabelaHash[cpf] = nome;
                    Console.WriteLine("Dados inseridos com sucesso!");
                }
                else
                {
                    Console.WriteLine("CPF já existe na tabela. Insira um CPF diferente.");
                }
            }
            else if (entrada.ToLower() == "sair")
            {
                break;
            }
            else
            {
                Console.WriteLine("Formato de entrada inválido. Use 'CPF NOME'.");
            }
        }

        Console.WriteLine("\nDados na tabela hash:");
        foreach (DictionaryEntry entry in tabelaHash)
        {
            Console.WriteLine($"CPF: {entry.Key}, NOME: {entry.Value}");
        }
    }
}
