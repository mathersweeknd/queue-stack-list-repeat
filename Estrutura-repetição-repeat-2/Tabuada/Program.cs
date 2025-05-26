using System;

class tabuada
{

    static void Main()
    {

        // Declarando array com números de 1 a 10

        int[] tabuada = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Solicitando entrada de um número para fazer a tabuada
        
        Console.WriteLine("Digite um número inteiro para fazer a tabuada: ");
        string tab = Console.ReadLine();

        // Convertendo a entrada para inteiro

        int.TryParse(tab, out int tot);

        Console.WriteLine("Tabuada do número " + tot + " é: ");

        // Loop para calcular e imprimir a tabuada do número fornecido

        for (int i = 0; i < tabuada.Length; i++)
        {
        int resultado = tot * tabuada[i];
        Console.WriteLine(tot + " x " + tabuada[i] + " = " + resultado);
        }
    }
}