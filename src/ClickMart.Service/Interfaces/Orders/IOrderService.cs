using ClickMart.Domain.Entities.Orders;
using ClickMart.Persistance.Dtos.Orders;

namespace ClickMart.Service.Interfaces.Orders;

public interface IOrderService
{
    public Task<bool> CreateAsync(OrderCreateDto dto);

    public Task<bool> DeleteAsync(long orderId);
    
    public Task<long> CountAsync();

    public Task<IList<Order>> GetAllAsync(long id);

    public Task<Order> GetByIdAsync(long id);

    public Task<bool> UpdateAsync(OrderUpdateDto dto);
}
