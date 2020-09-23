using Microsoft.AspNetCore.Hosting;


[assembly: HostingStartup(typeof(POS.Areas.Identity.IdentityHostingStartup))]

namespace POS.Areas.Identity
{

    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }

}