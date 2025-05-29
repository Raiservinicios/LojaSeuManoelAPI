using Microsoft.AspNetCore.Mvc;
using SeuManoelPackingApi.DTOs;
using SeuManoelPackingApi.Services;

namespace SeuManoelPackingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IPackingService _packingService;
        public PedidosController(IPackingService packingService)
        {
            _packingService = packingService;
        }

        [HttpPost]
        public IActionResult EmbalarPedidos([FromBody] PedidoRequest request)
        {
            var result = _packingService.ProcessarPedidos(request);
            return Ok(result);
        }
    }
}