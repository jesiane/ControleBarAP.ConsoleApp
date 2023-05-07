using ControleBarAP.ConsoleApp.Compartilhado;
using System.Collections;


namespace ControleBarAP.ConsoleApp.ModuloProduto
{
    public class RepositorioProduto : RepositorioBase
    {
        public RepositorioProduto(ArrayList listaProduto) 
        {
            this.listaRegistros = listaProduto;
        }

        public override Produto SelecionarPorId(int id)
        {
            return (Produto)base.SelecionarPorId(id);
        }
    }
}
