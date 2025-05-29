using LojaSeuManoelApi.Data;
using SeuManoelPackingApi.DTOs;
using SeuManoelPackingApi.Services;

public class PackingService : IPackingService
{
    private readonly AppDbContext _context;

    public PackingService(AppDbContext context)
    {
        _context = context;
    }

    public PedidoResponse ProcessarPedidos(PedidoRequest request)
    {
        var caixasDisponiveis = _context.Caixas.ToList(); // 🔥 Agora vem do banco
        var response = new PedidoResponse { Pedidos = new List<PedidoResultado>() };

        foreach (var pedido in request.Pedidos)
        {
            var resultado = new PedidoResultado { PedidoId = pedido.PedidoId, Caixas = new List<CaixaResultado>() };

            foreach (var produto in pedido.Produtos)
            {
                var produtoDim = produto.Dimensoes;
                var encaixado = false;

                foreach (var caixa in caixasDisponiveis)
                {
                    if (produtoDim.Altura <= caixa.Altura &&
                        produtoDim.Largura <= caixa.Largura &&
                        produtoDim.Comprimento <= caixa.Comprimento)
                    {
                        var caixaResult = resultado.Caixas.FirstOrDefault(c => c.CaixaId == caixa.CaixaId);
                        if (caixaResult == null)
                        {
                            caixaResult = new CaixaResultado { CaixaId = caixa.CaixaId, Produtos = new List<string>() };
                            resultado.Caixas.Add(caixaResult);
                        }

                        caixaResult.Produtos.Add(produto.ProdutoId);
                        encaixado = true;
                        break;
                    }
                }

                if (!encaixado)
                {
                    resultado.Caixas.Add(new CaixaResultado
                    {
                        CaixaId = null,
                        Produtos = new List<string> { produto.ProdutoId },
                        Observacao = "Produto não cabe em nenhuma caixa disponível."
                    });
                }
            }

            response.Pedidos.Add(resultado);
        }

        return response;
    }
}