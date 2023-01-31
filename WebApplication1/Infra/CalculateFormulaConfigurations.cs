using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using WebApplication1.Domain;

namespace WebApplication1.Infra
{
    public class CalculateFormulaConfigurations : IEntityTypeConfiguration<CalculateFormula>
    {
        public void Configure(EntityTypeBuilder<CalculateFormula> builder)
        {
            builder.ToTable("CalculateFormula");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Options)
               .HasConversion(v => JsonConvert.SerializeObject(v),
                              v => JsonConvert.DeserializeObject<Options>(v))
               .IsRequired();
        }
    }
}
