﻿using ExSharpBase.Modules;

namespace ExSharpBase.Game
{
    internal class OffsetManager
    {
        public static int BaseAddress = Utils.GetLeagueProcess().MainModule.BaseAddress.ToInt32();

        public class Instances
        {
            //Version 10.20.337.6669 [PUBLIC] // 8B 44 24 04 BA ? ? ? ? 2B D0
            public static int LocalPlayer = BaseAddress + 0x3504A14; // string xref blueHero -> Above "hero" subrtn
            public static int Renderer = BaseAddress + 0x352CA10; // 8B 15 ? ? ? ? 83 EC 08 F3 // ["blurKernelSigma", +0x27F] // xref the string, move -0x27f there should be a dword.
            public static int ViewMatrix = BaseAddress + 0x3529CC8; // B9 ? ? ? ? E8 ? ? ? ? B9 ? ? ? ? E9 ? ? ? ? // First result: unk_0x...

            public static int SpellBook = 0x2720;

            public static int UnderMouseObject = BaseAddress + 0x1C072C0; // 8B 0D ? ? ? ? 89 0D

            public static int ZoomInstance = BaseAddress + 0x34FC8F0;
            public static int ZoomAmount = 0x28;
        }

        public class Object
        {
            public static int ChampionName = 0x314C;
            public static int Pos = 0x220;
            public static int Name = 0x6C;
            public static int Visibility = 0x450;
            public static int AttackRange = 0x12D0;
        }
    }
}
