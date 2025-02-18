using System;
using AssignmentProject.Models;

namespace AssignmentProject.Services
{
    public class OrderService : IOrderService
    {
        public Order CalculateDiscount(Order order)
        {
            if (order.Amount >= 100 && order.CustomerType.Equals("Loyal", StringComparison.OrdinalIgnoreCase))
            {
                order.DiscountAmount = order.Amount * 0.10m;
                order.FinalTotal = order.Amount - order.DiscountAmount;
            }
            else
            {
                order.DiscountAmount = 0;
                order.FinalTotal = order.Amount;
            }
            
            return order;
        }
    }
} 