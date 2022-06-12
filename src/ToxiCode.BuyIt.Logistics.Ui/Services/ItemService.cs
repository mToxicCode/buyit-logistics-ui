using Newtonsoft.Json;
using ToxiCode.BuyIt.Logistics.Ui.Models;
using ToxiCode.BuyIt.Logistics.Ui.Services.Abstractions;

namespace ToxiCode.BuyIt.Logistics.Ui.Services;

public class ItemService : IItemService
{
    private readonly HttpClient _httpClient;

    public ItemService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ItemDto?> GetItemById(long itemId)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"/api/item/{itemId}");
        var response = await _httpClient.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        var item = JsonConvert.DeserializeObject<ItemDto>(responseJson);
        return item;
    }

    public async Task<IEnumerable<ItemDto>?> GetItems()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"/api/items");
        var response = await _httpClient.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        var items = JsonConvert.DeserializeObject<IEnumerable<ItemDto>>(responseJson);
        return items;
    }

    public Task<IEnumerable<ItemDto>?> GetItemsByIds()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ItemDto>?> GetItemsByIds(long[] itemsIds)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, $"http://localhost:5000/api/itemsByIds");
        request.Content = new StringContent(JsonConvert.SerializeObject(itemsIds));
        var response = await _httpClient.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        var items = JsonConvert.DeserializeObject<IEnumerable<ItemDto>>(responseJson);
        return items;
    }
}