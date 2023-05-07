using ControleBarAP.ConsoleApp.ModuloProduto;

namespace ControleBarAP.ConsoleApp.ModuloConta
{
    public class Pedido
    {
        public static int contadorId;
        public int id;
        public Produto produto;
        public int quantidadeSolicitada;

        public Pedido(Produto produto, int quantidadeSolicitada)
        {
            contadorId++;
            id = contadorId;

            this.produto = produto;
            this.quantidadeSolicitada = quantidadeSolicitada;
        }

        public decimal CalcularTotalParcial()
        {
            //produto: cerveja
            //quantidade: 3
            return produto.preco * quantidadeSolicitada;
        }
    }
}
