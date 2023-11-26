using System;
using System.Collections.Generic;

public class GerenciadorDePilha
{
    private Stack<string> minhaPilha;

    public GerenciadorDePilha()
    {
        minhaPilha = new Stack<string>();
    }
    // adiciona um valor na pilha
    public void Adicionar(string valor)
    {
        minhaPilha.Push(valor);
    }

    // remove e retorna o valor do topo da pilha
    public string Remover()
    {
        if (minhaPilha.Count > 0)
            return minhaPilha.Pop();
        else
            throw new InvalidOperationException("A pilha está vazia. Não é possível realizar a operação de remoção.");
    }

    // visualiza o valor no topo sem remove-lo
  
    public string VisualizarTopo()
    {
        if (minhaPilha.Count > 0)
            return minhaPilha.Peek();
        else
            throw new InvalidOperationException("A pilha está vazia. Não é possível visualizar o topo.");
    }

    // verifca se a pilha esta vazia
    public bool EstaVazia()
    {
        return minhaPilha.Count == 0;
    }

    // mostra o conteudo da pilha.
    public void ImprimirPilha()
    {
        Console.WriteLine("Conteúdo da Pilha:");
        foreach (var item in minhaPilha)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
