using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seeds
{
    public class ProductSeed:IEntityTypeConfiguration<Product>
    {
        private readonly int[] ids;
        public ProductSeed(int[] ids)
        {
            this.ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Pilot Kalem",
                    Price = 12.50m,
                    Stock = 100,
                    CategoryId = ids[0]
                },
                new Product
                {
                    Id = 2,
                    Name = "Kurşun Kalem",
                    Price = 40.50m,
                    Stock = 200,
                    CategoryId = ids[0]
                }, new Product
                {
                    Id = 3,
                    Name = "Tükenmez Kalem",
                    Price = 500m,
                    Stock = 300,
                    CategoryId = ids[0]
                }, 
                new Product
                {
                    Id = 4,
                    Name = "Küçük Boy Defter",
                    Price = 500m,
                    Stock = 300,
                    CategoryId = ids[1]
                }, new Product
                {
                    Id = 5,
                    Name = "Orta Boy Defter",
                    Price = 500m,
                    Stock = 300,
                    CategoryId = ids[1]
                }, new Product
                {
                    Id = 6,
                    Name = "Büyük Boy Defter",
                    Price = 500m,
                    Stock = 300,
                    CategoryId = ids[1]
                }
                );
        }
    }
}
