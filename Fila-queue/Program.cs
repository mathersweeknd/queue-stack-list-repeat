using System;
using System.Collections.Generic;

class Fila
{
    // Declarando nova fila privada

    private List<int> filas = new List<int>();

    // Criando método para enfileirar

    public void Enfileirar(int fila)
    {
        // Adiciona número no final da fila

        filas.Add(fila);
    }
    // Metódo para desenfileirar

    public int? Desenfileirar()
    {
        // Verifica se a fila está vazia

        if (!Vazia())
        {
            // Armazena o primeiro número da fila

            int fila = filas[0];

            // Remove o primeiro número da fila

            filas.RemoveAt(0);

            // Retorna o número desenfileirado

            return fila;
        }
        return null;
    }

    // Método para verificar se a fila está vazia
    public bool Vazia()
    {
        // Retorna verdadeiro se a fila estiver vazia

        return filas.Count == 0;
    }
    // Método para exibir a fila

    public void ExibirFila()
    {
        Console.WriteLine("Fila atual: ");

        // Exibe cada número na fila

        foreach (int fila in filas)
        {
            Console.Write(fila + " ");
        }

    Console.WriteLine();
    } 
}

// Programa princípal para testar a fila

class ProgramFila
{
    static void Main()
    {
        // Cria uma nova fila

        Fila fila = new Fila();

        // Enfileira 5 números na fila

        for (int i = 0; i < 5; i++)
        {
            fila.Enfileirar(i);
            Console.WriteLine($"Enfileirando: {i}");
        }

        // Exibe números na fila

        fila.ExibirFila();

        // Desempilhando números

        Console.WriteLine("Desenfileirado:");
        while (!fila.Vazia())
        {
            Console.WriteLine(fila.Desenfileirar() + " ");
        }
    }
}