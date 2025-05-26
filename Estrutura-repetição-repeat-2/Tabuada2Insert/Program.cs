using System;

class tabuada2
{

    static void Main()
    {

        // Declarando array com números de 1 a 10

        int[] tabuada2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Solicitando entrada de um número para fazer a tabuada
        
        Console.WriteLine("Digite um número inteiro para fazer a tabuada: ");
        string tab = Console.ReadLine();

        // Convertendo a entrada para inteiro

        int.TryParse(tab, out int tot);

        // Entrada para decidir entre quais números irão fazer a tabuada

        Console.WriteLine("Deseja ver a tabuada de todos os números (1) ou de indices específicos (2)?");

        string opcao = Console.ReadLine();
        int.TryParse(opcao, out int num);
        
        // Caso a opção 1 seja selecionada, será imprimido a tabuada completa

        if (num == 1)
        {
            Console.WriteLine("Tabuada do número " + tot + " é: ");
            for (int i = 0; i < tabuada2.Length; i++)
            {
            int resultado = tot * tabuada2[i];
             
            Console.WriteLine(tot + " x " + tabuada2[i] + " = " + resultado);
            }
        }

        // Caso a opção 2 seja selecionada, sera solicitado a entrada para quais indices serão impressos

        else if (num == 2)
        {
        
            Console.WriteLine("Digite entre quais números deseja fazer tabuada (0 - 9).");

            Console.WriteLine("Primeiro número: ");
            string opcao2 = Console.ReadLine();
            int.TryParse(opcao2, out int num2);

            Console.WriteLine("Segundo número: ");
            string opcao3 = Console.ReadLine();
            int.TryParse(opcao3, out int num3);

            // Vendo se os números digitados estão corretos com o array

            if 
            (
            num2 >= 0 && num2 < tabuada2.Length &&
            num3 >= 0 && num3 < tabuada2.Length &&
            num2 <= num3
            )
            {

                // Imprimindo resultado

                Console.WriteLine("Tabuada do número " + tot + " para os índices de " + num2 + " a " + num3 + ":");
            
                for (int i = num2; i <= num3; i++)
                {
                int resultado = tot * tabuada2[i];

                Console.WriteLine(tot + " x " + tabuada2[i] + " = " + resultado);
                }
            }

            // Caso a entrada seja invalida, será impresso o aviso de erro

            else
            {
                Console.WriteLine("Indices inválidos!");
            }
        }
    }
}