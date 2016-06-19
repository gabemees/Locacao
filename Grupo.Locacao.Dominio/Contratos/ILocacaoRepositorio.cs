using Grupo.Locacao.Dominio.Entidades;
using System.Collections.Generic;

namespace Grupo.Locacao.Dominio.Contratos
{
    public interface ILocacaoRepositorio
    {
        LocacaoCarro Salvar(LocacaoCarro locacao);

        LocacaoCarro Buscar(int id);

        List<LocacaoCarro> BuscarTodos();

        LocacaoCarro Atualizar(LocacaoCarro locacao);

        void Deletar(LocacaoCarro locacao);
    }
}