namespace MapperAndBulderPattern
{
    using System;
    using System.Reflection;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Extensions to register all classes related to abstract mapping interfaces.
    /// </summary>
    public static class MappingRegistrationExtensions
    {
        /// <summary>
        /// Adds a transient in <see cref="IServiceCollection"/> for all mappers and builders from <paramref name="assembly"/>.
        /// </summary>
        /// <param name="serviceCollection">The <see cref="IServiceCollection"/> to add the service.</param>
        /// <param name="assembly">Assembly that will be scanned.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public static IServiceCollection AddMapping(
            this IServiceCollection serviceCollection,
            Assembly assembly)
        {
            _ = serviceCollection ?? throw new ArgumentNullException(nameof(serviceCollection));
            _ = assembly ?? throw new ArgumentNullException(nameof(assembly));

            return serviceCollection
                .Scan(scan => scan
                    .FromAssemblies(assembly)
                    .AddClasses(classes => classes.AssignableToAny(
                        typeof(IAsyncBuilder<>),
                        typeof(IAsyncBuilder<,>),
                        typeof(IAsyncBuilder<,,>),
                        typeof(IAsyncBuilder<,,,>),
                        typeof(IAsyncMapper<>),
                        typeof(IAsyncMapper<,>),
                        typeof(IAsyncMapper<,,>),
                        typeof(IAsyncMapper<,,,>),
                        typeof(IBuilder<>),
                        typeof(IBuilder<,>),
                        typeof(IBuilder<,,>),
                        typeof(IBuilder<,,,>),
                        typeof(IMapper<>),
                        typeof(IMapper<,>),
                        typeof(IMapper<,,>),
                        typeof(IMapper<,,,>)))
                    .AsImplementedInterfaces()
                    .WithTransientLifetime())
                .AddTransient<IBuilder, Builder>()
                .AddTransient<IMapper, Mapper>()
                .AddTransient<IAsyncBuilder, AsyncBuilder>()
                .AddTransient<IAsyncMapper, AsyncMapper>();
        }
    }
}
