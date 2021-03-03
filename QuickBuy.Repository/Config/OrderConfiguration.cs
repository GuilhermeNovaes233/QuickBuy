﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;

namespace QuickBuy.Repository.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.OrderData)
                .IsRequired();

            builder
                .Property(p => p.DeliveryForecast)
                .IsRequired();

            builder
                .Property(p => p.ZipCode)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(p => p.City)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.State)
                .IsRequired()
                .HasMaxLength(100);


            builder
                .Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.NumberAddress)
                .IsRequired();

            //builder.HasOne(p => p.Usuario); 

            builder.HasOne(p => p.PaymentMethod);
        }
    }
}
