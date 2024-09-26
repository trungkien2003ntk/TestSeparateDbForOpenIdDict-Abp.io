using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Diagnostics;

namespace Ntkk.BookStore.EntityFrameworkCore;

public class BookStoreIdentityDbContextFactory :
    IDesignTimeDbContextFactory<BookStoreIdentityDbContext>
{
    public BookStoreIdentityDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        var builder = new DbContextOptionsBuilder<BookStoreIdentityDbContext>()
            .UseSqlServer(
                configuration.GetConnectionString("AbpOpenIddict"),
                options => options.MigrationsAssembly("BookStore.Identity")
            );
        return new BookStoreIdentityDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../../Ntkk.Bookstore/aspnet-core/src/Ntkk.BookStore.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
