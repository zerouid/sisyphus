using System;
using Akka.Actor;
using Topshelf;

namespace Sisyphus.Host.Topshelf
{
    public class SisyphusService : ServiceControl
    {
        public ActorSystem ClusterSystem { get; set; }

        public bool Start(HostControl hostControl)
        {
            ClusterSystem = ActorSystem.Create("Sisyphus");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            ClusterSystem.Terminate();
            return true;
        }
    }
}
