using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(ASPNet_SignalR.Startup))]
namespace ASPNet_SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}