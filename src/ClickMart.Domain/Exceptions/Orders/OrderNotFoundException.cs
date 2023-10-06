namespace ClickMart.Domain.Exceptions.Orders;

public class OrderNotFoundException : NotFoundException
{
    public OrderNotFoundException()
    {
        this.TitleMessage = string.Empty;
    }
}
