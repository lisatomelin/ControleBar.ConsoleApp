using ControleBar.ConsoleApp.Compartilhar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class RepositorioMesa : RepositorioBase
    {
        public RepositorioMesa(ArrayList listaMesas)
        {
              this.listaRegistros = listaMesas;
            
        }
        public override Mesa SelecionarPorId(int id)
        {
            return (Mesa)base.SelecionarPorId(id);
        }
    }
}
    

