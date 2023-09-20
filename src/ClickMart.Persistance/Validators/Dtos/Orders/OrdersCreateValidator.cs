using ClickMart.Persistance.Dtos.Orders;
using FluentValidation;

namespace ClickMart.Persistance.Validators.Dtos.Orders;

public class OrdersCreateValidator : AbstractValidator<OrderCreateDto>
{
    public OrdersCreateValidator()
    {
    }
}