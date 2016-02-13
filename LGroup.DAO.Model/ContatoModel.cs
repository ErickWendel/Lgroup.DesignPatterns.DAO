using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.DAO.Model
{
    public sealed class ContatoModel
    {
        public Int32 Codigo { get; set; }
        public Int32 CodigoSexo { get; set; }
        public Int32 CodigoEstadoCivil { get; set; }
        public String Nome { get; set; }
        public String  Email { get; set; }
        public String Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
