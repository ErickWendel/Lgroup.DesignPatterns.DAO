using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sumimos o EF para a memoria
//EF é uma FERRAMENTA (FRAMEWORK) de MAPEAMENTO e ACESSO a DADOS
//Desde 2008 é o que tem mais top para acesso a dados
using System.Data.Entity;
using LGroup.DAO.Model;

namespace LGroup.SisContatos.DataAccessObject
{
    //Da mesma forma que existem padroes para tela (UI)
    //Também existem padroes de acesso a dados (banco de dados)
    //Data Access Object, Repository, Active Record, Unit of Work

    //DAL é diferente de DAO
    //DAL é um termo arquitetural (componente de acesso a dados)
    //DAO é o padrao de projeto para fazer acesso a dados
    //Vamos montar uma DAL utiliziando o padrao DAO
    //DAO é im padrao da SUN (2005)
    public sealed class Conexao :
        DbContext
    {

        public Conexao()
            : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='\\vmware-host\Shared Folders\Desktop\DESIGN PATTERNS\SISCONTATOS.mdf';Integrated Security=True;Connect Timeout=30")
        { }

        
        public DbSet<SexoModel> Sexo { get; set; }
        public DbSet<ContatoModel> Contato { get; set; }
        public DbSet<EstadoCivilModel> EstadoCivil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mapping.SexoMapping());
            modelBuilder.Configurations.Add(new Mapping.EstadoCivilMapping());
            modelBuilder.Configurations.Add(new Mapping.ContatoMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
