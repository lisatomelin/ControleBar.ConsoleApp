using ControleBar.ConsoleApp.Contas;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());
            RepositorioContas repositorioContas = new RepositorioContas(new ArrayList());


            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            TelaMesa telaMesa = new TelaMesa(repositorioMesa/*, repositorioGarcom,telaGarcom*/);
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            TelaContas telaContas = new TelaContas(repositorioContas, repositorioProduto, repositorioMesa, repositorioGarcom, telaGarcom, telaMesa, telaProduto);


            TelaPrincipal principal = new TelaPrincipal();


            while (true)
            {
                string opcao = principal.ApresentarMenuPrincipal();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string subMenu = telaMesa.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaMesa.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }
                }
                else if (opcao == "2")
                {
                    string subMenu = telaGarcom.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                }
                else if (opcao == "3")
                {
                    string subMenu = telaProduto.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaProduto.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaProduto.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaProduto.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaProduto.ExcluirRegistro();
                    }
                }
                else if (opcao == "4")
                {
                    string subMenu = telaContas.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaContas.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaContas.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaContas.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaContas.ExcluirRegistro();
                    }

                }



            }
        }
    }
}