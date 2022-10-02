using Devs2Blu.ProjetosAula.OOP3.Main.Interface;
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
            Console.WriteLine("----------------------------");
            Console.WriteLine("--- 0 Sair ---");
            Int32.TryParse(Console.ReadLine(), out opcao);
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
            Recepcionista recepcionista = new Recepcionista();
            CadastrarRecepcionista((Recepcionista)recepcionista);
        }

        public void Alterar()
        {
            Recepcionista recepcionista = new Recepcionista();
            AlterarRecepcionista((Recepcionista)recepcionista);
        }

        public void Excluir()
        {
            Recepcionista recepcionista = new Recepcionista();
            ExcluirRecepcionista((Recepcionista)recepcionista);
        }
        #endregion FACADE

        private void CadastrarRecepcionista(Recepcionista pessoa)
        {

        }
        private void AlterarRecepcionista(Recepcionista pessoa)
        {

        }
        private void ExcluirRecepcionista(Recepcionista pessoa)
        {

        }
    }
}

