using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using LGroup.DAO.Model;

namespace LGroup.SisContatos.DataAccessObject.Mapping
{
    
    public sealed class SexoMapping : EntityTypeConfiguration<SexoModel>
    {
        //CODE FIRST FLUENT API
        //FIZEMOS O MAPEAMENTO VIA CODIGO
        public SexoMapping()
        {
            ToTable("TB_SEXO");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo)
                .HasColumnName("ID_SEXO")
                .HasColumnType("INT");

            Property(x => x.Descricao)
                .HasColumnName("DS_SEXO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(9)
                .IsRequired();


        }
    }
}
