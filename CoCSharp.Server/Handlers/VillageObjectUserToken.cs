﻿namespace CoCSharp.Server.Handlers
{
    public class VillageObjectToken
    {
        // A way to figure which avatar to save on events.
        public VillageObjectToken(CoCServer server, CoCRemoteClient client)
        {
            Server = server;
            Client = client;
        }

        public CoCServer Server { get; set; }

        public CoCRemoteClient Client { get; set; }
    }
}
