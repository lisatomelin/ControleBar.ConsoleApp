using ControleBar.ConsoleApp.Compartilhar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string nome;
        public int valor;
        

        public Produto(string nome, int valor)
        {
            this.nome = nome;
            this.valor = valor;
            
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado; 
            this.nome = produtoAtualizado.nome;
            this.valor = produtoAtualizado.valor;
            
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }
    }
}
