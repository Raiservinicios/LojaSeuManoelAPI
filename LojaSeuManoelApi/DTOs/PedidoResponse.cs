using System.Text.Json.Serialization;

namespace SeuManoelPackingApi.DTOs
{
    public class PedidoResponse
    {
        [JsonPropertyName("pedidos")]
        public List<PedidoResultado> Pedidos { get; set; }
    }

    public class PedidoResultado
    {
        [JsonPropertyName("pedido_id")]
        public int PedidoId { get; set; }

        [JsonPropertyName("caixas")]
        public List<CaixaResultado> Caixas { get; set; }
    }

    public class CaixaResultado
    {
        [JsonPropertyName("caixa_id")]
        public string? CaixaId { get; set; }

        [JsonPropertyName("produtos")]
        public List<string> Produtos { get; set; }

        [JsonPropertyName("observacao")]
        public string? Observacao { get; set; }
    }
}
