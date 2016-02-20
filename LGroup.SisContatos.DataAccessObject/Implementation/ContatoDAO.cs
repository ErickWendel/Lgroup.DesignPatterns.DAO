using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.DAO.Model;
using System.Linq.Expressions;
using System.Data.Entity;
namespace LGroup.SisContatos.DataAccessObject.Implementation
{
  public sealed  class ContatoDAO : Contracts.IContatoDAO
    {
      //Quando criamos uma variavel com READONLY
      //Não podemos dar NEW novamente nela (só 1 NEW)
      //por trás dos panos a maquina virtual otimiza
      //o acesso a variaveis somente leitura
      //a variavel vai sempre pro mesmo ENDERECADOR DE MEMORIA
      private readonly Conexao _conexao = new Conexao();
        public void Cadastrar(ContatoModel registro_)
        {
            _conexao.Contato.Add(registro_);
            _conexao.SaveChanges();
        }

        public void Atualizar(ContatoModel registro_)
        {
            _conexao.Entry(registro_).State = EntityState.Modified;
            _conexao.SaveChanges();
        }

        public void Deletar(int codigo_)
        {
            //o FIND olha no cache pra depois ir no banco
            //PERFORMANCE, se nao encontrou retorna nULL
            var registro = _conexao.Contato.Find(codigo_);
            if (registro == null) return;

            _conexao.Contato.Remove(registro);
            _conexao.SaveChanges();

        }

        public IEnumerable<ContatoModel> Listar()
        {
            return _conexao.Contato.ToList();
        }

        public IEnumerable<ContatoModel> Pesquisar(Expression<Func<ContatoModel, bool>> filtro_)
        {
            return _conexao.Contato.Where(filtro_);
        }
    }
}
