namespace ToxiCode.BuyIt.Logistics.Ui.Models;

public class Delivery
{
    public long Id { get; set; }
    public Order Order { get; set; } = null!;
    public DateTime DeliveryStart { get; set; }
    public DateTime? DeliveryEnd { get; set; }
    public string From { get; set; } = null!;
    public string To { get; set; } = null!;
}