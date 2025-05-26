using System;

public class Array4{

public static void Main(){

// Declarando array de números inteiros

int[] Array4 = {12, 23, 36, 41, 55, 64, 75, 28, 19, 39, 128, 64};

// Criando váriavel para encontrar o maior número

int maior = Array4[0];

for (int i = 0; i < Array4.Length; ++i){

// O loop continuará rodando enquanto houver números maiores

if (Array4[i] > maior){

// A cada iteração o valor de "maior" é substituído por "i"

maior = Array4[i];

}
}

// Criando váriavel para encontrar o menor número

int menor = Array4[0];

// Loop para contar todos os números

for (int i = 0; i < Array4.Length; i++){

// O loop continuará rodando enquanto houver números menores

if (Array4[i] < menor){

// A cada iteração o valor de "menor" é substituído por "i"

menor = Array4[i];

}
}

// Imprimindo resultados no console

Console.WriteLine("Os números do array são: " + String.Join(", ", Array4));
Console.WriteLine("O maior número é: " + maior);
Console.WriteLine("O menor número é: " + menor);

}
}