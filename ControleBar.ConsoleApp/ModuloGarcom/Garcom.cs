using ControleBar.ConsoleApp.Compartilhar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string nome;
        public string Cpf;

        public Garcom(string nome, string Cpf)
        {
            this.nome = nome;
            this.Cpf = Cpf;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcomAtualizado = (Garcom)registroAtualizado;

            this.nome = garcomAtualizado.nome;
            this.Cpf = garcomAtualizado.Cpf;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo \"login\" é obrigatório");

            

            return erros;
        }
    }
}
