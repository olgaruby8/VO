using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ViewOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path to the ViewOrder file:");
            var pach = Console.ReadLine();
            var ViewOrder = new ViewOrder(pach);
            Console.WriteLine($"ViewOrder: Id: {ViewOrder.Id}");
            foreach (var item in ViewOrder.Items)
                {
                    Console.WriteLine($" Item: Id: {item.Id}, Name: {item.Name}");
                    foreach (var property in item.Properties)
                    {
                        Console.WriteLine($"    Property: Id: {property.Id}, Name: {property.Name}, Val: {property.Val}");
                        
                    }
                Console.ReadKey();

            }
            }
    }
}
