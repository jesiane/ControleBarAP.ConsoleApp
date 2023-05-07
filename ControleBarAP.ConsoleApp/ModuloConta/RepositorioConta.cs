using ControleBarAP.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleBarAP.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaContas)
        {
            listaRegistros = listaContas;
        }
        public ArrayList SelecionarContasEmAberto()
        {
            ArrayList contasEmAberto = new ArrayList();

            foreach (Conta conta in listaRegistros)
            {
                if (conta.estaAberta)
                    contasEmAberto.Add(conta);
            }

            return contasEmAberto;
        }

        public ArrayList SelecionarContasFechadas(DateTime data)
        {
            ArrayList contasEmAberto = new ArrayList();

            foreach (Conta conta in listaRegistros)
            {
                if (conta.estaAberta == false && conta.data.Date == data.Date)
                    contasEmAberto.Add(conta);
            }

            return contasEmAberto;
        }
    }
}
