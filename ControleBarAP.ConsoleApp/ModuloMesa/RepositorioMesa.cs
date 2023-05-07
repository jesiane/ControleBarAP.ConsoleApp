using ControleBarAP.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleBarAP.ConsoleApp.ModuloMesa
{
    public class RepositorioMesa : RepositorioBase
    {
        public RepositorioMesa(ArrayList listaMesa)
        {
            this.listaRegistros = listaMesa;
        }

        public override Mesa SelecionarPorId(int id)
        {
            return (Mesa)base.SelecionarPorId(id);
        }
    }
}
