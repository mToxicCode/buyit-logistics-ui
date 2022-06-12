using System.Net.Http.Json;
using Newtonsoft.Json;
using ToxiCode.BuyIt.Logistics.Ui.Models;
using ToxiCode.BuyIt.Logistics.Ui.Services.Abstractions;

namespace ToxiCode.BuyIt.Logistics.Ui.Services;

public class OrderService : IOrderService
{
    private readonly HttpClient _httpClient;

    public OrderService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<IEnumerable<OrderDto>?> GetOrders()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"/api/orders");
        var response = await _httpClient.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        var orders = JsonConvert.DeserializeObject<OrderResponse>(responseJson);
        return orders?.Orders;
    }

    public async Task<IEnumerable<OrderDto>?> GetOrderByBuyerId(string buyerId)
    {
        var request = new HttpRequestMessage(HttpMethod.Patch, $"/v1/orders/get");

        request.Content = JsonContent.Create(new {buyerId = buyerId});
        Console.WriteLine(request);
        var response = await _httpClient.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        var orders = JsonConvert.DeserializeObject<IEnumerable<OrderDto>>(responseJson);
        return orders;
    }

    public async Task<GrpcOrderDto> GetOrderById(long orderId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"/api/orderById/{orderId}");
        var response = await _httpClient.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseJson);
        var orders = JsonConvert.DeserializeObject<GrpcOrderDto>(responseJson);
        return orders!;
    }
}

public class OrderResponse
{
    public OrderDto[] Orders { get; set; } = Array.Empty<OrderDto>();
}