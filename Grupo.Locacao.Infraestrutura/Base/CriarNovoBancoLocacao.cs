using Grupo.Locacao.Dominio.Entidades;
using Grupo.Locacao.Infra.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo.Locacao.Infraestrutura.Base
{
    public class CriarNovoBancoLocacao<T> : DropCreateDatabaseAlways<LocacaoContexto>
    {
        protected override void Seed(LocacaoContexto contexto)
        {
            for (int i = 0; i < 10; i++)
            {

                LocacaoCarro locacoes = new LocacaoCarro(new DateTime(2016, 06, 13-i), true,
                                                    new Cliente("Lucas", "10672228980", "99188736"),
                                                    new Carro("Gol", "VW", "MGT-8899"));

                contexto.Locacoes.Add(locacoes);

                contexto.SaveChanges();
                base.Seed(contexto);
            }
        }
    }
}
