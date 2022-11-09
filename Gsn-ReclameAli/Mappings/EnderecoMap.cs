using Gsn_ReclameAli.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gsn_ReclameAli.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<EnderecoModel>
    {
        public void Configure(EntityTypeBuilder<EnderecoModel> builder)
        {
            builder.HasKey(p => p.EnderecoId);
            builder.HasMany(p => p.Problema)
                   .WithOne(p => p.Endereco)
                   .HasForeignKey(p => p.ProblemaId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

