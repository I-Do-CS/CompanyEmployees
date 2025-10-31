using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace CompanyEmployees.ContextFactory;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
    public RepositoryContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration["MariaDB:ConnectionString"];
        var serverVersion = new MariaDbServerVersion(configuration["MariaDB:ServerVersion"]);

        var builder = new DbContextOptionsBuilder<RepositoryContext>().UseMySql(
            connectionString,
            serverVersion,
            builder => builder.MigrationsAssembly("CompanyEmployees")
        );

        return new RepositoryContext(builder.Options);
    }
}
