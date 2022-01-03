using System;
using System.Collections.Generic;
using Aula5.Entities;
using Aula5.Entities.Enums;

namespace Aula5 {
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 0,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine("Order ID: " + order.Id);
            Console.WriteLine("Order time: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);            
        }
    }
}
