# SlightDIConfigure.Extensions

How to Use  Add class inherit SlightModuleConfigure
```C#
    public class PayModuleConfig : SlightModuleConfigure
    {
        protected override void Load(IServiceCollection services)
        {
              services.AddTransient<Ipay, PayImp>();
        }
    }

```
