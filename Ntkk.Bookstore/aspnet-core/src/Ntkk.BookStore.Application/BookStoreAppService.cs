using System;
using System.Collections.Generic;
using System.Text;
using Ntkk.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Ntkk.BookStore;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
