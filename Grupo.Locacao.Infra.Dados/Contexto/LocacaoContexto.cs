using Grupo.Locacao.Dominio.Entidades;
using System.Data.Entity;

namespace Grupo.Locacao.Infra.Dados.Contexto
{
    public class LocacaoContexto : DbContext
    {
        public LocacaoContexto() : base("LocacaoCarroDB")
        {

        }

        public object Cervejas { get; internal set; }
        public DbSet<LocacaoCarro> Locacoes { get; set; }
    }
}