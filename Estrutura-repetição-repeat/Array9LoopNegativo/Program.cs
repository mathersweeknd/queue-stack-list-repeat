using System;

public class Array9{

public static void Main(){

// Criando um array vazio e um contador de entradas    

int[] Array9 = new int[0];
int count = 0;

// Loop para adicionar números ao array em string convertendo em inteiro, com opção de saída
// Ao digitar "sair", ou um número negativo, o break encerra o programa.

while (true){

Console.WriteLine("Digite um número ou digite 'sair': ");

string input = Console.ReadLine();

if (input?.ToLower() == "sair"){

break;
}

if (int.TryParse(input, out int numero)){

// Dimensionar o array a cada iteração e definindo que somente números podem ser adicionados

    Array.Resize(ref Array9, count + 1);
    Array9[count] = numero;
    count++;
}
else {

Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");

}

// Variavel que detecta e encerra o programa ao inserir número negativo

if (numero < 0){

Console.WriteLine("Número negativo digitado. Saindo do programa.");
break;

}
}

// Imprimindo resultado

Console.WriteLine("Números digitados: " + string.Join(", ", Array9));

}
}