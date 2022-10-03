using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;

namespace StorybrewScripts
{
    public class CanvasWasher : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var BackgroundPath = Beatmap.BackgroundPath ?? string.Empty;
            var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.TopLeft);
            bg.Move(0, 0, 0);
        }
    }
}
