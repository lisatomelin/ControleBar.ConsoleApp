using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp
{
    public class TelaPrincipal
    {
        public string ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("Controle de Medicamentos 1.0\n");

            Console.WriteLine("Digite 1 para Menu de Mesa");
            Console.WriteLine("Digite 2 para Menu de Garçom");
            Console.WriteLine("Digite 3 para Menu de Produto");
            Console.WriteLine("Digite 4 para Menu de Contas");
            

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
