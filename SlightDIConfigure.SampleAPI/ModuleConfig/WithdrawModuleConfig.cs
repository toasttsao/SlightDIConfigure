using Microsoft.Extensions.DependencyInjection;
using SlightDIConfigure.Extensions;
using SlightDIConfigure.SampleAPI.Imp;

namespace SlightDIConfigure.SampleAPI.ModuleConfig
{
    public class WithdrawModuleConfig: SlightModuleConfigure
    {
        protected override void Load(IServiceCollection services)
        {
             services.AddTransient<Iwithdraw, WithdrawImp>();
        }
    }
}