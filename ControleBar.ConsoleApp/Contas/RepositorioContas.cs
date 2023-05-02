using ControleBar.ConsoleApp.Compartilhar;
using ControleBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.Contas
{
    public class RepositorioContas : RepositorioBase
    {
        public RepositorioContas(ArrayList listaContas)
        {
            this.listaRegistros = listaContas;
        }

        public override Contas SelecionarPorId(int id)
        {
            return (Contas)base.SelecionarPorId(id);
        }
    }
}

