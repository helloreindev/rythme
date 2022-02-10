using osu.Framework.Platform;
using osu.Framework;
using Rythme.Game;

namespace Rythme.Desktop
{
    public static class Program
    {
        private const string gameName = @"Rythme";

        public static void Main()
        {
            using (DesktopGameHost host = Host.GetSuitableDesktopHost(gameName, new HostOptions { BindIPC = true }))
            using (osu.Framework.Game game = new RythmeGame())
                host.Run(game);
        }
    }
}
