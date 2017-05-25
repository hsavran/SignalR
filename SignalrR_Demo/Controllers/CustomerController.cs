using Microsoft.AspNet.SignalR;
using SignalrR_Demo.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalrR_Demo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            
            return View();
        }

        public void BuyProduct(int productid)
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<ProductHub>();
            hub.Clients.All.ProductIsSold(productid);            
        }
    }
}