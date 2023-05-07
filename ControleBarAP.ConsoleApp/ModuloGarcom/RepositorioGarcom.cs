using ControleBarAP.ConsoleApp.Compartilhado;
using System.Collections;


namespace ControleBarAP.ConsoleApp.ModuloGarcom
{
    public class RepositorioGarcom : RepositorioBase
    {
        public RepositorioGarcom(ArrayList listaGarcom) 
        { 
            this.listaRegistros = listaGarcom;
        }

        public override Garcom SelecionarPorId(int id)
        {
            return (Garcom)base.SelecionarPorId(id);
        }
    }
}
