using System.Threading.Tasks;

namespace Ntkk.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
