using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grupo.Locacao.Dominio.Entidades;

namespace Grupo.Locacao.Dominio.Teste
{
    [TestClass]
    public class DominioTest
    {
        [TestMethod]
        public void CriarLocacaoTeste()
        {
            LocacaoCarro locacao = new LocacaoCarro(new DateTime(2016, 06, 13), true, 
                                                    new Cliente("Lucas", "10672228980", "99188736"), 
                                                    new Carro("Gol", "VW", "MGT-8899"));

            Assert.AreEqual("Lucas - 10672228980 - 99188736 - Gol - VW - MGT-8899, 13/06/2016, Opucado", locacao.ToString());
        }
    }
}
