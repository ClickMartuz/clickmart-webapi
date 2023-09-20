using ClickMart.DataAccess.Interfaces.Orders;
using ClickMart.Service.Interfaces.Orders;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

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
        => Ok();


}
