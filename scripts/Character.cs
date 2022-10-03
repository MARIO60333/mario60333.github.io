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
    public class Character : StoryboardObjectGenerator
    {
        [Configurable]
        public string CharacterPath = "";

        [Configurable]
        public OsbOrigin Origin = OsbOrigin.Centre;

        [Configurable]
        public double Scale = 1.0f;

        [Configurable]
        public double Opacity = 1.0f;

        [Configurable]
        public bool OpacityAnim = false;

        [Configurable]
        public int OpacitySustain = 0;

        [Configurable]
        public OsbEasing OpacityEasing = OsbEasing.None;

        [Configurable]
        public bool Additive = false;

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public Vector2 StartPos = new Vector2(0, 0);

        [Configurable]
        public Vector2 EndPos = new Vector2(200, 200);

        [Configurable]
        public bool CustomAnimTime = false;

        [Configurable]
        public int StartAnim = 0;

        [Configurable]
        public int EndAnim = 250;

        [Configurable]
        public OsbEasing Easing = OsbEasing.None;

        public override void Generate()
        {
            var charac = GetLayer("").CreateSprite(CharacterPath, Origin);

            charac.Scale(StartTime, Scale);
            if (Additive) charac.Additive(StartTime, EndTime);
            if (!OpacityAnim)
            {
                charac.Fade(StartTime, StartTime, Opacity, Opacity);
            }
            else
            {
                charac.Fade(OpacityEasing, StartTime, StartTime + OpacitySustain, 0, Opacity);
            }
            if (!CustomAnimTime)
            {
                charac.Move(Easing, StartTime, EndTime, StartPos, EndPos);
            }
            else
            {
                charac.Move(Easing, StartTime + StartAnim, StartTime + EndAnim, StartPos, EndPos);
            }
            charac.Fade(EndTime, EndTime, 0, 0);
        }
    }
}
