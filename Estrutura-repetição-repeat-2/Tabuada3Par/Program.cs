using System;

class tabuada3
{

    static void Main()
    {

        // Declarando array com números de 1 a 10

        int[] tabuada3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Solicitando entrada de um número para fazer a tabuada
        
        Console.WriteLine("Digite um número inteiro para fazer a tabuada: ");
        string tab = Console.ReadLine();

        // Convertendo a entrada para inteiro

        int.TryParse(tab, out int tot);

        Console.WriteLine("Tabuada par do número " + tot + " é: ");

        // Loop para calcular a tabuada do número fornecido

        for (int i = 0; i < tabuada3.Length; i++)
        {
            int resultado = tot * tabuada3[i];

            // Conferindo se o número é par ou impar usando % 2

            int resultadopar = resultado % 2;

            // Se o resultado for par, será impresso

            if(resultadopar == 0)
            {
            Console.WriteLine(tot + " x " + tabuada3[i] + " = " + resultado);
            }
        }
    }
}