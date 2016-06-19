using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo.Locacao.Dominio.Entidades
{
    public class LocacaoCarro
    {
        public LocacaoCarro()
        {
        }

        public LocacaoCarro(DateTime data, bool status, Cliente cliente, Carro carro)
        {
            DataLocacao = data;
            Status = status;
            Clientes = cliente;
            Carros = carro;
        }

        public Carro Carros { get; set; }
        public Cliente Clientes { get; set; }
        public DateTime DataLocacao { get; set; }
        public bool Status { get; set; }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} - {3}", Clientes, Carros, DataLocacao.ToString("dd/MM/yyyy"), Status== true ? "Ocupado": "Disponivel");
        }
    }
}
