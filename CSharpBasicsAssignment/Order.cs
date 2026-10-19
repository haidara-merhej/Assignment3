namespace CSharpBasicsAssignment;

public class Order
{
    public int Id;
    public string CustomerName = null!;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity = null!;
    public char Priority;
    public long ItemCode;

    public decimal CalculateTotalPrice()
    {
        return Quantity * UnitPrice;
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Order Summary:");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Unit Price: {UnitPrice:C}");
        Console.WriteLine($"Total Price: {TotalPrice:C}");
        Console.WriteLine($"Is Paid: {IsPaid}");
        Console.WriteLine($"Discount Percent: {DiscountPercent}%");
    }
}