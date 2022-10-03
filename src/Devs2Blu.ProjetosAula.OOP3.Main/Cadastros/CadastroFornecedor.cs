using Devs2Blu.ProjetosAula.OOP3.Main.Interface;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {

        }
        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;
             
            Console.WriteLine("--- Cadastro Recepcionistas ---");
            Console.WriteLine("--- 1 Lista de Fornecedores ---");
            Console.WriteLine("--- 2 Cadastro de Fornecedores ---");
            Console.WriteLine("--- 3 Alterar Fornecedores ---");
            Console.WriteLine("--- 4 Excluir Fornecedores ---");
            Console.WriteLine("----------------------------");
            Console.WriteLine("--- 0 Sair ---");

            Console.Write("Escolha:");
            Int32.TryParse(Console.ReadLine(), out opcao);

            Console.Clear();
            return opcao;


        }
        public void Alterar()
        {

            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;
            Console.Write("Informe o Código do Fornecedor que Deseja Alterar: ");
            ListarFornecedorByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);
            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);
            string opcaoAlterar;
            bool alterar = true;
            do
            {
                Console.WriteLine($"Nome: {fornecedor.Nome} - {fornecedor.CGCCPF} - {fornecedor.TipoFornecedor}");
                Console.WriteLine("01 NOME - 02 CPF - 03 CONVENIO - 00 SAIR");
                Console.Write($"Qual Campo Deseja Alterar: ");
                opcaoAlterar = Console.ReadLine();
                switch (opcaoAlterar)
                {
                    case "01":
                        Console.Write("Informe o novo nome: ");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.Write("Informe o novo CPF: ");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "03":
                        Console.Write("Informe o novo TIPO DE FORNECEDOR: ");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;

                }
                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("DADO ALTERADO COM SUCESSO");
                }
            } while (alterar);
            AlterarFornecedor(fornecedor);
        }

        public void Cadastrar()
        {

            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();

            Console.Write("Informe o Nome do fornecedor");
            fornecedor.Nome = Console.ReadLine();

            Console.Write("Informe o CPF do fornecedor");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.Write("Informe o Tipo do Fornecedor");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(438, 837)}");

            CadastrarFornecedor(fornecedor);
        }

        public void Excluir()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();
            int codFornecedor;


            ListarFornecedorByCodeAndName();
            Console.Write("Informe o Fornecedor que Deseja Excluir:\n");
            Int32.TryParse(Console.ReadLine(), out codFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codFornecedor);
            Console.WriteLine($"Fornecedor Excluido: {fornecedor.CodigoFornecedor} {fornecedor.Nome}\n");


            ExcluirFornecedor(fornecedor);
        }

        public void Listar()
        {
            ListarFornecedor();
        }


        //DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//DIVISA//

        private void ListarFornecedor()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Codigo:{fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome:{fornecedor.Nome}");
                Console.WriteLine($"CPF:{fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo/Fornecedor:{fornecedor.TipoFornecedor}");
                Console.WriteLine("------------------------------------");
            }
        }
        private void CadastrarFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Add(fornecedor);
        }
        private void AlterarFornecedor(Fornecedor fornecedor)
        {

        }
        private void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Remove(fornecedor);
        }
        private void ListarFornecedorByCodeAndName()
        {
            Console.Clear();
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {

                Console.WriteLine($"|{fornecedor.CodigoFornecedor} - {fornecedor.Nome}");
            }
        }


    }
}
