using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osuTK.Graphics;

namespace Rythme.Game
{
    public class MainScreen : Screen
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren = new Drawable[]
            {
                new Box
                {
                    Colour = Colour4.BlueViolet,
                    RelativeSizeAxes = Axes.Both
                },
                new SpriteText
                {
                    Y = 20,
                    Text = "Main Menu",
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Font = FontUsage.Default.With(size: 40),
                    Colour = new Color4(32, 32, 32, 255)
                },
                new SpinningBox
                {
                    Anchor = Anchor.Centre
                }
            };
        }
    }
}
