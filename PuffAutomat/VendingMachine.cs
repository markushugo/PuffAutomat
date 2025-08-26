using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuffAutomat
{
    public class VendingMachine
    {
        
        public double InsertedAmount { get; private set; }
        public List<Product> Products { get; private set; }
        public List<string> TransactionLog { get; private set; }
                
        public void AddProduct()
        {
            Console.WriteLine("Hvad er produktets ID?");
            string id = Console.ReadLine();
            Console.WriteLine("Hvad er produktets navn?");
            string name = Console.ReadLine();
            Console.WriteLine("Hvad er produktets pris?");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hvor mange puffs har produktet?");
            int puffs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvad er produktets brand?");
            string brand = Console.ReadLine();

            Product product = new Product(id, name, price, puffs, brand);
            Console.WriteLine("Du har oprettet følgende produkt i automaten:");
            PrintProduct(product);
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine($"ID: {product.ID}, Navn: {product.Name}, Pris: {product.Price}, Puffs: {product.Puffs}, Brand: {product.Brand}");
        }

        public void PrintAllProducts()
        {
            List<Product> products = Products;
            foreach (Product product in products)
            {
                PrintProduct(product);
            }
        }
    }
}
