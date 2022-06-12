using ToxiCode.BuyIt.Logistics.Ui.Models;

namespace ToxiCode.BuyIt.Logistics.Ui.Services.Abstractions;

public interface IOrderService
{
    public Task<IEnumerable<OrderDto>?> GetOrders();
    public Task<IEnumerable<OrderDto>?> GetOrderByBuyerId(string buyerId);
    public Task<GrpcOrderDto> GetOrderById(long orderId);
}