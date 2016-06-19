using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo.Locacao.Dominio.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Nome, Cpf, Telefone);
        }
    }
}
