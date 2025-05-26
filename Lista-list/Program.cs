using System;
using System.Collections.Generic;

public class Lista
{
    // Propriedades públicas para armazenar o nome e quantidade de um produto
    public string Nome {get; set; }
    public int Quantidade {get; set; }

    // Lista privada que armazena os produtos
    List<Lista> listaProdutos = new List<Lista>();

    // Construtor da classe Lista que inicializa as propriedades Nome e Quantidade
    public Lista(string nome, int quantidade)
    {
        Nome = nome;
        Quantidade = quantidade;
    }

    // Método para adicionar produtos à lista e exibir os produtos
    public void AdicionarProdutos()
    {
    // Cria um novo produto usando o construtor com nome e quantidade
    Lista produto1 = new Lista("Smart TV 50' Samsung", 10);

    // Adiciona o produto criado à lista de produtos
    listaProdutos.Add(produto1);

    Lista produto2 = new Lista("PlayStation 5", 5);
    listaProdutos.Add(produto2);

    Lista produto3 = new Lista("Xbox Series X", 7);
    listaProdutos.Add(produto3);
    
        // Loop para exibir cada produto na lista
        foreach (Lista lista in listaProdutos)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine($"Produto: {lista.Nome}");
            Console.WriteLine($"Quantidade: {lista.Quantidade}");
            Console.WriteLine("=====================================================");
        }
    }
}

class Program
{
    static void Main()
    {
        // Cria uma instância da classe Lista com um produto inicial
        Lista lista = new Lista("Exemplo", 0);
        
        // Chama o método para adicionar e exibir produtos
        lista.AdicionarProdutos();
    }
}
