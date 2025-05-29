using System.ComponentModel.DataAnnotations;

namespace SeuManoelPackingApi.Models
{
    public class Caixa
    {
        [Key]
        public string CaixaId { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Comprimento { get; set; }
    }
}