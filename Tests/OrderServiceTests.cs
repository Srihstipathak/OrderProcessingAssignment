using Xunit;
using AssignmentProject.Services;
using AssignmentProject.Models;

public class OrderServiceTests
{
    private readonly OrderService _orderService;

    public OrderServiceTests()
    {
        _orderService = new OrderService();
    }

    [Fact]
    public void CalculateDiscount_LoyalCustomerOver100_Returns10PercentDiscount()
    {
        // Arrange
        var order = new Order
        {
            Amount = 200m,
            CustomerType = "Loyal"
        };

        // Act
        var result = _orderService.CalculateDiscount(order);

        // Assert
        Assert.Equal(20m, result.DiscountAmount);
        Assert.Equal(180m, result.FinalTotal);
    }

    [Fact]
    public void CalculateDiscount_NewCustomerOver100_ReturnsNoDiscount()
    {
        // Arrange
        var order = new Order
        {
            Amount = 200m,
            CustomerType = "New"
        };

        // Act
        var result = _orderService.CalculateDiscount(order);

        // Assert
        Assert.Equal(0m, result.DiscountAmount);
        Assert.Equal(200m, result.FinalTotal);
    }
} 