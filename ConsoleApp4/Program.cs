using ConsoleApp4.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        { List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int Quantidade = int.Parse(Console.ReadLine()); 

            for (int i=0; i<Quantidade; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported(c/ u / i)? ");
                string tipo = Console.ReadLine();
                if (tipo == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double taxa = double.Parse(Console.ReadLine());
                    ProdutoImportado importado = new ProdutoImportado(name,preco,taxa);
                    list.Add(importado);
                }
                if (tipo == "c")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine());
                    Product product = new Product(name, preco);
                    list.Add(product);
                }
                if (tipo == "u")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date(DD/ MM / YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Usado usado = new Usado(name, preco, data);
                    list.Add(usado);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(var item in list)
            {
                Console.WriteLine(item.Imprimir()); 
            }

        }
    }
}
