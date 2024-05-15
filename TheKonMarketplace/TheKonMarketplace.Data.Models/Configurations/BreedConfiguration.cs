using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKonMarketplace.Data.Models.Configurations
{
    using DataGenerator;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BreedConfiguration : IEntityTypeConfiguration<Breed>
    {

        public void Configure(EntityTypeBuilder<Breed> builder)
        {
            builder.HasData(DataGenerator.SeedBreeds());
        }
    }
}
