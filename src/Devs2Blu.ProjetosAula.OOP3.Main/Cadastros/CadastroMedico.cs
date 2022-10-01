using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico
    {

        public CadastroMedico()
        {
           
        }

        public void MenuCadastro()
        {
            Int32 opcao = 0;
            do
            {
                Console.WriteLine("--- Cadastro Medicos ---");
                Console.WriteLine("--- 1 Lista de Medicos ---");
                Console.WriteLine("--- 2 Cadastro de Medicos ---");
                Console.WriteLine("--- 3 Alterar Medicos ---");
                Console.WriteLine("----------------------------");
                Console.WriteLine("--- 0 Sair ---");
                Int32.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedico();
                        break;
                    default:
                        break;
                }
            }
            while (!opcao.Equals(MenuEnums.SAIR));
        }
        public void ListarMedico()
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
        public void CadastrarMedico()
        {

        }
        public void AlterarMedico()
        {

        }
        public void ExcluirMedico()
        {

        }
    }
}

