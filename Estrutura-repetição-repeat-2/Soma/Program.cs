using System;

class soma
{

    static void Main()
    {

        // Declarando array e variáveis

        int[] soma = new int[0];
        int count = 0;
        int resultado = 0;

        // Loop para entrada de números para soma e impressão de resultado

        while (true)
        {
            Console.WriteLine("Digite os números que deseja e digite 'somar': ");
            string numeros = Console.ReadLine();

            if (numeros.ToLower() == "somar")
            {
                Console.WriteLine("A soma dos números é: " + resultado);
                break;
            }
            if (int.TryParse(numeros, out int num))
            {      
                Array.Resize(ref soma, count + 1);
                soma[count] = num;
                count++;

                resultado += num;    
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }   
        }
    }
}