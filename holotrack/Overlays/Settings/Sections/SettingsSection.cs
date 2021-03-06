using holotrack.Graphics.Interface;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK;

namespace holotrack.Overlays.Settings.Sections
{
    public abstract class SettingsSection : Container
    {
        private FillFlowContainer content;
        protected override Container<Drawable> Content => content;

        public SettingsSection()
        {
            RelativeSizeAxes = Axes.Both;
            InternalChild = new HoloTrackScrollContainer
            {
                RelativeSizeAxes = Axes.Both,
                Child = content = new FillFlowContainer
                {
                    RelativeSizeAxes = Axes.X,
                    AutoSizeAxes = Axes.Y,
                    Spacing = new Vector2(0, 30),
                    Direction = FillDirection.Vertical,
                }
            };
        }
    }
}