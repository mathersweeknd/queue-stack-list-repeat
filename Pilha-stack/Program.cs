using System;
using System.Collections.Generic;

class Pilha
{

    // Declarando nova pilha privada

    private List<int> pilha = new List<int>();

    // Método para empilhar

    public void Empilhar(int num)
    {
        // Adiciona número no topo da pilha

        pilha.Add(num);
    }

    // Método para desempilhar

    public int? Desempilhar()
    {
        // Verifica se a pilha está vazia
        if (!Vazia())
        {
            // Armazena último número no topo da pilha

            int num = pilha[pilha.Count -1];

            // Remove o último número da pilha

            pilha.RemoveAt(pilha.Count -1);

            // Retorna o número removido

            return num;
        }

        // Retorna valor nulo se a pilha estiver vazia

        return null;
    }

    // Método para verificar se a pilha está vazia 

    public bool Vazia()
    {
        // Retorna verdadeiro se a pilha estiver vazia

        return pilha.Count == 0;
    }

    // Método para exibir os elementos da pilha
    public void ExibirPilha()
    {
    Console.WriteLine("Números na pilha: ");

    // Exibe cada número na pilha

    foreach (int num in pilha)
    {
        Console.Write(num + " ");
    }

    Console.WriteLine();
    }
}

// Programa principal que testa a implementação da Pilha

class ProgramPilha
{
    static void Main()
    {
        // Cria uma nova pilha

        Pilha pilha = new Pilha();

        // Empilha 5 números

        for (int i = 0; i < 5; i++)
        {
            pilha.Empilhar(i);
            Console.WriteLine($"Empilhando: {i}");
        }

        // Exibe números na pilha

        pilha.ExibirPilha();

        // Desempilhando os números

        Console.WriteLine("Desempilhando...");
        while (!pilha.Vazia())
        {
        Console.WriteLine(pilha.Desempilhar()+ " ");
        }

    }
}