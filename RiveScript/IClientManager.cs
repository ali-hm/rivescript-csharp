using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiveScript
{
    public interface IClientManager
    {
        string[] listClients();
        IClient client(string username);
        bool clientExists(string username);
    }
}
