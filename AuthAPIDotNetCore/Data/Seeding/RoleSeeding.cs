using AuthAPIDotNetCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthAPIDotNetCore.Data.Seeding
{
    public class RoleSeeding : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            //To Change TableName
            //builder.ToTable(nameof(ApplicationRole));

            builder.HasData(new ApplicationRole()
            {
                Id = Guid.Parse("50d0df3b-1986-4198-a76a-555cd9b6e208"),
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new ApplicationRole()
            {
                Id = Guid.Parse("36474c55-fb38-4784-a653-4401eaa5d43d"),
                Name = "User",
                NormalizedName = "USER"
            });
        }
    }
}
