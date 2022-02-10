using osu.Framework.Testing;

namespace Rythme.Game.Tests.Visual
{
    public class RythmeTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new RythmeTestSceneTestRunner();

        private class RythmeTestSceneTestRunner : RythmeGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
