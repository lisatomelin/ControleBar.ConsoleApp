using ControleBar.ConsoleApp.Compartilhar;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        private RepositorioMesa repositorioMesa;
        //private RepositorioGarcom repositorioGarcom;
        //private TelaGarcom telaGarcom;
        public TelaMesa(RepositorioMesa repositorioMesa /*RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom*/)
        {
            
            this.repositorioBase = repositorioMesa;
            //this.repositorioGarcom = repos
            nomeEntidade = "Mesa";
            sufixo = "s";

        }
        protected override void MostrarTabela(ArrayList registros)
        {

            Console.WriteLine("{0, -10} | {1, -20}", "Id", "Número");

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20}", mesa.id, mesa.numero);
            }

        }

        protected override EntidadeBase ObterRegistro()
        {
            //Garcom garcom = ObterGarcom();

            Console.Write("Digite o numero da mesa: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            return new Mesa(numero /*garcom*/);
        }

        //private Garcom ObterGarcom()
        //{
        //    telaGarcom.VisualizarRegistros(false);

        //    Garcom garcom = (Garcom)telaGarcom.EncontrarRegistro("Digite o id do Garçom: ");

        //    Console.WriteLine();

        //    return garcom;
        //}
    }
}
