﻿using ControleBarAP.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBarAP.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string nome;
        public decimal preco;

        public Produto(string nome, decimal preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            this.nome = produtoAtualizado.nome;
            this.preco = produtoAtualizado.preco;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
            {
                erros.Add("O campo \"Nome\" é obrigatorio");
            }
            if (preco == 0)
            {
                erros.Add("O campo \"Preço\" é obrigatorio");
            }

            return erros;
        }
    }
}
