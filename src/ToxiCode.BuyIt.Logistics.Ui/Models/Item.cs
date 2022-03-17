namespace ToxiCode.BuyIt.Logistics.Ui.Models;

public class Item
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Cost { get; set; }
    public long Quantity { get; set; }
}