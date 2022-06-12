using System.Text.Json.Serialization;

namespace ToxiCode.BuyIt.Logistics.Ui.Models;

public class OrderDto
{
    public long Id { get; set; }
    public DateTime CreationDate { get; set; }
    public long From { get; set; }
    public long To { get; set; }
    public IEnumerable<ItemInOrder>? Items { get; set; }
    public OrderStatus Status { get; set; }
    public string BuyerId { get; set; } = null!;
}

public class ItemInOrder
{
    public string ItemName { get; set; } = null!;
    public long ItemId { get; set; }
    public int Count { get; set; }
}
