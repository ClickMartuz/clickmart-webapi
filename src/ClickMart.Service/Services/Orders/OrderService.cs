using ClickMart.DataAccess.Interfaces.Orders;
using ClickMart.DataAccess.Utils;
using ClickMart.Domain.Entities.Orders;
using ClickMart.Domain.Entities.Users;
using ClickMart.Domain.Exceptions.Orders;
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


    public async Task<bool> CreateAsync(OrderCreateDto dto)
    {

        Order order = new Order()
        {
            UserId = dto.UserId,
            DeliverId = dto.DeliverId,
            Status = dto.Status,
            ProductsPrice = dto.ProductsPrice,
            DeliveryPrice = dto.DeliveryPrice,
            ResultPrice = dto.ResultPrice,
            Latitude = dto.Latitude,
            Longitude = dto.Longitude,
            Payment = dto.Payment,
            IsPaid = dto.IsPaid,
            IsContracted = dto.IsContracted,
            Description = dto.Description,
        };
    

        var result = await _repository.CreateAsync(order);

        return result > 0;
    }

    public async Task<bool> DeleteAsync(long orderId)
    {
        var result = await _repository.DeleteAsync(orderId);

        return result > 0;
    }

    public async Task<IList<Order>> GetAllAsync(PaginationParams @params)
    {
        var order = await _repository.GetAllAsync(@params);

        return order;
    }

    public async Task<Order> GetByIdAsync(long id)
    {
        var order = await _repository.GetByIdAsync(id);

        if (order is null) throw new OrderNotFoundException();

        else return order;
        
    }

    public async Task<bool> UpdateAsync(long orderId, OrderUpdateDto dto)
    {
        var order = await _repository.GetByIdAsync(orderId);

        order.Longitude = dto.Longitude;
        order.Latitude = dto.Latitude;
        order.Description = dto.Description;
        order.Payment = dto.Payment;
        

        var result = await _repository.UpdateAsync(orderId, order);

        return result > 0;
    }
}