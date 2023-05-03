using ControleBar.ConsoleApp.Compartilhar;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.Contas
{
    public class Contas : EntidadeBase
    {
        public DateTime data;
        public int numero;
        public Mesa mesa;
        public Produto produto;
        public Garcom garcom;
        public string status;

        public Contas(int numero, Mesa mesa, Produto produto, Garcom garcom, DateTime data)
        {
            this.numero = numero;
            this.mesa = mesa;
            this.produto = produto;
            this.garcom = garcom;
            this.data = data;
            this.status = "Aberto";
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Contas contasAtualiada = (Contas)registroAtualizado;
            this.numero = contasAtualiada.numero;
            this.mesa = contasAtualiada.mesa;
            this.produto = contasAtualiada.produto;
            this.garcom = contasAtualiada.garcom;
            this.data = contasAtualiada.data;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (numero < 0)
                erros.Add("O campo \"numero\" é obrigatório");

           

            return erros;
        }
    }
}
