using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerBroEx
{
    struct ServerInfo
    {
       public  int regionID;             // region
       public int currentPlayerCount;   // current player count
       public int maxPlayers;           // max player count
       public int ping;                 // ping
    };
    class ServerBrowserService
    {
        // An array of all servers registered with the system.
        private ServerInfo[] servers = new ServerInfo[50]; // note: this is hard-coded for 50 servers

        // A count of all servers currently registered.
        private int serverCount;

        // Registers a server with the service
        //No more than 50 servers
        public bool RegisterServer(ServerInfo newServer)
        {

            if (serverCount > 50)
                return false;

            servers[serverCount] = newServer;
            serverCount++;

            servers[serverCount++] = newServer;

            return true;
        }

        // Copies server entries into the given array.
        // Returns the total number of servers provided to the array.
        public int GetServers(ref ServerInfo[] dstArray)
        {
            dstArray = new ServerInfo[50];
            int svrsCopied = 0;

            for (svrsCopied = 0; svrsCopied < serverCount; svrsCopied++)
            {
                    dstArray[svrsCopied] = servers[svrsCopied];
            }

            return svrsCopied;
        }

        public int GetServers(ref ServerInfo[] dstArray, int pingLimit)
        {
            dstArray = new ServerInfo[50];
            int svrsCopied2 = 0;
            int dstIndex = 0;

            for (svrsCopied2 = 0; svrsCopied2 < serverCount; svrsCopied2++)
            {
                if (servers[svrsCopied2].ping < pingLimit)
                    dstArray[dstIndex] = servers[svrsCopied2];
                dstIndex++;
            }

            return dstIndex;
        }
    }

    class Program
    {
        static void Main()
        {
            ServerBrowserService sbs = new ServerBrowserService();
            ServerInfo s1;

            s1.regionID = 1;
            s1.ping = 2;
            s1.maxPlayers = 10;
            s1.currentPlayerCount = 5;
            sbs.RegisterServer(s1);

            s1.regionID = 8;
            s1.ping = 6;
            s1.maxPlayers = 15;
            s1.currentPlayerCount = 10;
            sbs.RegisterServer(s1);

            s1.regionID = 8;
            s1.ping = 16;
            s1.maxPlayers = 15;
            s1.currentPlayerCount = 10;
            sbs.RegisterServer(s1);

            ServerInfo[] tmpOp = new ServerInfo[0];
            int NumServ = sbs.GetServers(ref tmpOp);

            int NumServ2 = sbs.GetServers(ref tmpOp, 10);

            Console.ReadLine();
        }
    }
}
