using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using DotNet.System.Collections.Generic.Extensions;
using DotNet.System.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace DotNet.Microsoft.Extensions.DependencyInjection.Extensions
{
    /// <summary>
    /// Class containing <see cref="IServiceCollection"/> extensions.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <inheritdoc cref="AddAllSingleton(IServiceCollection, Type)" />
        public static IServiceCollection AddAllSingleton<T>(this IServiceCollection services)
        {
            return services.AddAllSingleton(typeof(T));
        }

        /// <inheritdoc cref="AddAllSingleton(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllSingleton<T>(this IServiceCollection services, Assembly assembly)
        {
            return services.AddAllSingleton(typeof(T), assembly);
        }

        /// <inheritdoc cref="AddAllSingleton(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllSingleton(this IServiceCollection services, Type baseType)
        {
            return services.AddAllSingleton(baseType, Assembly.GetAssembly(baseType));
        }

        /// <inheritdoc cref="AddAll(IServiceCollection, Type, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllSingleton(IServiceCollection, Type, Assembly)"/>.
        /// <code>
        /// services.AddAllSingleton(typeof(IDbService), Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllSingleton(this IServiceCollection services, Type baseType, Assembly assembly)
        {
            return services.AddAll(baseType, assembly, ServiceLifetime.Singleton);
        }

        /// <inheritdoc cref="AddAllScoped(IServiceCollection, Type)" />
        public static IServiceCollection AddAllScoped<T>(this IServiceCollection services)
        {
            return services.AddAllScoped(typeof(T));
        }

        /// <inheritdoc cref="AddAllScoped(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllScoped<T>(this IServiceCollection services, Assembly assembly)
        {
            return services.AddAllScoped(typeof(T), assembly);
        }

        /// <inheritdoc cref="AddAllScoped(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllScoped(this IServiceCollection services, Type baseType)
        {
            return services.AddAllScoped(baseType, Assembly.GetAssembly(baseType));
        }

        /// <inheritdoc cref="AddAll(IServiceCollection, Type, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllScoped(IServiceCollection, Type, Assembly)"/>.
        /// <code>
        /// services.AddAllScoped(typeof(IDbService), Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllScoped(this IServiceCollection services, Type baseType, Assembly assembly)
        {
            return services.AddAll(baseType, assembly, ServiceLifetime.Scoped);
        }

        /// <inheritdoc cref="AddAllTransient(IServiceCollection, Type)" />
        public static IServiceCollection AddAllTransient<T>(this IServiceCollection services)
        {
            return services.AddAllTransient(typeof(T));
        }

        /// <inheritdoc cref="AddAllTransient(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllTransient<T>(this IServiceCollection services, Assembly assembly)
        {
            return services.AddAllTransient(typeof(T), assembly);
        }

        /// <inheritdoc cref="AddAllTransient(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllTransient(this IServiceCollection services, Type baseType)
        {
            return services.AddAllTransient(baseType, Assembly.GetAssembly(baseType));
        }

        /// <inheritdoc cref="AddAll(IServiceCollection, Type, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllTransient(IServiceCollection, Type, Assembly)"/>.
        /// <code>
        /// services.AddAllTransient(typeof(IDbService), Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllTransient(this IServiceCollection services, Type baseType, Assembly assembly)
        {
            return services.AddAll(baseType, assembly, ServiceLifetime.Transient);
        }

        /// <inheritdoc cref="AddAllSingletonSeparately(IServiceCollection, Type)" />
        public static IServiceCollection AddAllSingletonSeparately<T>(this IServiceCollection services)
        {
            return services.AddAllSingletonSeparately(typeof(T));
        }

        /// <inheritdoc cref="AddAllSingletonSeparately(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllSingletonSeparately<T>(this IServiceCollection services, Assembly assembly)
        {
            return services.AddAllSingletonSeparately(typeof(T), assembly);
        }

        /// <inheritdoc cref="AddAllSingletonSeparately(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllSingletonSeparately(this IServiceCollection services, Type baseType)
        {
            return services.AddAllSingletonSeparately(baseType, Assembly.GetAssembly(baseType));
        }

        /// <inheritdoc cref="AddAllSeparately(IServiceCollection, Type, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllSingletonSeparately(IServiceCollection, Type, Assembly)"/>.
        /// <code>
        /// services.AddAllSingletonSeparately(typeof(IDbService), Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllSingletonSeparately(this IServiceCollection services, Type baseType, Assembly assembly)
        {
            return services.AddAllSeparately(baseType, assembly, ServiceLifetime.Singleton);
        }

        /// <inheritdoc cref="AddAllScopedSeparately(IServiceCollection, Type)" />
        public static IServiceCollection AddAllScopedSeparately<T>(this IServiceCollection services)
        {
            return services.AddAllScopedSeparately(typeof(T));
        }

        /// <inheritdoc cref="AddAllScopedSeparately(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllScopedSeparately<T>(this IServiceCollection services, Assembly assembly)
        {
            return services.AddAllScopedSeparately(typeof(T), assembly);
        }

        /// <inheritdoc cref="AddAllScopedSeparately(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllScopedSeparately(this IServiceCollection services, Type baseType)
        {
            return services.AddAllScopedSeparately(baseType, Assembly.GetAssembly(baseType));
        }

        /// <inheritdoc cref="AddAllSeparately(IServiceCollection, Type, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllScopedSeparately(IServiceCollection, Type, Assembly)"/>.
        /// <code>
        /// services.AddAllScopedSeparately(typeof(IDbService), Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllScopedSeparately(this IServiceCollection services, Type baseType, Assembly assembly)
        {
            return services.AddAllSeparately(baseType, assembly, ServiceLifetime.Scoped);
        }

        /// <inheritdoc cref="AddAllTransientSeparately(IServiceCollection, Type)" />
        public static IServiceCollection AddAllTransientSeparately<T>(this IServiceCollection services)
        {
            return services.AddAllTransientSeparately(typeof(T));
        }

        /// <inheritdoc cref="AddAllTransientSeparately(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllTransientSeparately<T>(this IServiceCollection services, Assembly assembly)
        {
            return services.AddAllTransientSeparately(typeof(T), assembly);
        }

        /// <inheritdoc cref="AddAllTransientSeparately(IServiceCollection, Type, Assembly)" />
        public static IServiceCollection AddAllTransientSeparately(this IServiceCollection services, Type baseType)
        {
            return services.AddAllTransientSeparately(baseType, Assembly.GetAssembly(baseType));
        }

        /// <inheritdoc cref="AddAllSeparately(IServiceCollection, Type, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllTransientSeparately(IServiceCollection, Type, Assembly)"/>.
        /// <code>
        /// services.AddAllTransientSeparately(typeof(IDbService), Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllTransientSeparately(this IServiceCollection services, Type baseType, Assembly assembly)
        {
            return services.AddAllSeparately(baseType, assembly, ServiceLifetime.Transient);
        }

        // TODO: Fix all AddAllAndAddAllToReadOnlyDictionary
        /// <inheritdoc cref="AddAllSingletonAndAddAllSingletonToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly)" />
        public static IServiceCollection AddAllSingletonAndAddAllSingletonToReadOnlyDictionary<T, TKey>(this IServiceCollection services, Func<T, TKey> keySelector)
        {
            return services.AddAllSingletonAndAddAllSingletonToReadOnlyDictionary(keySelector, Assembly.GetAssembly(typeof(T)));
        }

        /// <inheritdoc cref="AddAllAndAddAllToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllSingletonAndAddAllSingletonToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly)"/>.
        /// <code>
        /// services.AddAllSingletonAndAddAllSingletonToReadOnlyDictionary{IDbService, string}(service => service.GetType().Name, Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllSingletonAndAddAllSingletonToReadOnlyDictionary<T, TKey>(this IServiceCollection services, Func<T, TKey> keySelector, Assembly assembly)
        {
            return services.AddAllAndAddAllToReadOnlyDictionary(keySelector, assembly, ServiceLifetime.Singleton);
        }

        /// <inheritdoc cref="AddAllScopedAndAddAllScopedToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly)" />
        public static IServiceCollection AddAllScopedAndAddAllScopedToReadOnlyDictionary<T, TKey>(this IServiceCollection services, Func<T, TKey> keySelector)
        {
            return services.AddAllScopedAndAddAllScopedToReadOnlyDictionary(keySelector, Assembly.GetAssembly(typeof(T)));
        }

        /// <inheritdoc cref="AddAllAndAddAllToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllScopedAndAddAllScopedToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly)"/>.
        /// <code>
        /// services.AddAllScopedAndAddAllScopedToReadOnlyDictionary{IDbService, string}(service => service.GetType().Name, Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllScopedAndAddAllScopedToReadOnlyDictionary<T, TKey>(this IServiceCollection services, Func<T, TKey> keySelector, Assembly assembly)
        {
            return services.AddAllAndAddAllToReadOnlyDictionary(keySelector, assembly, ServiceLifetime.Scoped);
        }

        /// <inheritdoc cref="AddAllTransientAndAddAllTransientToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly)" />
        public static IServiceCollection AddAllTransientAndAddAllTransientToReadOnlyDictionary<T, TKey>(this IServiceCollection services, Func<T, TKey> keySelector)
        {
            return services.AddAllTransientAndAddAllTransientToReadOnlyDictionary(keySelector, Assembly.GetAssembly(typeof(T)));
        }

        /// <inheritdoc cref="AddAllAndAddAllToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly, ServiceLifetime)" />
        /// <example>
        /// This is an example, showing how to use <see cref="AddAllTransientAndAddAllTransientToReadOnlyDictionary{T, TKey}(IServiceCollection, Func{T, TKey}, Assembly)"/>.
        /// <code>
        /// services.AddAllTransientAndAddAllTransientToReadOnlyDictionary{IDbService, string}(service => service.GetType().Name, Assembly.GetAssembly(typeof(IDbService)));
        /// </code>
        /// </example>
        public static IServiceCollection AddAllTransientAndAddAllTransientToReadOnlyDictionary<T, TKey>(this IServiceCollection services, Func<T, TKey> keySelector, Assembly assembly)
        {
            return services.AddAllAndAddAllToReadOnlyDictionary(keySelector, assembly, ServiceLifetime.Transient);
        }

        /// <summary>
        /// Add all classes which inherits or implements the base type from the specific assembly.
        /// </summary>
        /// <param name="services">Service collection.</param>
        /// <param name="baseType">Base type.</param>
        /// <param name="assembly"><see cref="Assembly"/> in which to search.</param>
        /// <param name="serviceLifetime"><see cref="ServiceLifetime"/> with which the founded classes to be added.</param>
        /// <returns>Returns <see cref="IServiceCollection"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when services, baseType or assembly is null.</exception>
        /// <exception cref="ArgumentException">Thrown when serviceLifeTime is different from <see cref="ServiceLifetime.Transient"/>, <see cref="ServiceLifetime.Scoped"/> or <see cref="ServiceLifetime.Singleton"/>.</exception>
        private static IServiceCollection AddAll(this IServiceCollection services, Type baseType, Assembly assembly, ServiceLifetime serviceLifetime)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services), "Services cannot be null.");
            }

            if (baseType == null)
            {
                throw new ArgumentNullException(nameof(baseType), "Base type cannot be null.");
            }

            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly), "Assembly cannot be null.");
            }

            assembly.GetExportedTypes()
                .ForEach(t =>
                {
                    if (!t.IsAbstract &&
                        ((baseType.IsInterface && t.ImplementsInterface(baseType)) ||
                            (!baseType.IsInterface && baseType.IsAssignableFrom(t))))
                    {
                        switch (serviceLifetime)
                        {
                            case ServiceLifetime.Singleton:
                                services.AddSingleton(baseType, t);
                                break;

                            case ServiceLifetime.Scoped:
                                services.AddScoped(baseType, t);
                                break;

                            case ServiceLifetime.Transient:
                                services.AddTransient(baseType, t);
                                break;

                            default:
                                throw new ArgumentException($"Unsupported ServiceLifeTime enum value: {serviceLifetime.ToString()}.", nameof(serviceLifetime));
                        }
                    }
                });

            return services;
        }

        /// <summary>
        /// Add all classes which inherits or implements the base type from the specific assembly separately.
        /// </summary>
        /// <param name="services">Service collection.</param>
        /// <param name="baseType">Base type.</param>
        /// <param name="assembly"><see cref="Assembly"/> in which to search.</param>
        /// <param name="serviceLifetime"><see cref="ServiceLifetime"/> with which the founded classes to be added.</param>
        /// <returns>Returns <see cref="IServiceCollection"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when services, baseType or assembly is null.</exception>
        /// <exception cref="ArgumentException">Thrown when serviceLifeTime is different from <see cref="ServiceLifetime.Transient"/>, <see cref="ServiceLifetime.Scoped"/> or <see cref="ServiceLifetime.Singleton"/>.</exception>
        private static IServiceCollection AddAllSeparately(this IServiceCollection services, Type baseType, Assembly assembly, ServiceLifetime serviceLifetime)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services), "Services cannot be null.");
            }

            if (baseType == null)
            {
                throw new ArgumentNullException(nameof(baseType), "Base type cannot be null.");
            }

            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly), "Assembly cannot be null.");
            }

            assembly.GetExportedTypes()
                .ForEach(t =>
                {
                    if (!t.IsAbstract &&
                        ((baseType.IsInterface && t.ImplementsInterface(baseType)) ||
                            (!baseType.IsInterface && baseType.IsAssignableFrom(t))))
                    {
                        switch (serviceLifetime)
                        {
                            case ServiceLifetime.Singleton:
                                services.AddSingleton(t);
                                break;

                            case ServiceLifetime.Scoped:
                                services.AddScoped(t);
                                break;

                            case ServiceLifetime.Transient:
                                services.AddTransient(t);
                                break;

                            default:
                                throw new ArgumentException($"Unsupported ServiceLifeTime enum value: {serviceLifetime.ToString()}.", nameof(serviceLifetime));
                        }
                    }
                });

            return services;
        }

        /// <summary>
        /// Add all classes which inherits or implements the base type from the specific assembly and add read only dictionary containing added classes.
        /// </summary>
        /// <param name="services">Service collection.</param>
        /// <param name="keySelector">Func for dictionary key.</param>
        /// <param name="assembly"><see cref="Assembly"/> in which to search.</param>
        /// <param name="serviceLifetime"><see cref="ServiceLifetime"/> with which the founded classes to be added.</param>
        /// <returns>Returns <see cref="IServiceCollection"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when services, keySelector or assembly is null.</exception>
        /// <exception cref="ArgumentException">Thrown when serviceLifeTime is different from <see cref="ServiceLifetime.Transient"/>, <see cref="ServiceLifetime.Scoped"/> or <see cref="ServiceLifetime.Singleton"/>.</exception>
        private static IServiceCollection AddAllAndAddAllToReadOnlyDictionary<T, TKey>(this IServiceCollection services, Func<T, TKey> keySelector, Assembly assembly, ServiceLifetime serviceLifetime)
        {
            if (keySelector == null)
            {
                throw new ArgumentNullException(nameof(keySelector), "Key selector cannot be null.");
            }

            services.AddAll(typeof(T), assembly, serviceLifetime);

            services.Add(new ServiceDescriptor(typeof(IReadOnlyDictionary<TKey, T>), (serviceProvider) =>
            {
                return new ReadOnlyDictionary<TKey, T>(serviceProvider.GetServices<T>().ToDictionary(keySelector));
            }, serviceLifetime));

            return services;
        }
    }
}