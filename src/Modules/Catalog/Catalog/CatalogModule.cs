using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogModule;
public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services,IConfiguration confriguation)
    {
        return services;
    }
}