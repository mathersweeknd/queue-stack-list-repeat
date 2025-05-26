using System;

public class Array6{

public static void Main(){

// Declarando array de inteiros com 19 números

int[] Array6 = {28, 19, 37, 42, 59, 79, 82, 32, 27, 49, 69, 81, 33, 29, 44, 73, 96, 98, 14};
int soma = 0;
int media = 0;
int total = 0;

// Loop para contar todos os números

for (int i = 0; i < Array6.Length; i++){

// Váriaveis retornam quantos números tem no array, a soma deles e a média

soma = Array6.Length *1;
total += Array6[i];
media = total / soma;

}

// Imprimindo a soma, a média e a quantidade de números no array

Console.WriteLine("Quantidade de números no array: " + soma);
Console.WriteLine("Soma dos números do array: " + total);
Console.WriteLine("Media de números do array: " + media);

}
}