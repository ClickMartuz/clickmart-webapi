using ClickMart.DataAccess.Interfaces.Orders;
using ClickMart.Domain.Entities.Orders;
using ClickMart.Persistance.Dtos.Orders;
using ClickMart.Service.Interfaces.Orders;

namespace ClickMart.Service.Services.Orders;

public class OrderService : IOrderService
{

    private IOrderRepository _repository;

    public OrderService(IOrderRepository repository)
    {
        this._repository = repository;
    }


    public Task<long> CountAsync()
        => _repository.CountAsync();

    public Task<bool> CreateAsync(OrderCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long orderId)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Order>> GetAllAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(OrderUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
