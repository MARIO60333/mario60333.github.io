using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Flash : StoryboardObjectGenerator
    {
        [Configurable]
        public string FlashPath = "sb/flash.png";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int Duration = 500;

        [Configurable]
        public OsbEasing Easing = OsbEasing.OutQuad;

        [Configurable]
        public int PreAttack = 0;

        [Configurable]
        public OsbEasing PreAttackEasing = OsbEasing.OutExpo;

        [Configurable]
        public int Hold = 0;

        public override void Generate()
        {
            var bitmap = GetMapsetBitmap(FlashPath);
            var flash = GetLayer("").CreateSprite(FlashPath, OsbOrigin.Centre);
            flash.Scale(StartTime, 480.0f / bitmap.Height);
            flash.Fade(PreAttackEasing, StartTime - PreAttack, StartTime, 0, 1);
            flash.Fade(StartTime, StartTime + Hold, 1, 1);
            flash.Fade(Easing, StartTime + Hold, StartTime + Hold + Duration, 1, 0);
        }
    }
}
