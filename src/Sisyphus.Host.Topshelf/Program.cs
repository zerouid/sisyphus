using Topshelf;

namespace Sisyphus.Host.Topshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x => {
                x.SetServiceName("Sisyphus");
                x.SetDisplayName("Sisyphus ETL");
                x.SetDescription("Sisyphus ETL system.");

                x.UseAssemblyInfoForServiceInfo();
                x.RunAsNetworkService();
                x.StartAutomatically();
                x.Service<SisyphusService>();
                x.EnableServiceRecovery(r => r.RestartService(1));
            });
        }
    }
}
