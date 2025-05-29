using System.Text.Json.Serialization;

namespace SeuManoelPackingApi.DTOs
{
    public class PedidoRequest
    {
        [JsonPropertyName("pedidos")]
        public List<Pedido> Pedidos { get; set; }
    }

    public class Pedido
    {
        [JsonPropertyName("pedido_id")]
        public int PedidoId { get; set; }

        [JsonPropertyName("produtos")]
        public List<Produto> Produtos { get; set; }
    }

    public class Produto
    {
        [JsonPropertyName("produto_id")]
        public string ProdutoId { get; set; }

        [JsonPropertyName("dimensoes")]
        public Dimensoes Dimensoes { get; set; }
    }

    public class Dimensoes
    {
        [JsonPropertyName("altura")]
        public int Altura { get; set; }

        [JsonPropertyName("largura")]
        public int Largura { get; set; }

        [JsonPropertyName("comprimento")]
        public int Comprimento { get; set; }
    }
}
