using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks 
    { 
        public  List<Paciente> ListaPacientes { get; set; }  
        public  List<Medico> ListaMedicos { get; set; }
        public  List<Recepcionista> ListaRecepcionistas { get; set; }
        public  List<Fornecedor> ListaFornecedores { get; set; }

        
        public Mocks()
        {

            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }
        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaRecepcionistas();
            CargaFornecedor();
        }
        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}",$"{i}23{i}56{i}891{i}","Unimed"); 
                ListaPacientes.Add(paciente);
            }
        }
        public void CargaMedicos()
        {
            Random rd = new Random();
            String[] especialidades = { "Clínica Geral", "Neurologista", "Ginecologista","Pediatra" };
            for (int i = 0; i < 10; i++)
            {
                Medico medico = new Medico(i, $"Medico {i}", $"{i + rd.Next(0,5)}23{i + rd.Next(0, 5)}56{i + rd.Next(0, 5)}891{i + rd.Next(0, 5)}",rd.Next(321,789), especialidades[rd.Next(0,3)]);
                ListaMedicos.Add(medico);
            }

        }
        public void CargaRecepcionistas()
        {
            Random rd = new Random();
            String[] setor = { "Secretaria", "Entregas", "Documentação", "Atendimento" };
            for (int i = 0; i < 10; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista{i}",$"{i + rd.Next(0,5)}50{i + rd.Next(0,5)}60{i + rd.Next(0,5)}70{i + rd.Next(0, 5)}80", setor[rd.Next(0,3)]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }
        public void CargaFornecedor()
        {
            Random rd = new Random();
            String[] tipofornecedor = { "Alimentício", "Medicinal", "Caridade", "Material" };
            for (int i = 0; i < 10; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor{i}", $"{i + rd.Next(0, 5)}40{i + rd.Next(0, 5)}60{i + rd.Next(0, 5)}90{i + rd.Next(0, 5)}20", tipofornecedor[rd.Next(0, 3)]);
                ListaFornecedores.Add(fornecedor);
            }

        }
    }
}
