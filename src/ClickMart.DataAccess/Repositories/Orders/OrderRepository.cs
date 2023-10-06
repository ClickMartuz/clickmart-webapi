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

    public async Task<int> DeleteAsync(long id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "DELETE FROM public.orders WHERE id = @Id;";
            var result = await _connection.ExecuteAsync(query, new { Id = id });
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

    public async Task<IList<Order>> GetAllAsync(PaginationParams @params)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Select * from public.orders order by id desc " +
                $"offset {@params.GetSkipCount()} limit {@params.PageSize}";
            var result = (await _connection.QueryAsync<Order>(query)).ToList();

            return result;

        }

        catch
        {
            return new List<Order>();
        }

        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<Order?> GetByIdAsync(long id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "select * from public.orders where id = @Id";
            var result = await _connection.QuerySingleAsync<Order>(query, new { Id = id });
            return result;
        }
        
        catch
        {
            return null;
        }

        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<int> UpdateAsync(long id, Order entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "";
        }

        catch
        {

        }

        finally
        {
            await _connection.CloseAsync();
        }
    }
}
