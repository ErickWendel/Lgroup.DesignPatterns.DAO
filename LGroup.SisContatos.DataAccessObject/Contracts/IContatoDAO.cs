using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.DAO.Model;
namespace LGroup.SisContatos.DataAccessObject.Contracts
{
    public interface IContatoDAO : Base.IGravacaoDAO<ContatoModel>,
                                   Base.ILeituraDAO<ContatoModel>,
                                   Base.IPesquisaDAO<ContatoModel>
    {
    }
}
