using Grupo.Locacao.Dominio.Contratos;
using Grupo.Locacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo.Locacao.Aplicacao
{
   public class LocacaoAplicacao : ILocacaoAplicacao
    {
        private ILocacaoRepositorio _repositorio;
        public LocacaoAplicacao(ILocacaoRepositorio repositorio)
        {
           
            _repositorio = repositorio;
       
        }
        public LocacaoCarro Buscar(int id)
        {
            return _repositorio.Buscar(id);
        }

        public List<LocacaoCarro> BuscasTodosAplicacao()
        {
            return _repositorio.BuscarTodos();
        }

        public LocacaoCarro CriarLocacao(LocacaoCarro locacao)
        {

            //Verificar se cliente já não existe


            //Consulta Serasa
            //ISerasaRepositorio serasa = new SerasaRepositorio();


            //Salvar no banco                   
            LocacaoCarro novaLocacao = _repositorio.Salvar(locacao);

                    //enviar email de confirmação

                

                    return novaLocacao;
           
        }

        public void Deletar(LocacaoCarro locacao)
        {
            _repositorio.Deletar(locacao);

        }


       public LocacaoCarro Atualizar(LocacaoCarro locacao)
        {
            _repositorio.Atualizar(locacao);
            return locacao;
        }
    }
}
