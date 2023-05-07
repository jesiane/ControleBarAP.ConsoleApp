﻿using ControleBarAP.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleBarAP.ConsoleApp.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string nome { get; set; }

        public Garcom(string nome)
        {
            this.nome = nome;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcomAtualizado = (Garcom)registroAtualizado;

            this.nome = garcomAtualizado.nome;
        }

        public override ArrayList Validar()
        {
           ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
            {
                erros.Add("O campo \"Nome\" é obrigatorio");
            }

            return erros;
        }
    }
}
