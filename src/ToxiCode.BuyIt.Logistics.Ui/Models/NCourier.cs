namespace ToxiCode.BuyIt.Logistics.Ui.Models;

public class NCourier
{
    public long Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string SecondName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Mail { get; set; } = null!;
    public string? NearestUnderground { get; set; }
    public DateTime BirthDate { get; set; }
    public Business Business { get; set; }
}