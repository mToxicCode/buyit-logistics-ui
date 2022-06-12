using ToxiCode.BuyIt.Logistics.Ui.Models;

namespace ToxiCode.BuyIt.Logistics.Ui.Services.Abstractions;

public interface IItemService
{
    public Task<ItemDto?> GetItemById(long itemId);
    public Task<IEnumerable<ItemDto>?> GetItems();
    public Task<IEnumerable<ItemDto>?> GetItemsByIds();

}