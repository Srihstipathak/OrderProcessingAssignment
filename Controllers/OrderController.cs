using Microsoft.AspNetCore.Mvc;
using AssignmentProject.Services;
using AssignmentProject.Models;

namespace Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", order);
            }

            var processedOrder = _orderService.CalculateDiscount(order);
            return View("Result", processedOrder);
        }
    }
} 