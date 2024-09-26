using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Acme.BookStore.EntityFrameworkCore;

public class BookStoreIdentityDbContextFactory :
    IDesignTimeDbContextFactory<BookStoreIdentityDbContext>
{
    public BookStoreIdentityDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        var builder = new DbContextOptionsBuilder<BookStoreIdentityDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AbpOpenIddict"));
        return new BookStoreIdentityDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.BookStore.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

