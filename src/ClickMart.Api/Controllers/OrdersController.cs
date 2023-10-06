using ClickMart.DataAccess.Interfaces.Orders;
using ClickMart.DataAccess.Utils;
using ClickMart.Persistance.Dtos.Orders;
using ClickMart.Service.Interfaces.Orders;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace ClickMart.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrderRepository _repository;
    private readonly IOrderService _service;

    private readonly int maxPageSize = 30;

    public OrdersController(IOrderRepository repository, IOrderService service)
    {
        this._repository = repository;
        this._service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] int page = 1)
        => Ok(await _service.GetAllAsync(new PaginationParams(page, maxPageSize)));

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] OrderCreateDto dto)
        => Ok(await _service.CreateAsync(dto));

    [HttpDelete("{orderId}")]
    public async Task<IActionResult> DeleteAsync([FromForm] long orderId) 
        => Ok(await _service.DeleteAsync(orderId));

    [HttpPut("{orderId}")]
    public async Task<IActionResult> UpdateAsync(long orderId, [FromBody] OrderUpdateDto dto)
        => Ok(await _service.UpdateAsync(orderId, dto));
        
    

}
