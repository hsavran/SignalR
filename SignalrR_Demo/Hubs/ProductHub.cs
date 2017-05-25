using Microsoft.AspNet.SignalR;

namespace SignalrR_Demo.Hubs
{
    public class ProductHub : Hub
    {
        public void ProductIsSold()
        {
            Clients.All.productissold();
        }
    }
}