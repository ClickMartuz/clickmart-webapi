using ClickMart.DataAccess.Common.Interfaces;
using ClickMart.Domain.Entities.Orders;

namespace ClickMart.DataAccess.Interfaces.Orders;

public interface IOrderRepository : IRepository<Order, Order>,
    IGetAll<Order>
{

}