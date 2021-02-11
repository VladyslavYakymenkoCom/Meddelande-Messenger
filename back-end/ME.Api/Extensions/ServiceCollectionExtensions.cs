using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ME.Business.Logic.Abstraction.Scopes.Chats;
using ME.Business.Logic.Abstraction.Scopes.Messages;
using ME.Business.Logic.Abstraction.Scopes.Users;
using ME.Business.Logic.Helpers;
using ME.Business.Logic.Scopes.Chats;
using ME.Business.Logic.Scopes.Messages;
using ME.Business.Logic.Scopes.Users;
using ME.Data.Access.Abstractions.Repositories;
using ME.Data.Access.Abstractions.UnitOfWork;
using ME.Data.Access.Context;
using ME.Data.Access.Repositories;
using ME.Data.Access.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace ME.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        #region Private fields
        private const string DatabaseConnection = "MsSQLConnection";
        private static IConfiguration _configuration;
        #endregion

        public static void Init(this IServiceCollection services, IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static void AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<MeddelandeContext>(options => 
                options.UseSqlServer(_configuration.GetConnectionString(DatabaseConnection)));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IChatRepository, ChatRepository>();
        }

        public static void AddUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<DatabaseInitializer>();
        }

        public static void AddScopes(this IServiceCollection services)
        {
            services.AddTransient<IUserScope, UserScope>();
            services.AddTransient<IMessageScope, MessageScope>();
            services.AddTransient<IChatScope, ChatScope>();
        }
    }
}
