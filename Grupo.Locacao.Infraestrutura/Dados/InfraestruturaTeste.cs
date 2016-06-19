using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grupo.Locacao.Infra.Dados.Contexto;
using Grupo.Locacao.Dominio.Contratos;
using System.Data.Entity;
using Grupo.Locacao.Infraestrutura.Base;
using Grupo.Locacao.Infra.Dados.Repositorio;
using Grupo.Locacao.Dominio.Entidades;
using System.Collections.Generic;

namespace Grupo.Locacao.Infraestrutura
{
    [TestClass]
    public class InfraestruturaTeste
    {
        private LocacaoContexto _contexto;
        private ILocacaoRepositorio _repositorio;

        [TestInitialize]
        public void Initialize()
        {
            Database.SetInitializer(new CriarNovoBancoLocacao<LocacaoContexto>());

            _contexto = new LocacaoContexto();
            _repositorio = new LocacaoRepositorio();

            _contexto.Database.Initialize(true);
            _contexto.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        [TestMethod]
        public void CriarLocacaoNoBancoTeste()
        {
            ILocacaoRepositorio repositorio = new LocacaoRepositorio();

            LocacaoCarro locacao = new LocacaoCarro(new DateTime(2016, 06, 13), true,
                                                    new Cliente("Lucas", "10672228980", "99188736"),
                                                    new Carro("Gol", "VW", "MGT-8899"));

            LocacaoCarro novaLocacao = repositorio.Salvar(locacao);

            Assert.IsTrue(novaLocacao.Id > 0);
        }

        [TestMethod]
        public void AtualizarLocacaoNoBancoTeste()
        {
            LocacaoCarro locacao = _contexto.Locacoes.Find(2);

            locacao.Clientes.Nome = "Richard";
            locacao.Clientes.Cpf = "01247541983";
            locacao.Clientes.Telefone = "99557080";


            _repositorio.Atualizar(locacao);

            LocacaoCarro locacaoAtualizada = _contexto.Locacoes.Find(2);
            Assert.AreEqual("Richard", locacaoAtualizada.Clientes.Nome);
            Assert.AreEqual("01247541983", locacaoAtualizada.Clientes.Cpf);
            Assert.AreEqual("99557080", locacaoAtualizada.Clientes.Telefone);
        }

        [TestMethod]
        public void RetornarLocacaoNoBancoTeste()
        {
            LocacaoCarro locacao = _repositorio.Buscar(1);
            Assert.IsNotNull(locacao);
        }

        [TestMethod]
        public void RetornarTodasAsLocacoesNoBancoTeste()
        {
            List<LocacaoCarro> locacoes = _repositorio.BuscarTodos();
            Assert.AreEqual(10, locacoes.Count);
        }

        [TestMethod]
        public void DeletarLocacaoNoBancoTeste()
        {

            LocacaoCarro locacao = _repositorio.Buscar(1);

            _repositorio.Deletar(locacao);

            LocacaoCarro locacaoDeletado = _contexto.Locacoes.Find(1);
            Assert.IsNull(locacaoDeletado);
        }
    }
}
