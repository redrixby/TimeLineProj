using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.Sql.Maps
{
    public class FormOfEducationMap : IEntityTypeConfiguration<FormOfEducation>
    {
        public static FormOfEducationMap Instance = new FormOfEducationMap();

        public void Configure(EntityTypeBuilder<FormOfEducation> builder)
        {
            builder.ToTable("FormOfEducation", "dbo");

            builder.HasKey(item => item.Id);

            builder.Property(item => item.Id)
                .HasColumnName("Id_FormOfEducation");

            builder.Property(item => item.Description)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("Description");
        }
    }
}
