using System;

class PA
{
    static void Main()
    {

        // Declarando array vazio

        int[] PA = new int[0];
        int count = 0;

        // Inserindo critérios da PA

        Console.WriteLine("Deseja a PA crescente(1) ou decrescente(2)?");
        string s = Console.ReadLine();
        int.TryParse(s, out int tipo);

        Console.WriteLine("Insira o número de termos da PA: ");
        string n = Console.ReadLine();
        int.TryParse(n, out int pos);

        Console.WriteLine("Insira a razão: ");
        string r = Console.ReadLine();
        int.TryParse(r, out int raz);

        Console.WriteLine("Insira o primeiro termo da PA: ");
        string p = Console.ReadLine();
        int.TryParse(p, out int pt);

        // Acrescentando indices ao array

        Array.Resize(ref PA, pos);

            // Definindo tipo de PA
            
            if (tipo == 1)
            {
                for (int i = 0; i < pos; i++)
                PA[i] = pt + i * raz;
            }

            if (tipo == 2)
            {
                for (int i = 0; i < pos; i++)
                PA[i] = pt - i * raz;
            }

            // Imprimindo resultado

            Console.WriteLine("Os termos da PA são: " + string.Join(", ", PA));
    }

}