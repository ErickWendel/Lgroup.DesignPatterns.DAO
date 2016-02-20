using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity.ModelConfiguration;
using LGroup.DAO.Model;

namespace LGroup.SisContatos.DataAccessObject.Mapping
{
   public class EstadoCivilMapping : EntityTypeConfiguration<EstadoCivilModel>
    {
       public EstadoCivilMapping()
       {
           ToTable("TB_ESTADO_CIVIL")
               .HasKey(x => x.Codigo);

           Property(x => x.Codigo)
                .HasColumnName("ID_ESTADO_CIVIL")
                .HasColumnType("INT");

           Property(x => x.Descricao)
                .HasColumnName("DS_ESTADO_CIVIL")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
       }
    }
}
