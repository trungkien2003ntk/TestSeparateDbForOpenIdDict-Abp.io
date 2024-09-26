using Volo.Abp.Modularity;

namespace Ntkk.BookStore;

public abstract class BookStoreApplicationTestBase<TStartupModule> : BookStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
