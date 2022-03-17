namespace ToxiCode.BuyIt.Logistics.Ui.Models;

public class Order
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public IDictionary<long, Obertka> Items { get; set; } = null!;
}