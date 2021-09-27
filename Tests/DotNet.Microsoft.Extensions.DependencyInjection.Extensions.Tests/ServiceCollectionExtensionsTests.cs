using System;
using System.Linq;
using DotNet.Microsoft.Extensions.DependencyInjection.Extensions.Tests.Interfaces;
using DotNet.Microsoft.Extensions.DependencyInjection.Extensions.Tests.Services;
using DotNet.Microsoft.Extensions.DependencyInjection.Extensions.Tests.Services.BaseServices;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace DotNet.Microsoft.Extensions.DependencyInjection.Extensions.Tests
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void AddAllSingleton_Method_Should_Add_Two_Services_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllSingleton<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Equal(2, serviceScope.ServiceProvider.GetServices<IService>().Count());
            }
        }

        [Fact]
        public void AddAllSingleton_Method_Should_Add_FileService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllSingleton<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s is FileService));
            }
        }

        [Fact]
        public void AddAllSingleton_Method_Should_Add_ImageService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllSingleton<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s is ImageService));
            }
        }

        [Fact]
        public void AddAllSingleton_Method_Shouldn_t_Add_BaseService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllSingleton<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Null(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s.GetType() == typeof(BaseService)));
            }
        }

        [Fact]
        public void AddAllScoped_Method_Should_Add_Two_Services_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllScoped<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Equal(2, serviceScope.ServiceProvider.GetServices<IService>().Count());
            }
        }

        [Fact]
        public void AddAllScoped_Method_Should_Add_FileService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllScoped<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s is FileService));
            }
        }

        [Fact]
        public void AddAllScoped_Method_Should_Add_ImageService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllScoped<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s is ImageService));
            }
        }

        [Fact]
        public void AddAllScoped_Method_Shouldn_t_Add_BaseService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllScoped<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Null(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s.GetType() == typeof(BaseService)));
            }
        }

        [Fact]
        public void AddAllTransient_Method_Should_Add_Two_Services_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllTransient<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Equal(2, serviceScope.ServiceProvider.GetServices<IService>().Count());
            }
        }

        [Fact]
        public void AddAllTransient_Method_Should_Add_FileService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllTransient<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s is FileService));
            }
        }

        [Fact]
        public void AddAllTransient_Method_Should_Add_ImageService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllTransient<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s is ImageService));
            }
        }

        [Fact]
        public void AddAllTransient_Method_Shouldn_t_Add_BaseService_To_The_Collection_Of_IServices_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllTransient<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Null(serviceScope.ServiceProvider.GetServices<IService>().FirstOrDefault(s => s.GetType() == typeof(BaseService)));
            }
        }

        [Fact]
        public void AddAllSingletonSeparately_Method_Should_Add_FileService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllSingletonSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetService<FileService>());
            }
        }

        [Fact]
        public void AddAllSingletonSeparately_Method_Should_Add_ImageService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllSingletonSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetService<ImageService>());
            }
        }

        [Fact]
        public void AddAllSingletonSeparately_Method_Shouldn_t_Add_BaseService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllSingletonSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Null(serviceScope.ServiceProvider.GetService<BaseService>());
            }
        }

        [Fact]
        public void AddAllScopedSeparately_Method_Should_Add_FileService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllScopedSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetService<FileService>());
            }
        }

        [Fact]
        public void AddAllScopedSeparately_Method_Should_Add_ImageService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllScopedSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetService<ImageService>());
            }
        }

        [Fact]
        public void AddAllScopedSeparately_Method_Shouldn_t_Add_BaseService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllScopedSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Null(serviceScope.ServiceProvider.GetService<BaseService>());
            }
        }

        [Fact]
        public void AddAllTransientSeparately_Method_Should_Add_FileService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllTransientSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetService<FileService>());
            }
        }

        [Fact]
        public void AddAllTransientSeparately_Method_Should_Add_ImageService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllTransientSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.NotNull(serviceScope.ServiceProvider.GetService<ImageService>());
            }
        }

        [Fact]
        public void AddAllTransientSeparately_Method_Shouldn_t_Add_BaseService_When_IService_Interface_Is_Used()
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAllTransientSeparately<IService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            using (IServiceScope serviceScope = serviceProvider.CreateScope())
            {
                // Assert
                Assert.Null(serviceScope.ServiceProvider.GetService<BaseService>());
            }
        }
    }
}