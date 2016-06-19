using System;
using System.Collections.Generic;
using Grupo.Locacao.Dominio.Contratos;
using Grupo.Locacao.Dominio.Entidades;
using Grupo.Locacao.Infra.Dados.Contexto;
using System.Linq;

namespace Grupo.Locacao.Infra.Dados.Repositorio
{
    public class LocacaoRepositorio : ILocacaoRepositorio
    {
        private LocacaoContexto _contexto;

        public LocacaoRepositorio()
        {
            _contexto = new LocacaoContexto();
        }

        public LocacaoCarro Atualizar(LocacaoCarro locacao)
        {
            var entry = _contexto.Entry<LocacaoCarro>(locacao);
            entry.State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();
            return locacao;
        }

        public LocacaoCarro Buscar(int id)
        {
            return _contexto.Locacoes.Find(id);
        }

        public List<LocacaoCarro> BuscarTodos()
        {
            return _contexto.Locacoes.ToList();
        }

        public void Deletar(LocacaoCarro locacao)
        {
            var entry = _contexto.Entry<LocacaoCarro>(locacao);
            entry.State = System.Data.Entity.EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public LocacaoCarro Salvar(LocacaoCarro locacao)
        {
            var novaLocacao = _contexto.Locacoes.Add(locacao);
            _contexto.SaveChanges();
            return novaLocacao;
        }
    }
}