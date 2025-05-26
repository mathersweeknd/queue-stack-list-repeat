using System;

class idade
{
    static void Main()
    {

        // Declarando array e variáveis

        int[] idades = new int[0];
        int count = 0;
        int soma = 0;
        int media = 0;
        int resultado = 0;

        // Loop para entrada de idades e somas

        while (true)
        {
            Console.WriteLine("Digite a idade da pessoa ou digite 'rodar' para iniciar o programa: ");
            string idade = Console.ReadLine();
            
            if (idade.ToLower() == "rodar")
            {
                Console.WriteLine("São " + resultado + " pessoas maiores de idade.");
                Console.WriteLine("A média das idades acima de 18 é: "+ media);
                break;
            }
            if (int.TryParse(idade, out int id))
            {
                Array.Resize(ref idades, count +1);
                idades[count] = id;
                count++;

            }
            if (id >= 18)
            {
                resultado++;
                soma += id;
                media = soma / resultado;
            }
        }
    }
}