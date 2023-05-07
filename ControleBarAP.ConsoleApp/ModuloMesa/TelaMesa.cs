﻿using ControleBarAP.ConsoleApp.Compartilhado;
using System.Collections;
namespace ControleBarAP.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Mesa mesa in registros)
            {
                string ocupada = mesa.ocupada ? "Ocupada" : "Desocupada";
                Console.Write(mesa.id + ", " + mesa.numero + ", " + ocupada);
                Console.WriteLine();
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Digite o numero da mesa: ");
            string numeroMesa = Console.ReadLine();

            return new Mesa(numeroMesa);
        }
    }
}
