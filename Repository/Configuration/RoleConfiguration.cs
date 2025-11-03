using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "68102578-642e-47d9-8496-0e07e09a448f",
                Name = "Manager",
                NormalizedName = "MANAGER",
            },
            new IdentityRole
            {
                Id = "f1b2f16a-e323-4c89-a68e-8eb8165b32a2",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
            }
        );
    }
}
