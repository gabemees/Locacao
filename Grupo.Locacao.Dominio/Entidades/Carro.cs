using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo.Locacao.Dominio.Entidades
{
    public class Carro
    {
        public Carro()
        {
        }

        public Carro(string nome, string marca, string placa)
        {
            Nome = nome;
            Marca = marca;
            Placa = placa;
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Nome, Marca, Placa);
        }
    }
}
