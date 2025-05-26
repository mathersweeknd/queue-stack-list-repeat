using System;

class tabuada4
{

    static void Main()
    {

        // Declarando array com números de 1 a 10

        int[] tabuada4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Solicitando entrada de um número para fazer a tabuada
        
        Console.WriteLine("Digite um número inteiro para fazer a tabuada: ");
        string tab = Console.ReadLine();

        // Convertendo a entrada para inteiro

        int.TryParse(tab, out int tot);

        Console.WriteLine("Tabuada impar do número " + tot + " é: ");

        // Loop para calcular a tabuada do número fornecido

        for (int i = 0; i < tabuada4.Length; i++)
        {
            int resultado = tot * tabuada4[i];

            // Conferindo se o número é par ou impar usando % 2

            int resultadoimpar = resultado % 2;

            // Se o resultado for impar, será impresso

            if(resultadoimpar == 1)
            {
            Console.WriteLine(tot + " x " + tabuada4[i] + " = " + resultado);
            }
        }
    }
}