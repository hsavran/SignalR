using Microsoft.Owin;
using Owin;

namespace SignalrR_Demo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}