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
    public class TelaContas : TelaBase
    {
        private RepositorioContas repositorioContas;
        private RepositorioGarcom repositorioGarcom;
        private RepositorioMesa repositorioMesa;
        private RepositorioProduto repositorioProduto;

        private TelaGarcom telaGarcom;
        private TelaMesa telaMesa;
        private TelaProduto telaProduto;

        public TelaContas(RepositorioContas repositorioContas, RepositorioProduto repositorioProduto, RepositorioMesa repositorioMesa,
            RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom, TelaMesa telaMesa, TelaProduto telaProduto)
        {
            this.repositorioContas = repositorioContas;
            this.repositorioProduto = repositorioProduto;
            this.repositorioMesa = repositorioMesa;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.telaMesa = telaMesa;
            this.telaProduto = telaProduto;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Número", "Mesa", "Garçom", "Produto", "Quantidade", "Valor");

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            foreach (Contas contas in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", contas.id, contas.numero, contas.mesa.numero, contas.garcom.nome, contas.produto.nome, contas.produto.quantidade, contas.produto.valor);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o numero da Conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Produto produto = ObterProduto();

            Mesa mesa = ObterMesa();

            Garcom garcom = ObterGarcom();

            Console.Write("Digite a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());



            return new Contas(numero, mesa, produto, garcom, data);
        }
        private Produto ObterProduto()
        {
            telaProduto.VisualizarRegistros(false);

            Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do funcionário: ");

            Console.WriteLine();

            return produto;
        }

        private Mesa ObterMesa()
        {
            telaMesa.VisualizarRegistros(false);

            Mesa mesa = (Mesa)telaMesa.EncontrarRegistro("Digite o id do medicamento: ");

            Console.WriteLine();

            return mesa;
        }
        private Garcom ObterGarcom()
        {
            telaGarcom.VisualizarRegistros(false);

            Garcom garcom = (Garcom)telaGarcom.EncontrarRegistro("Digite o id do Garçom: ");

            Console.WriteLine();

            return garcom;
        }
    }    
}