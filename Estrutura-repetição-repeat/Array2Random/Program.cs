using System;

public class Array2{

public static void Main(){

// Declarando array inteiro com 100 números e usando Random para gerar números aleatórios

int[] Array2 = new int[100];
Random random = new Random();

// Loop para preencher o array com números aleatórios de 1 a 100

for (int i = 0; i < Array2.Length; i++){

Array2[i] = random.Next(1, 100);

}

// Imprimindo o array no consolo

Console.WriteLine("Números aleatórios do Array: ");
Console.WriteLine(string.Join(Environment.NewLine, Array2));

}
}