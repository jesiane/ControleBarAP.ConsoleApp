﻿using ControleBarAP.ConsoleApp.Compartilhado;
using System.Collections;


namespace ControleBarAP.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Produto produto in registros)
            {
                Console.Write(produto.id + ", " + produto.nome + ", " + produto.preco);
                Console.WriteLine();
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Digite o nome do produto");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto ");
            decimal precoProduto = Convert.ToDecimal(Console.ReadLine());

            return new Produto(nomeProduto, precoProduto);

        }
    }
}
