using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ValueObject;
using System;

namespace QuickBuy.Repository.Config
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(f => f.Id);
            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(f => f.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
