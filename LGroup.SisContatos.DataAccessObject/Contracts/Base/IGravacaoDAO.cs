using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.SisContatos.DataAccessObject.Contracts.Base
{
   public interface IGravacaoDAO
    {
       void Cadastrar();
       void Atualizar();
       void Deletar();
    }
}
