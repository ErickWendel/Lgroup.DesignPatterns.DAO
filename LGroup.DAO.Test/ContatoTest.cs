using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.DAO.Model;
using LGroup.SisContatos.DataAccessObject;
using LGroup.SisContatos.DataAccessObject.Implementation;
//using NUnit.Framework;

//O Visual Studio por padrao só resolve dependencias de primeiro nivek
// 1 DLL chamando outra DLL
//Se a segunda DLL chamar outras DLLS é uma dependencia de segundo Nivel, somos
//obrigados a importar as dlls
//Da segunda pra cima, conforme o VS for reclamando c vai trazendo
namespace LGroup.DAO.Test
{
    [TestFixture]
    public sealed class ContatoTest
    {
        [Test]
        public void Testar_Select_Contato()
        {
            var dadosContato = new ContatoDAO();
            var contatos = dadosContato.Listar();
        }
        [Test]
        public void Testar_Cadastro_Contato()
        {

        }
        [Test]
        public void Testar_Insert_Contato()
        {
            var novoContato = new ContatoModel();
            novoContato.Nome = "Erick Wendel";
            novoContato.Email = "ercik.@erick.com";
            novoContato.Telefone = "12312312312";
            novoContato.DataNascimento = DateTime.Now;
            novoContato.CodigoEstadoCivil = 1;
            novoContato.CodigoSexo = 2;

            var dadosContato = new ContatoDAO();
            dadosContato.Cadastrar(novoContato);

        }
        [Test]
        public void Testar_Update_Contato()
        {
            var dadosContato = new ContatoDAO();
            //single internamente usa o select top 2, caso retorne mais de um valor
            //retorna erro
            var contato = dadosContato.Pesquisar(x => x.Codigo > 0).First();

            contato.Nome = "atualizado Nome 01";
            contato.Email = "atualizar Nome 02";

            dadosContato.Atualizar(contato);

        }
        [Test]
        public void Testar_Delete_Contato()
        {
            var dadosContato = new ContatoDAO();
            var contato = dadosContato.Pesquisar(x => x.Codigo > 0).First();
            if (contato == null) return;
            dadosContato.Deletar(contato.Codigo);
        }

    }
}
