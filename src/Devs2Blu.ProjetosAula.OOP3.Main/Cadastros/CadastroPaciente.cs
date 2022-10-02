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
                Console.WriteLine("----------------------------");
                Console.WriteLine("--- 0 Sair ---");
                Int32.TryParse(Console.ReadLine(), out opcao);

                return opcao;
            }
            
        }

        public void Listar()
        {
            ListarPaciente();
        }

        public void Cadastrar( )
        {
            Paciente paciente = new Paciente();
            CadastrarPaciente((Paciente)paciente);
        }

        public void Alterar( )
        {
            Paciente paciente = new Paciente();
            AlterarPaciente(paciente);
        }

        public void Excluir( )
        {
            Paciente paciente = new Paciente();
            ExcluirPaciente(paciente);
        }
        #endregion FACADE

        private void ListarPaciente()
        {
            Console.Clear();
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

        private void CadastrarPaciente(Paciente pessoa)
        {

        }
        private void AlterarPaciente(Paciente pessoa)
        {

        }
        private void ExcluirPaciente(Paciente pessoa)
        {

        }



    }
}
