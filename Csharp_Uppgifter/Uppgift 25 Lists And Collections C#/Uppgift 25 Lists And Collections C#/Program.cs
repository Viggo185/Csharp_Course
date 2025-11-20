using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_25_Lists_And_Collections_C_
{
    internal class Program
    {

public class Inventory
    {
        
        private List<string> items = new List<string>();

        
        private Dictionary<string, (double price, int stock)> itemDetails =
            new Dictionary<string, (double, int)>();

        
        public void AddItem(string name, double price, int stock)
        {
            if (!items.Contains(name))
            {
                items.Add(name);
                itemDetails[name] = (price, stock);
      
            }
            else
            {
                Console.WriteLine($"{name} already exists in inventory.");
            }
        }

        
        public void RemoveItem(string name)
        {
            if (items.Contains(name))
            {
                items.Remove(name);
                itemDetails.Remove(name);
                Console.WriteLine($"{name} removed.");
            }
            else
            {
                Console.WriteLine($"{name} not found.");
            }
        }

        
        public void UpdateStock(string name, int newStock)
        {
            if (itemDetails.ContainsKey(name))
            {
                var current = itemDetails[name];
                itemDetails[name] = (current.price, newStock);
                Console.WriteLine($"Stock updated: {name} now has {newStock} units.");
            }
            else
            {
                Console.WriteLine($"{name} not found.");
            }
        }

        
        public void PrintAllItems()
        {
            Console.WriteLine("\n--- Inventory Items ---");
            foreach (var name in items)
            {
                var details = itemDetails[name];
                Console.WriteLine($"{name} - Price: {details.price}, Stock: {details.stock}");
            }
        }

        
        public void PrintMostExpensiveItem()
        {
            if (itemDetails.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            var expensive = itemDetails.OrderByDescending(x => x.Value.price).First();
            Console.WriteLine($"\nMost Expensive Item: {expensive.Key} {expensive.Value.price}");
        }

        
        public void PrintTotalInventoryValue()
        {
            double total = 0;

            foreach (var item in itemDetails.Values)
            {
                total += item.price * item.stock;
            }

            Console.WriteLine($"\nTotal Inventory Value: {total}");
        }
}

        static void Main(string[] args)
        {
            Inventory inv = new Inventory();

            inv.AddItem("Laptop", 1200.50, 5);
            inv.AddItem("Smartphone", 800.00, 10);
            inv.AddItem("Tablet", 450.00, 7);

            inv.PrintAllItems();
            inv.UpdateStock("Laptop", 8);
            inv.PrintMostExpensiveItem();
            inv.PrintTotalInventoryValue();

            inv.RemoveItem("Laptop");
        }
    }
}
