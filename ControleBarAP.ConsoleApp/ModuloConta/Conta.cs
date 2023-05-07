using ControleBarAP.ConsoleApp.Compartilhado;
using ControleBarAP.ConsoleApp.ModuloGarcom;
using ControleBarAP.ConsoleApp.ModuloMesa;
using ControleBarAP.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleBarAP.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Mesa mesa;
        public ArrayList pedidos;
        public Garcom garcom;
        public bool estaAberta;

        public DateTime data;

        public Conta(Mesa mesa, Garcom garcom, DateTime data)
        {
            this.mesa = mesa;
            this.garcom = garcom;
            pedidos = new ArrayList();
            this.data = data;

            Abrir();

        }

        public void RegistrarPedido(Produto produto, int quantidadeEscolhida)
        {
            Pedido novoPedido = new Pedido(produto, quantidadeEscolhida);

            pedidos.Add(novoPedido);
        }

        public decimal CalcularValorTotal()
        {
            decimal total = 0;

            foreach (Pedido pedido in pedidos)
            {
                decimal totalPedido = pedido.CalcularTotalParcial();

                total += totalPedido;
            }

            return total;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta contaAtualizada = (Conta)registroAtualizado;

            garcom = contaAtualizada.garcom;
            mesa = contaAtualizada.mesa;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (garcom == null)
            {
                erros.Add("O campo \"Garçom\" é obrigatorio");
            }

            if (mesa == null)
            {
                erros.Add("O campo \"Mesa\" é obrigatorio");
            }

            return erros;
        }

        private void Abrir()
        {
            estaAberta = true;
            mesa.Ocupar();
        }

        public void Fechar()
        {
            estaAberta = false;
            mesa.Desocupar();
        }
    }
}
