using Grupo.Locacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo.Locacao.Aplicacao
{
   public interface  ILocacaoAplicacao
    {
        LocacaoCarro CriarLocacao(LocacaoCarro locacao);

        LocacaoCarro Buscar(int id);

        List<LocacaoCarro> BuscasTodosAplicacao();

        void Deletar(LocacaoCarro locacao);

        LocacaoCarro Atualizar(LocacaoCarro locacao);
    }
}
