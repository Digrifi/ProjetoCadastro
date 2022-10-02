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
            Console.WriteLine("----------------------------");
            Console.WriteLine("--- 0 Sair ---");
            Int32.TryParse(Console.ReadLine(), out opcao);
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
            Medico medico = new Medico();
            CadastrarMedico((Medico)medico);
        }

        public void Alterar()
        {
            Medico medico = new Medico();
            AlterarMedico((Medico)medico);
        }

        public void Excluir()
        {
            Medico medico = new Medico();
            ExcluirMedico((Medico)medico);
        }
        #endregion FACADE

        private void CadastrarMedico(Medico pessoa)
        {

        }
        private void AlterarMedico(Medico pessoa)
        {

        }
        private void ExcluirMedico(Medico pessoa)
        {

        }
    }
}

