using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Interface;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    class Program
    {
        public static Mocks Mock { get; set; }

        static void Main(string[] args)
        {
            Int32 opcao = 0, opcaoMenuCadastro = 0;
            Mock = new Mocks();
            IMenuCadastro menuCadastros = new CadastroPaciente();
            do
            {

                if (opcaoMenuCadastro.Equals((int)MenuEnums.SAIR))
                {

                    Console.WriteLine("--- Sistema de Gerenciamento de Clínicas ---");
                    Console.WriteLine("--- 10 Cadastro de Pacientes ---");
                    Console.WriteLine("--- 20 Cadastro de Médicos ---");
                    Console.WriteLine("--- 30 Cadastro de Recepcionistas ---");
                    Console.WriteLine("--- 40 Cadastro de Fornecedores ---");
                    Console.WriteLine("--- 50 Agenda ---");
                    Console.WriteLine("--- 60 Prontuário ---");
                    Console.WriteLine("--- 70 Financeiro ---");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("--- 0 Sair ---");
                    Int32.TryParse(Console.ReadLine(), out opcao);

                }

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        menuCadastros = new CadastroPaciente();
                        opcaoMenuCadastro = menuCadastros.MenuCadastro();
                        break;

                    case (int)MenuEnums.CAD_MED:
                        menuCadastros = new CadastroMedico(); 
                        opcaoMenuCadastro= menuCadastros.MenuCadastro();
                        break;

                    default:
                        opcaoMenuCadastro = 0;
                        break;
                }

                switch (opcaoMenuCadastro)
                {
                    case (int)MenuEnums.LISTAR:
                        menuCadastros.Listar();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        menuCadastros.Cadastrar();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        menuCadastros.Alterar();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        menuCadastros.Excluir();
                        break;
                    default:
                        opcaoMenuCadastro = 0;
                        break;
                }

            } while (!opcao.Equals(MenuEnums.SAIR));


        }
        public static void ViewListPacientes()
        {
            Console.Clear();
            foreach (Paciente paciente in Mock.ListaPacientes)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Nome:{paciente.CodigoPaciente}");
                Console.WriteLine($"CPF:{paciente.Nome}");
                Console.WriteLine($"Nome:{paciente.CGCCPF}");
                Console.WriteLine($"Nome:{paciente.Convenio}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
}




