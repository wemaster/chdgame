using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace WebGame17
{
    public class MyHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public Task Join()
        {
            return Groups.Add(Context.ConnectionId, "foo");
        }

        public Task Send(string message)
        {
            return Clients.Group("foo").addMessage(message);
        }
    }
}