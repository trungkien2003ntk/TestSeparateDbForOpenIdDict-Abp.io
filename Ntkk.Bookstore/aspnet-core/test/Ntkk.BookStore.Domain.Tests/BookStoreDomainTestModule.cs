using Volo.Abp.Modularity;

namespace Ntkk.BookStore;

[DependsOn(
    typeof(BookStoreDomainModule),
    typeof(BookStoreTestBaseModule)
)]
public class BookStoreDomainTestModule : AbpModule
{

}
