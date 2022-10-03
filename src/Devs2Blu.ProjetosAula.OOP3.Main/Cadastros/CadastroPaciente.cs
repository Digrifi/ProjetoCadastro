using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAula.OOP3.Main.Interface;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {

        }

        #region FACADE
        public Int32 MenuCadastro()
        {

            {
                
                Int32 opcao = 0;
                Console.WriteLine("--- Cadastro Pacientes ---");
                Console.WriteLine("--- 1 Lista de Pacientes ---");
                Console.WriteLine("--- 2 Cadastro de Pacientes ---");
                Console.WriteLine("--- 3 Alterar Pacientes ---");
                Console.WriteLine("--- 4 Excluir Pacientes ---");
                Console.WriteLine("----------------------------");
                Console.WriteLine("--- 0 Sair ---");

                Console.Write("Escolha:");
                Int32.TryParse(Console.ReadLine(), out opcao);

                Console.Clear();
                return opcao;
            }

        }

        public void Listar()
        {
            ListarPaciente();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Paciente paciente = new Paciente();

            Console.Write("Informe o Nome do paciente: ");
            paciente.Nome = Console.ReadLine();

            Console.Write("Informe o CPF do paciente: ");
            paciente.CGCCPF = Console.ReadLine();

            Console.Write("Informe o Convênio do paciente: ");
            paciente.Convenio = Console.ReadLine();

            Random rd = new Random();
            paciente.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            paciente.CodigoPaciente = Int32.Parse($"{paciente.Codigo}{rd.Next(438, 837)}");

            CadastrarPaciente(paciente);
        }

        public void Alterar()
        {
            Console.Clear();
            Paciente paciente;
            int codigoPaciente;
            Console.Write("Informe o Código do Paciente que Deseja Alterar: ");
            ListarPacienteByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoPaciente);
            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPaciente);
            string opcaoAlterar;
            bool alterar = true;
            do
            {
                Console.WriteLine($"Nome: {paciente.Nome} - {paciente.CGCCPF} - {paciente.Convenio}");
                Console.WriteLine("01 NOME - 02 CPF - 03 CONVENIO - 00 SAIR");
                Console.Write($"Qual Campo Deseja Alterar: ");
                opcaoAlterar = Console.ReadLine();
                switch (opcaoAlterar)
                {
                    case "01":
                        Console.Write("Informe um novo nome");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.Write("Informe um novo CPF");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "03":
                        Console.Write("Informe um novo CONVENIO");
                        paciente.Nome = Console.ReadLine();
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
            AlterarPaciente(paciente);
        }

        public void Excluir()
        { 
            Console.Clear();
            Paciente paciente = new Paciente();
            int codPaciente;

            
            ListarPacienteByCodeAndName();
            Console.WriteLine("Informe o Paciente que Deseja Excluir:\n");
            Int32.TryParse(Console.ReadLine(), out codPaciente);

            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codPaciente);
            Console.WriteLine($"Paciente Excluido: {paciente.CodigoPaciente}\n");


            ExcluirPaciente(paciente);
        }
        #endregion FACADE

        private void ListarPaciente()
        {
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Codigo:{paciente.CodigoPaciente}");
                Console.WriteLine($"Nome:{paciente.Nome}");
                Console.WriteLine($"CPF:{paciente.CGCCPF}");
                Console.WriteLine($"Convenio:{paciente.Convenio}");
                Console.WriteLine("------------------------------------");
            }
        }

        private void CadastrarPaciente(Paciente paciente)
        {
            Program.Mock.ListaPacientes.Add(paciente);
        }
        private void AlterarPaciente(Paciente paciente)
        {
            
        }
        private void ExcluirPaciente(Paciente paciente)
        {
            Program.Mock.ListaPacientes.Remove(paciente);
        }
        private void ListarPacienteByCodeAndName()
        {
            Console.Clear();
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {

                Console.WriteLine($"|{paciente.CodigoPaciente} - {paciente.Nome}");
            }
            Console.WriteLine("\n");
        }


    }
}
