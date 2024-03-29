﻿using Produtos_one.Entities;
using System.Globalization;
namespace Product_one
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Ente the number of products");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} Data");
                Console.Write("common used  or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (type == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY) ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.WriteLine("Customs Fee: ");
                    double customFee= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name,price,customFee));
                }
                Console.WriteLine();
                Console.WriteLine("PRICE TAGS: ");
                foreach (Product prod in list) { 
                    Console.WriteLine(prod.PriceTag());
                }

            }
        }
    
    } 
} 