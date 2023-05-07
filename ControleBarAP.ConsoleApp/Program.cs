﻿using ControleBarAP.ConsoleApp.Compartilhado;
using ControleBarAP.ConsoleApp.ModuloConta;

namespace ControleBarAP.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            while (true)
            {
                TelaBase tela = telaPrincipal.SelecionarTela();

                if (tela == null)
                    break;

                if (tela is TelaConta)
                    CadastrarContas(tela);
                else
                    ExecutarCadastros(tela);
            }
        }

        private static void ExecutarCadastros(TelaBase tela)
        {
            string subMenu = tela.ApresentarMenu();

            if (subMenu == "1")
            {
                tela.InserirNovoRegistro();
            }
            else if (subMenu == "2")
            {
                tela.VisualizarRegistros(true);
                Console.ReadLine();
            }
            else if (subMenu == "3")
            {
                tela.EditarRegistro();
            }
            else if (subMenu == "4")
            {
                tela.ExcluirRegistro();
            }
        }

        private static void CadastrarContas(TelaBase tela)
        {
            string subMenu = tela.ApresentarMenu();

            TelaConta telaConta = (TelaConta)tela;

            if (subMenu == "1")
            {
                telaConta.AbrirNovaConta();
            }
            else if (subMenu == "2")
            {
                telaConta.RegistrarPedidos();
            }
            else if (subMenu == "3")
            {
                telaConta.FecharConta();
            }
            else if (subMenu == "4")
            {
                telaConta.VisualizarContasAbertas();
                Console.ReadLine();
            }
            else if (subMenu == "5")
            {
                telaConta.VisualizarFaturamentoDoDia();
                Console.ReadLine();
            }
        }

    }

}