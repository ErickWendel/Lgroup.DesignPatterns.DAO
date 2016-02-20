using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.SisContatos.DataAccessObject.Contracts.Base
{
    //CUIDADO
    //As interfaces (PAIS DE FILHAS) temos sempre que deixar
    //o Mais generico possiveo, o mais flexivel
    //SEMPRE usar Tipos Genericos (NAO DEIXAR CLASSES CONCRETAS)
    //FIXOS (ESTATICOS) NOME
   public interface IGravacaoDAO<TModel>
    {
       
       void Cadastrar(TModel registro_);
       void Atualizar(TModel registro_);
       void Deletar(Int32 codigo_);
    }
}
