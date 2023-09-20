using ClickMart.Domain.Enums;

namespace ClickMart.Persistance.Dtos.Orders;

public class OrderUpdateDto
{
    public long UserId { get; set; }

    public long DeliverId { get; set; }

    public OrderStatus Status { get; set; }

    // The summ of order details result prices
    // The money which that user must pay for products
    public double ProductsPrice { get; set; }

    public double DeliveryPrice { get; set; }

    // The payment that user must pay for sales
    // Products Price + Delivery Price
    public double ResultPrice { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public PaymentType Payment { get; set; }

    public bool IsPaid { get; set; }

    public bool IsContracted { get; set; }

    public string Description { get; set; } = String.Empty;
}
