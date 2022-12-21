﻿using bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using bookstore.Domain.Enums;

namespace bookstore.Infrastructure.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasOne(f => f.Endereco).WithOne().IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.Property(f => f.TipoFornecedor)
                .HasConversion(prop => prop.ToString(),
                prop => (TipoFornecedor)Enum.Parse(typeof(TipoFornecedor), prop));

        }
    }
}
