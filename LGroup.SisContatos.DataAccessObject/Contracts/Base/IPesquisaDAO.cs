using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.SisContatos.DataAccessObject.Contracts.Base
{
   public interface IPesquisaDAO<TModel>
    {
       //Não é legal, criar varias variacoes variadas
       //de pesquisar, SOA MEIO GAMBI (BOTAS)
       //PesquisarPorCodigo, PEsquisarPorData
       //Temos que criar 1 único pesquisar genérico
       //que atenda qualquer tipo de pesquisa na tabela
       //Codigo, Nome, Datas
       //1 -> Expression é para receber a lambda, x => x
       //2 -> Func é o nome da classe que vamos pesquisar
       //BOOLEAN -> Pq é um filtro, se a condição for TRUE
       //Ele traz o registro
       IEnumerable<TModel> Pesquisar(Expression<Func<TModel, Boolean>> filtro_);

    }
}
