using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MVCAutoUpdateFromSQLServerWithSignalr.Hubs
{
    [HubName("salesHub")]
    public class SalesHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public static void UpdateSalesList()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<SalesHub>();
            context.Clients.All.updateSalesList();
        }
    }
}