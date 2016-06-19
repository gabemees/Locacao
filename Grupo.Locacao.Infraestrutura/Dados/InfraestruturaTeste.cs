using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grupo.Locacao.Infra.Dados.Contexto;
using Grupo.Locacao.Dominio.Contratos;
using System.Data.Entity;
using Grupo.Locacao.Infraestrutura.Base;
using Grupo.Locacao.Infra.Dados.Repositorio;
using Grupo.Locacao.Dominio.Entidades;

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


    }
}
