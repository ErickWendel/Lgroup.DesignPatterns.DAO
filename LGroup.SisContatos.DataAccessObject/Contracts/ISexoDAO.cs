using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;
using LGroup.DAO.Model;

namespace LGroup.SisContatos.DataAccessObject.Contracts
{
    //Para cada tabela temos sempre que criar 2 arquivos
    //1 Interface  = Contrato
    //1 Classe = Unidade (Implementacao)
    //Aplicamos a Segregacao
    //TRouxemos somente comandos de leitura
    public interface ISexoDAO : Base.ILeituraDAO<SexoModel>
    {
    }
}
