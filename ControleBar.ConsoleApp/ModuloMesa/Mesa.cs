using ControleBar.ConsoleApp.Compartilhar;
using ControleBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int numero;
        

        public Mesa(int numero)
        {
            this.numero = numero;
            
        }


        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizado = (Mesa)registroAtualizado;
            this.numero = mesaAtualizado.numero;
            
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
