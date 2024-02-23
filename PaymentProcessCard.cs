﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessCard(string securityCode) : PaymentProcess, ISecurityCode
    {
        public string SecurityCode { get; set; } = securityCode;
        public override void Pay(Order order)
        {
            Console.WriteLine($"Processing -card- payment for {order.OrderPrice()} with security code {SecurityCode}");
            order.Status = 1;
        }
    }
}