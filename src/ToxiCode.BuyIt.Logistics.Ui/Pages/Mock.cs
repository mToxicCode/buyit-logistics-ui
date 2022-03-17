using ToxiCode.BuyIt.Logistics.Ui.Models;

namespace OrdersComponents;

public static class Mock
{
    public static Dictionary<long, Obertka> GetItemsMock()
    {
        return new Dictionary<long, Obertka>()
        {
            {
                0, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 0,
                        Cost = 1001,
                        Name = "DotaToy"
                    },
                    Quantity = 3
                }
            },
            {
                1, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 1,
                        Cost = 101,
                        Name = "Doll"
                    },
                    Quantity = 100
                }
            },
            {
                2, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 2,
                        Cost = 10000,
                        Name = "Comics"
                    },
                    Quantity = 1
                }
            },
            {
                3, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 3,
                        Cost = 228,
                        Name = "Пальцы верченые"
                    },
                    Quantity = 100
                }
            },
            {
                4, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 4,
                        Cost = 822,
                        Name = "Пики точеные"
                    },
                    Quantity = 100
                }
            },
            {
                5, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 5,
                        Cost = 999,
                        Name = "Стулья"
                    },
                    Quantity = 2
                }
            },
            {
                6, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 6,
                        Cost = 228,
                        Name = "Почка"
                    },
                    Quantity = 4
                }
            },
            {
                7, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 7,
                        Cost = 99999999,
                        Name = "IPHone"
                    },
                    Quantity = 1
                }
            },
            {
                8, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 8,
                        Cost = 99999999,
                        Name = "Mac"
                    },
                    Quantity = 1
                }
            },
            {
                9, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 9,
                        Cost = 99999999,
                        Name = "AirPods Pro"
                    },
                    Quantity = 1
                }
            },
            {
                10, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 10,
                        Cost = 99999999,
                        Name = "Apple Watch"
                    },
                    Quantity = 1
                }
            },
            {
                11, new Obertka()
                {
                    Item = new Item()
                    {
                        Id = 10,
                        Cost = 0.00001m, Name = "Ruble"
                    },
                    Quantity = 100000
                }
            },
        };
    }

    public static Dictionary<long, Delivery> GetDeliversMock()
    {
        return new Dictionary<long, Delivery>()
        {
            {
                0, new Delivery()
                {
                    Id = 0,
                    DeliveryStart = DateTime.MinValue,
                    DeliveryEnd = DateTime.MaxValue,
                    To = "olobama",
                    From = "Amabolo",
                    Order = GetOrdersMock()[3]
                }
            }
        };
    }

    public static Dictionary<long, NCourier> GetCouriersMock()
    {
        return new Dictionary<long, NCourier>()
        {
            {
                0, new NCourier()
                {
                    Id = 0,
                    FirstName = "Nikolay", SecondName = "Sabulin", MiddleName = "Rabohabekov",
                    Business = Business.Free,
                    BirthDate = DateTime.MinValue,
                    PhoneNumber = "91546348977",
                    Mail = "edogaru@mail.com.my",
                    NearestUnderground = Underground.Undergrounds[9]
                }
            },
            {
                1, new NCourier()
                {
                    Id = 1,
                    FirstName = "Petr", SecondName = "Kuznetsov", MiddleName = "Vitaliviech",
                    Business = Business.DeliversTheOrder,
                    BirthDate = DateTime.MaxValue,
                    PhoneNumber = "8005553535",
                    Mail = "sabulitos@mail.com.my",
                    NearestUnderground = Underground.Undergrounds[5]
                }
            },
            {
                2, new NCourier()
                {
                    Id = 2,
                    FirstName = "Sergay", SecondName = "Teriyakov", MiddleName = "Stanislavovich",
                    Business = Business.Offline,
                    BirthDate = DateTime.Now,
                    PhoneNumber = "7777777777",
                    Mail = "SibirskayaYazva@mail.com",
                    NearestUnderground = Underground.Undergrounds[3]
                }
            },
            {
                3, new NCourier()
                {
                    Id = 3,
                    FirstName = "Sasha", SecondName = "Gray", MiddleName = "Hrenovna",
                    Business = Business.ReceivesAnOrder,
                    BirthDate = DateTime.Now,
                    PhoneNumber = "5552223113",
                    Mail = "BojePomogi@yandex.ru",
                    NearestUnderground = Underground.Undergrounds[15]
                }
            },
            {
                4, new NCourier()
                {
                    Id = 4,
                    FirstName = "Misha", SecondName = "Terebulkin", MiddleName = "Petrov",
                    Business = Business.Break,
                    BirthDate = DateTime.Today,
                    PhoneNumber = "2288227755",
                    Mail = "StanbulVpered@mail.com",
                    NearestUnderground = Underground.Undergrounds[3]
                }
            }
        };
    }

    public static Dictionary<long, Order> GetOrdersMock()
    {
        return new Dictionary<long, Order>()
        {
            {
                0, new Order()
                {
                    Name = "Kuznetsov Daniil Dmitrievich", Items = new Dictionary<long, Obertka>()
                    {
                        { 0, GetItemsMock()[0] },
                        { 1, GetItemsMock()[1] },
                        { 2, GetItemsMock()[2] }
                    }
                }
            },
            {
                1, new Order()
                {
                    Id = 1, Name = "Kuznetsov Daniil Andreevich", Items = new Dictionary<long, Obertka>()
                    {
                        { 4, GetItemsMock()[3] },
                        { 3, GetItemsMock()[4] },
                        { 5, GetItemsMock()[5] }
                    }
                }
            },
            {
                2, new Order()
                {
                    Id = 2123132123, Name = "Plastic Toy", Items = new Dictionary<long, Obertka>()
                    {
                        { 6, GetItemsMock()[6] }
                    }
                }
            },
            {
                3, new Order()
                {
                    Id = 7, Name = "American daddy", Items = new Dictionary<long, Obertka>()
                    {
                        { 7, GetItemsMock()[7] },
                        { 8, GetItemsMock()[8] },
                        { 9, GetItemsMock()[9] },
                        { 10, GetItemsMock()[10] }
                    }
                }
            },
            {
                4, new Order()
                {
                    Id = 12, Name = "Alice Smith", Items = new Dictionary<long, Obertka>()
                    {
                        { 12, GetItemsMock()[11] }
                    }
                }
            }
        };
    }
}