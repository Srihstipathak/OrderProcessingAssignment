using AssignmentProject.Models;

namespace AssignmentProject.Services
{
    public interface IOrderService
    {
        Order CalculateDiscount(Order order);
    }
} 