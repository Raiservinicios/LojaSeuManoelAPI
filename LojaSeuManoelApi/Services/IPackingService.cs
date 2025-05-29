using SeuManoelPackingApi.DTOs;

namespace SeuManoelPackingApi.Services
{
    public interface IPackingService
    {
        PedidoResponse ProcessarPedidos(PedidoRequest request);
    }
}