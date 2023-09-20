using ClickMart.Domain.Enums;
using System.Net.Mail;

namespace ClickMart.Domain.Entities.Orders;

public class Order : Auditable
{
    public long UserId { get; set; }

    public string ProductsPrice { get; set; }

    public OrderStatus Status { get; set; }

    public string Description { get; set; }

    public bool IsPaid { get; set; }

    public PaymentType PaymentType { get; set; }
}