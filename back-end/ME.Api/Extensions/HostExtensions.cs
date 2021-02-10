using ME.Business.Logic.Helpers;
using ME.Data.Access.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ME.Api.Extensions
{
    public static class HostExtensions
    {
        public static IHost EnsureDatabaseIntegrity(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            EnsureDatabaseCreated(scope);
            EnsureSeedDataCreated(scope);

            return host;
        }

        #region private methods
        private static void EnsureDatabaseCreated(IServiceScope scope)
        {
            scope.ServiceProvider.GetService<MeddelandeContext>().Database.EnsureCreated();
        }

        private static void EnsureSeedDataCreated(IServiceScope scope)
        {
            scope.ServiceProvider.GetService<DatabaseInitializer>().Initialize();
        }
        #endregion
    }
}
