using System;

public class Array3{

public static void Main(){

// Declarando array inteiro de 100 números e Random para aleatorizar os resultados

int[] Array3 = new int[100];
Random random = new Random();

// Loop para contar todos os números do array e aleatorizar os resultados

for (int i = 0; i < Array3.Length; i++){

Array3[i] = random.Next(1, 100);

}

// Imprimindo o resultado no console

Console.WriteLine("Números aleatórios do array: " +string.Join(", ", Array3));

}
}