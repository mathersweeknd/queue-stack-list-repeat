using System;

public class Array8{

public static void Main(){

// Declarando um array de inteiros com 5 elementos

int[] Array8 = new int[5];

// Declarando variaveis 

int soma = 0;
int total = 0;
int menor;
int maior;
int media = 0;

// Loop para ler e inserir os 5 números inteiros no array

for(int i = 0; i < Array8.Length;i++){

Console.Write("Digite 5 números inteiros: ");

// Lendo e convertendo string para int, e usando ? para aceitar resultado null

string? input = Console.ReadLine();

if (int.TryParse(input, out int num)){

Array8[i] = num;

}

else{

// Rejeitando resposta inválida, como letras ou números decimais e pedindo para inserir novamente

Console.WriteLine("Entrada inválida. Digite um número inteiro.");
i--;

}
}

// Declarando valor inicial de menor e maior

menor = Array8[0];
maior = Array8[0];

for(int i = 0; i < Array8.Length; i++){

// Se houver um número menor que o atual no array ele será substituído

if(Array8[i] < menor){
menor = Array8[i];
}

// Se houver um número maior que o atual no array ele será substituído

if(Array8[i] > maior){
maior = Array8[i];

}

// Calculando a soma, o total e a média

soma = Array8.Length *1;
total += Array8[i];
media = total / soma;

}

// Imprimindo resultados no console

Console.WriteLine("\n================================================================");
Console.WriteLine("Total de números no array: " + soma);
Console.WriteLine("Os números inseridos foram: " +string.Join(", ", Array8));
Console.WriteLine("A soma dos números do array é: " + total);
Console.WriteLine("O menor número é: " + menor);
Console.WriteLine("O maior número é: " + maior);
Console.WriteLine("A média dos números é: " + media);

}
}