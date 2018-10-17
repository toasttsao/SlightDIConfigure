using Microsoft.Extensions.DependencyInjection;
using SlightDIConfigure.Extensions;
using SlightDIConfigure.SampleAPI.Imp;

namespace SlightDIConfigure.SampleAPI.ModuleConfig
{
    public class PayModuleConfig : SlightModuleConfigure
    {
        protected override void Load(IServiceCollection services)
        {
              services.AddTransient<Ipay, PayImp>();
        }
    }
}