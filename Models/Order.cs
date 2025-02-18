namespace AssignmentProject.Models
{
    public class Order
    {
        public decimal Amount { get; set; }
        public string CustomerType { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalTotal { get; set; }
    }
} 