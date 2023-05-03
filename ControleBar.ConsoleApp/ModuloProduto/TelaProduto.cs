using ControleBar.ConsoleApp.Compartilhar;
using ControleBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloProduto
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
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Valor");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", produto.id, produto.nome, produto.valor);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            
            return new Produto(nome, valor);
        }
    }
}
