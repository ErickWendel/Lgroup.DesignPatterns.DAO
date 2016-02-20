using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity.ModelConfiguration;
using LGroup.DAO.Model;

namespace LGroup.SisContatos.DataAccessObject.Mapping
{
   public sealed  class ContatoMapping : EntityTypeConfiguration<ContatoModel>
    {
       public ContatoMapping()
       {
           ToTable("TB_CONTATO")
              .HasKey(x => x.Codigo);

           Property(x => x.Codigo)
                .HasColumnName("ID_CONTATO")
                .HasColumnType("INT")
                .IsRequired();

           
           Property(x => x.CodigoSexo)
                .HasColumnName("ID_SEXO")
                .HasColumnType("INT")
                .IsRequired();


           Property(x => x.CodigoEstadoCivil)
                           .HasColumnName("ID_ESTADO_CIVIL")
                           .HasColumnType("INT")
                           .IsRequired();
           

           Property(x => x.Nome)
                .HasColumnName("NM_CONTATO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();


           Property(x => x.Email)
                .HasColumnName("DS_EMAIL")
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired();

           Property(x => x.Telefone)
                .HasColumnName("NR_TELEFONE")
                .HasColumnType("VARCHAR")
                .HasMaxLength(15)
                .IsRequired();

           Property(x => x.DataNascimento)
                .HasColumnName("DT_NASCIMENTO")
                .HasColumnType("DATE")
                .IsRequired();

           //FOREIGN KEYS
           HasRequired(x => x.Sexo)
               .WithMany()
               .HasForeignKey(x => x.CodigoSexo);

           HasRequired(x => x.EstadoCivil)
               .WithMany()
               .HasForeignKey(x => x.CodigoEstadoCivil);
       }
    }
}
