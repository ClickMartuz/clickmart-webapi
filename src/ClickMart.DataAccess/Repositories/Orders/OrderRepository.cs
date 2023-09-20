using ClickMart.DataAccess.Interfaces.Orders;
using ClickMart.DataAccess.Utils;
using ClickMart.Domain.Entities.Orders;
using Dapper;

namespace ClickMart.DataAccess.Repositories.Orders;

public class OrderRepository : BaseRepository, IOrderRepository
{
    public async Task<long> CountAsync()
    {
        try
        { 
            await _connection.OpenAsync();

            string query = "select count(*) from public.orders";

            var result = await _connection.QuerySingleAsync(query);

            return result;

        }

        catch (Exception ex)
        {
            return 0;
        }

        finally 
        { 
            await _connection.CloseAsync(); 
        }
    }

    public async Task<int> CreateAsync(Order entity)
    {
        try
        {
            await _connection.OpenAsync();

            string query = "INSERT INTO public.orders" +
                "(user_id, delivery_id, status, products_price, delivery_price, result_price, " +
                "latitude, longitude, payment_type, is_paid, is_contracted, description, created_at, " +
                "updated_at)" +
                "VALUES ( @UserId, @DeliveryId, @Status, @ProductsPrice, @DeliveryPrice, @ResultPrice, " +
                "@Latitude, @Longtitude, @PaymentType, @IsPaid, @IsContracted, @Description, @CreatedAt, UpdatedAt);";

            var result = await _connection.ExecuteAsync(query, entity);

            return result;

        }

        catch
        {
            return 0;
        }

        finally
        {
            await _connection.CloseAsync();
        }
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Order>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<Order?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Order entity)
    {
        throw new NotImplementedException();
    }
}
