using Microsoft.Extensions.DependencyInjection;

namespace SlightDIConfigure.Extensions
{
    public abstract class SlightModuleConfigure
    {
        protected virtual void Load(IServiceCollection services) { }
    }
}
