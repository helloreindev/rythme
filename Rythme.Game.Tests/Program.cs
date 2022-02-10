using osu.Framework;
using osu.Framework.Platform;

namespace Rythme.Game.Tests
{
    public static class Program
    {
        private const string gameName = @"visual-tests";

        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(gameName, new HostOptions { BindIPC = true }))
            using (var game = new RythmeTestBrowser())
                host.Run(game);
        }
    }
}
