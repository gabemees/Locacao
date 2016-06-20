using Grupo.Locacao.Dominio.Entidades;
using System.Data.Entity;

namespace Grupo.Locacao.Infra.Dados.Contexto
{
    public class LocacaoContexto : DbContext
    {
        public LocacaoContexto() : base("LocacaoCarroDB")
        {

        }

        public Carro Carro { get;  set; }
        public Cliente Cliente { get;  set; }
        public DbSet<LocacaoCarro> Locacoes { get; set; }
    }
}