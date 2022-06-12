namespace ToxiCode.BuyIt.Logistics.Ui.Models;

public class GrpcOrderDto
{
    public long OrderId { get; set; }
    public DateTime CreatedDate { get; set; }
    public long FromAddressId { get; set; }
    public long ToAddressId { get; set; }
    public IEnumerable<ItemAmountPair>? Items { get; set; }
    public OrderStatus Status { get; set; }
    public string BuyerId { get; set; } = null!;
}

public class ItemAmountPair
{
    public string ItemName { get; set; } = null!;
    public long ItemId { get; set; }
    public int Count { get; set; }
}