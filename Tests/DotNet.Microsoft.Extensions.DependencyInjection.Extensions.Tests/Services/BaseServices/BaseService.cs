using DotNet.Microsoft.Extensions.DependencyInjection.Extensions.Tests.Interfaces;

namespace DotNet.Microsoft.Extensions.DependencyInjection.Extensions.Tests.Services.BaseServices
{
    public abstract class BaseService : IService
    {
        public virtual void Run()
        {
        }
    }
}