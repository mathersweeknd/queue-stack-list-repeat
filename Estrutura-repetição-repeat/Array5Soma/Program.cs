using System;

public class Array5{

public static void Main(){

// Declarando um array de inteiros com 20 elementos e inicializando com valores aleatórios entre 1 e 99

int[] Array5 = new int[20];
Random random = new Random();

// Declarando váriavel soma começando do 0

int soma = 0;

// Loop para contar todos os números

for (int i = 0; i < Array5.Length; i++){

Array5[i] = random.Next(1, 99);

// A cada iteração do array é executado soma = soma + Array5

soma += Array5[i];

}

// Impressão do resultado no console

Console.WriteLine("Array: " +string.Join(", ", Array5));
Console.WriteLine("A soma dos números do array é: " +soma);

}
}