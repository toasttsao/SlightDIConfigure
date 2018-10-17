# SlightDIConfigure.Extensions

How to Use  <br/>
Add class inherit SlightModuleConfigure
```C#
    public class PayModuleConfig : SlightModuleConfigure
    {
        protected override void Load(IServiceCollection services)
        {
              services.AddTransient<Ipay, PayImp>();
        }
    }

```
