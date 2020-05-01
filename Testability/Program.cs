using System;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 15f, Note = "Floor 2/18"};
            var order2 = new Order { DatePlaced = DateTime.Now, TotalPrice = 105f, Note = "Floor 2/18" };
            var order3 = new Order { DatePlaced = DateTime.Now.AddDays(1), TotalPrice = 1015f, Note = "Floor 2/18" };

            orderProcessor.Process(order);
            Console.WriteLine(order.Shipment.Cost);
            Console.WriteLine(order.Shipment.ShippingDate);
            Console.WriteLine(order.Shipment.Note);

            orderProcessor.Process(order2);
            Console.WriteLine(order2.Shipment.Cost);
            Console.WriteLine(order2.Shipment.ShippingDate);
            Console.WriteLine(order2.Shipment.Note);
            Console.WriteLine(order2.IsShipped);
            Console.WriteLine(order3.IsShipped);
        }
    }
}
