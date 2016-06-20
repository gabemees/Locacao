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
            Cliente = cliente;
            Carro = carro;
        }

        public virtual Carro Carro { get; set; }
        public int CarroId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataLocacao { get; set; }
        public bool Status { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} - {3}", Cliente, Carro, DataLocacao.ToString("dd/MM/yyyy"), Status== true ? "Ocupado": "Disponivel");
        }
    }
}
