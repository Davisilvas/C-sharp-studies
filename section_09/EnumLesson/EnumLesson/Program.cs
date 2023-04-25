using System;
using EnumLesson.Entities;
using EnumLesson.Entities.Enums;

namespace EnumLesson 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1070,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}