using System;

public class Array7{

public static void Main(){

// Declaração de array

int[] Array7 = new int[10];
int i = 0;

// Loop para preencher array

while (i < Array7.Length){

// Incremento de array

Array7[i] = i + 1;
i++;

}

// Imprimindo array no console

Console.WriteLine("Contando até 10: " + string.Join(", ", Array7));

}
}