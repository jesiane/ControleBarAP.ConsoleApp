﻿using ControleBarAP.ConsoleApp.Compartilhado;
using System.Collections;


namespace ControleBarAP.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string numero;
        public bool ocupada;

        public Mesa(string numero)
        {
            this.numero = numero;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;

            this.numero = mesaAtualizada.numero;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(numero.Trim()))
            {
                erros.Add("O campo \"Número da Mesa\" é obrigatorio");
            }
            return erros;
        }

        public void Desocupar()
        {
            ocupada = false;
        }

        public void Ocupar()
        {
            ocupada = true;
        }

    }
}
