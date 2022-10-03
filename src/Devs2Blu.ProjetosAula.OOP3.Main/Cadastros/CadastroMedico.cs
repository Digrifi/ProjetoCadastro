using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interface;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
        {
        }

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.WriteLine("--- Cadastro Medicos ---");
            Console.WriteLine("--- 1 Lista de Medicos ---");
            Console.WriteLine("--- 2 Cadastro de Medicos ---");
            Console.WriteLine("--- 3 Alterar Medicos ---");
            Console.WriteLine("--- 4 Excluir Medicos ---");
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
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Codigo: {medico.CodigoMedico}");
                Console.WriteLine($"Nome:{medico.Nome}");
                Console.WriteLine($"CPF:{medico.CGCCPF}");
                Console.WriteLine($"CRM:{medico.CRM}");
                Console.WriteLine($"Especialidade:{medico.Especialidade}");
                Console.WriteLine("------------------------------------");
            }
        }


        public void Cadastrar()
        {
            Console.Clear();
            Medico medico = new Medico();

            Console.Write("Informe o Nome do medico: ");
            medico.Nome = Console.ReadLine();

            Console.Write("Informe o CPF do medico: ");
            medico.CGCCPF = Console.ReadLine();

            Console.Write("Informe a Especialidade do medico: ");
            medico.Especialidade = Console.ReadLine();

            Console.Write("Informe a CRM do medico: ");
            int newCrm;
            Int32.TryParse(Console.ReadLine(),out newCrm);

            medico.CRM = newCrm;


            Random rd = new Random();
            medico.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            medico.CodigoMedico = Int32.Parse($"{medico.Codigo}{rd.Next(438, 837)}");

            CadastrarMedico(medico);
        }

        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;
            Console.Write("Informe o Código do Médico que Deseja Alterar: ");
            ListarMedicoByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);
            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);
            string opcaoAlterar;
            bool alterar = true;
            do
            {
                Console.WriteLine($"Nome: {medico.Nome} - {medico.CGCCPF} - {medico.Especialidade}");
                Console.WriteLine("01 NOME - 02 CPF - 03 ESPECIALIDADE - 00 SAIR");
                Console.Write($"Qual Campo Deseja Alterar: ");
                opcaoAlterar = Console.ReadLine();
                switch (opcaoAlterar)
                {
                    case "01":
                        Console.Write("Informe o novo nome");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.Write("Informe o novo CPF");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "03":
                        Console.Write("Informe a nova especialidade");
                        medico.Nome = Console.ReadLine();
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
            AlterarMedico(medico);
        }

        public void Excluir()
        {
            Console.Clear();
            Medico medico = new Medico();
            int codMedico;


            ListarMedicoByCodeAndName();
            Console.WriteLine("Informe o Paciente que Deseja Excluir:\n");
            Int32.TryParse(Console.ReadLine(), out codMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codMedico);
            Console.WriteLine($"Paciente Excluido: {medico.CodigoMedico}\n");


            ExcluirMedico(medico);
        }
        #endregion FACADE

        private void CadastrarMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Add(medico);
        }
        private void AlterarMedico(Medico medico)
        {

        }
        private void ExcluirMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Remove(medico);
        }
        private void ListarMedicoByCodeAndName()
        {
            Console.Clear();
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {

                Console.WriteLine($"|{medico.CodigoMedico} - {medico.Nome}");
            }
            Console.WriteLine("\n");
        }
    }
}

