using Devs2Blu.ProjetosAula.OOP3.Main.Interface;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista:IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }

        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;

            Console.WriteLine("--- Cadastro Recepcionistas ---");
            Console.WriteLine("--- 1 Lista de Recepcionistas ---");
            Console.WriteLine("--- 2 Cadastro de Recepcionistas ---");
            Console.WriteLine("--- 3 Alterar Recepcionistas ---");
            Console.WriteLine("--- 4 Excluir Recepcionistas ---");
            Console.WriteLine("----------------------------");
            Console.WriteLine("--- 0 Sair ---");

            Console.Write("Escolha:");
            Int32.TryParse(Console.ReadLine(), out opcao);

            Console.Clear();
            return opcao;


        }
        #region FACADE
        public void Listar()
        {
            Console.Clear();
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"CODIGO: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"NOME:{recepcionista.Nome}");
                Console.WriteLine($"CPF:{recepcionista.CGCCPF}");
                Console.WriteLine($"SETOR:{recepcionista.Setor}");
                Console.WriteLine("------------------------------------");
            }
        }


        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();

            Console.Write("Informe o Nome do Recepcionista: ");
            recepcionista.Nome = Console.ReadLine();

            Console.Write("Informe o CPF do Recepcionista: ");
            recepcionista.CGCCPF = Console.ReadLine();

            Console.Write("Informe o Setor: ");
            recepcionista.Setor = Console.ReadLine();

            Random rd = new Random();
            recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.CodigoRecepcionista = Int32.Parse($"{recepcionista.Codigo}{rd.Next(438, 837)}");

            CadastrarRecepcionista(recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;
            Console.Write("Informe o Código do Fornecedor que Deseja Alterar: ");
            ListarRecepcionistaByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);
            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);
            string opcaoAlterar;
            bool alterar = true;
            do
            {
                Console.WriteLine($"Nome: {recepcionista.Nome} - {recepcionista.CGCCPF} - {recepcionista.Setor}");
                Console.WriteLine("01 NOME - 02 CPF - 03 SETOR - 00 SAIR");
                Console.Write($"Qual Campo Deseja Alterar: ");
                opcaoAlterar = Console.ReadLine();
                switch (opcaoAlterar)
                {
                    case "01":
                        Console.Write("Informe o novo nome: ");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.Write("Informe o novo CPF: ");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "03":
                        Console.Write("Informe o novo SETOR: ");
                        recepcionista.Nome = Console.ReadLine();
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
            AlterarRecepcionista(recepcionista);
        }

        public void Excluir()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();
            int codRecepcionista;


            ListarRecepcionistaByCodeAndName();
            Console.Write("Informe o Fornecedor que Deseja Excluir:\n");
            Int32.TryParse(Console.ReadLine(), out codRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codRecepcionista);
            Console.WriteLine($"Recepcionista Excluido: {recepcionista.CodigoRecepcionista} {recepcionista.Nome}\n");


            ExcluirRecepcionista(recepcionista);
        }
        #endregion FACADE

        private void CadastrarRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(recepcionista);
        }
        private void AlterarRecepcionista(Recepcionista recepcionista)
        {

        }
        private void ExcluirRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Remove(recepcionista);
        }
        private void ListarRecepcionistaByCodeAndName()
        {
            Console.Clear();
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {

                Console.WriteLine($"|{recepcionista.CodigoRecepcionista} - {recepcionista.Nome}");
            }
            Console.WriteLine("\n");
        }
    }
}

