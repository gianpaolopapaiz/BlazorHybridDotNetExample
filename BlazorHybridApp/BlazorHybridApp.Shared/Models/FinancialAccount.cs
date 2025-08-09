// account class
namespace BlazorHybridApp.Shared.Models
{
    public class FinancialAccount
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0.0m;
        public string Currency { get; set; } = string.Empty;
    }
}