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
Add Extension Method in  Program.cs

```C#
 public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
           .UseStartup<Startup>()
          .UseSlightDIModuleconfig(); //add this .

```
