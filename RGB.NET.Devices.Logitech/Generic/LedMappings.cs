﻿using RGB.NET.Core;

namespace RGB.NET.Devices.Logitech
{
    public static class LedMappings
    {
        public static LedMapping<int> PerKey { get; } = new()
        {
            { LedId.Keyboard_Escape, 0 },
            { LedId.Keyboard_F1, 4 },
            { LedId.Keyboard_F2, 8 },
            { LedId.Keyboard_F3, 12 },
            { LedId.Keyboard_F4, 16 },
            { LedId.Keyboard_F5, 20 },
            { LedId.Keyboard_F6, 24 },
            { LedId.Keyboard_F7, 28 },
            { LedId.Keyboard_F8, 32 },
            { LedId.Keyboard_F9, 36 },
            { LedId.Keyboard_F10, 40 },
            { LedId.Keyboard_F11, 44 },
            { LedId.Keyboard_F12, 48 },
            { LedId.Keyboard_PrintScreen, 52 },
            { LedId.Keyboard_ScrollLock, 56 },
            { LedId.Keyboard_PauseBreak, 60 },
            // { LedId.Keyboard_?, 64 },
            // { LedId.Keyboard_?, 68 },
            // { LedId.Keyboard_?, 72 },
            // { LedId.Keyboard_?, 76 },
            // { LedId.Keyboard_?, 80 },

            { LedId.Keyboard_GraveAccentAndTilde, 84 },
            { LedId.Keyboard_1, 88 },
            { LedId.Keyboard_2, 92 },
            { LedId.Keyboard_3, 96 },
            { LedId.Keyboard_4, 100 },
            { LedId.Keyboard_5, 104 },
            { LedId.Keyboard_6, 108 },
            { LedId.Keyboard_7, 112 },
            { LedId.Keyboard_8, 116 },
            { LedId.Keyboard_9, 120 },
            { LedId.Keyboard_0, 124 },
            { LedId.Keyboard_MinusAndUnderscore, 128 },
            { LedId.Keyboard_EqualsAndPlus, 132 },
            { LedId.Keyboard_Backspace, 136 },
            { LedId.Keyboard_Insert, 140 },
            { LedId.Keyboard_Home, 144 },
            { LedId.Keyboard_PageUp, 148 },
            { LedId.Keyboard_NumLock, 152 },
            { LedId.Keyboard_NumSlash, 156 },
            { LedId.Keyboard_NumAsterisk, 160 },
            { LedId.Keyboard_NumMinus, 164 },

            { LedId.Keyboard_Tab, 168 },
            { LedId.Keyboard_Q, 172 },
            { LedId.Keyboard_W, 176 },
            { LedId.Keyboard_E, 180 },
            { LedId.Keyboard_R, 184 },
            { LedId.Keyboard_T, 188 },
            { LedId.Keyboard_Y, 192 },
            { LedId.Keyboard_U, 196 },
            { LedId.Keyboard_I, 200 },
            { LedId.Keyboard_O, 204 },
            { LedId.Keyboard_P, 208 },
            { LedId.Keyboard_BracketLeft, 212 },
            { LedId.Keyboard_BracketRight, 216 },
            { LedId.Keyboard_Backslash, 220 },
            { LedId.Keyboard_Delete, 224 },
            { LedId.Keyboard_End, 228 },
            { LedId.Keyboard_PageDown, 232 },
            { LedId.Keyboard_Num7, 236 },
            { LedId.Keyboard_Num8, 240 },
            { LedId.Keyboard_Num9, 244 },
            { LedId.Keyboard_NumPlus, 248 },

            { LedId.Keyboard_CapsLock, 252 },
            { LedId.Keyboard_A, 256 },
            { LedId.Keyboard_S, 260 },
            { LedId.Keyboard_D, 264 },
            { LedId.Keyboard_F, 268 },
            { LedId.Keyboard_G, 272 },
            { LedId.Keyboard_H, 276 },
            { LedId.Keyboard_J, 280 },
            { LedId.Keyboard_K, 284 },
            { LedId.Keyboard_L, 288 },
            { LedId.Keyboard_SemicolonAndColon, 292 },
            { LedId.Keyboard_ApostropheAndDoubleQuote, 296 },
            { LedId.Keyboard_NonUsTilde, 300 }, //TODO DarthAffe 26.03.2017: Find the real ID/Name of this key - it's not documented ...
            { LedId.Keyboard_Enter, 304 },
            // { LedId.Keyboard_?, 308 },
            // { LedId.Keyboard_?, 312 },
            // { LedId.Keyboard_?, 316 },
            { LedId.Keyboard_Num4, 320 },
            { LedId.Keyboard_Num5, 324 },
            { LedId.Keyboard_Num6, 328 },
            // { LedId.Keyboard_?, 332 },

            { LedId.Keyboard_LeftShift, 336 },
            { LedId.Keyboard_NonUsBackslash, 340 },
            { LedId.Keyboard_Z, 344 },
            { LedId.Keyboard_X, 348 },
            { LedId.Keyboard_C, 352 },
            { LedId.Keyboard_V, 356 },
            { LedId.Keyboard_B, 360 },
            { LedId.Keyboard_N, 364 },
            { LedId.Keyboard_M, 368 },
            { LedId.Keyboard_CommaAndLessThan, 372 },
            { LedId.Keyboard_PeriodAndBiggerThan, 376 },
            { LedId.Keyboard_SlashAndQuestionMark, 380 },
            { LedId.Keyboard_RightShift, 388 },
            // { LedId.Keyboard_?, 392 },
            { LedId.Keyboard_ArrowUp, 396 },
            // { LedId.Keyboard_?, 400 },
            { LedId.Keyboard_Num1, 404 },
            { LedId.Keyboard_Num2, 408 },
            { LedId.Keyboard_Num3, 412 },
            { LedId.Keyboard_NumEnter, 416 },

            { LedId.Keyboard_LeftCtrl, 420 },
            { LedId.Keyboard_LeftGui, 424 },
            { LedId.Keyboard_LeftAlt, 428 },
            // { LedId.Keyboard_?, 432 },
            // { LedId.Keyboard_?, 436 },
            { LedId.Keyboard_Space, 440 },
            // { LedId.Keyboard_?, 444 },
            // { LedId.Keyboard_?, 448 },
            // { LedId.Keyboard_?, 452 },
            // { LedId.Keyboard_?, 456 },
            // { LedId.Keyboard_?, 460 },
            { LedId.Keyboard_RightAlt, 464 },
            { LedId.Keyboard_RightGui, 468 },
            { LedId.Keyboard_Application, 472 },
            { LedId.Keyboard_RightCtrl, 476 },
            { LedId.Keyboard_ArrowLeft, 480 },
            { LedId.Keyboard_ArrowDown, 484 },
            { LedId.Keyboard_ArrowRight, 488 },
            { LedId.Keyboard_Num0, 492 },
            { LedId.Keyboard_NumPeriodAndDelete, 496 },
            // { LedId.Keyboard_?, 500 },
        };

        public static LedMapping<int> Device { get; } = new()
        {
            { LedId.Custom1, 0 }
        };

        public static LedMapping<int> ZoneKeyboard { get; } = new()
        {
            { LedId.Keyboard_Programmable1, 0 },
            { LedId.Keyboard_Programmable2, 1 },
            { LedId.Keyboard_Programmable3, 2 },
            { LedId.Keyboard_Programmable4, 3 },
            { LedId.Keyboard_Programmable5, 4 },
            { LedId.Keyboard_Programmable6, 5 },
            { LedId.Keyboard_Programmable7, 6 },
            { LedId.Keyboard_Programmable8, 7 },
            { LedId.Keyboard_Programmable9, 8 },
            { LedId.Keyboard_Programmable10, 9 },
            { LedId.Keyboard_Programmable11, 10 },
            { LedId.Keyboard_Programmable12, 11 },
            { LedId.Keyboard_Programmable13, 12 },
            { LedId.Keyboard_Programmable14, 13 },
            { LedId.Keyboard_Programmable15, 14 },
            { LedId.Keyboard_Programmable16, 15 },
            { LedId.Keyboard_Programmable17, 16 },
            { LedId.Keyboard_Programmable18, 17 },
            { LedId.Keyboard_Programmable19, 18 },
            { LedId.Keyboard_Programmable20, 19 },
            { LedId.Keyboard_Programmable21, 20 },
            { LedId.Keyboard_Programmable22, 21 },
            { LedId.Keyboard_Programmable23, 22 },
            { LedId.Keyboard_Programmable24, 23 },
            { LedId.Keyboard_Programmable25, 24 },
            { LedId.Keyboard_Programmable26, 25 },
            { LedId.Keyboard_Programmable27, 26 },
            { LedId.Keyboard_Programmable28, 27 },
            { LedId.Keyboard_Programmable29, 28 },
            { LedId.Keyboard_Programmable30, 29 },
            { LedId.Keyboard_Programmable31, 30 },
            { LedId.Keyboard_Programmable32, 31 },
        };

        public static LedMapping<int> ZoneMouse { get; } = new()
        {
            { LedId.Mouse1, 0 },
            { LedId.Mouse2, 1 },
            { LedId.Mouse3, 2 },
            { LedId.Mouse4, 3 },
            { LedId.Mouse5, 4 },
            { LedId.Mouse6, 5 },
            { LedId.Mouse7, 6 },
            { LedId.Mouse8, 7 },
            { LedId.Mouse9, 8 },
            { LedId.Mouse10, 9 },
            { LedId.Mouse11, 10 },
            { LedId.Mouse12, 11 },
            { LedId.Mouse13, 12 },
            { LedId.Mouse14, 13 },
            { LedId.Mouse15, 14 },
            { LedId.Mouse16, 15 },
            { LedId.Mouse17, 16 },
            { LedId.Mouse18, 17 },
            { LedId.Mouse19, 18 },
            { LedId.Mouse20, 19 },
            { LedId.Mouse21, 20 },
            { LedId.Mouse22, 21 },
            { LedId.Mouse23, 22 },
            { LedId.Mouse24, 23 },
            { LedId.Mouse25, 24 },
            { LedId.Mouse26, 25 },
            { LedId.Mouse27, 26 },
            { LedId.Mouse28, 27 },
            { LedId.Mouse29, 28 },
            { LedId.Mouse30, 29 },
            { LedId.Mouse31, 30 },
            { LedId.Mouse32, 31 },
        };

        public static LedMapping<int> ZoneHeadset { get; } = new()
        {
            { LedId.Headset1, 0 },
            { LedId.Headset2, 1 },
            { LedId.Headset3, 2 },
            { LedId.Headset4, 3 },
            { LedId.Headset5, 4 },
            { LedId.Headset6, 5 },
            { LedId.Headset7, 6 },
            { LedId.Headset8, 7 },
            { LedId.Headset9, 8 },
            { LedId.Headset10, 9 },
            { LedId.Headset11, 10 },
            { LedId.Headset12, 11 },
            { LedId.Headset13, 12 },
            { LedId.Headset14, 13 },
            { LedId.Headset15, 14 },
            { LedId.Headset16, 15 },
            { LedId.Headset17, 16 },
            { LedId.Headset18, 17 },
            { LedId.Headset19, 18 },
            { LedId.Headset20, 19 },
            { LedId.Headset21, 20 },
            { LedId.Headset22, 21 },
            { LedId.Headset23, 22 },
            { LedId.Headset24, 23 },
            { LedId.Headset25, 24 },
            { LedId.Headset26, 25 },
            { LedId.Headset27, 26 },
            { LedId.Headset28, 27 },
            { LedId.Headset29, 28 },
            { LedId.Headset30, 29 },
            { LedId.Headset31, 30 },
            { LedId.Headset32, 31 },
        };

        public static LedMapping<int> ZoneMousepad { get; } = new()
        {
            { LedId.Mousepad1, 0 },
            { LedId.Mousepad2, 1 },
            { LedId.Mousepad3, 2 },
            { LedId.Mousepad4, 3 },
            { LedId.Mousepad5, 4 },
            { LedId.Mousepad6, 5 },
            { LedId.Mousepad7, 6 },
            { LedId.Mousepad8, 7 },
            { LedId.Mousepad9, 8 },
            { LedId.Mousepad10, 9 },
            { LedId.Mousepad11, 10 },
            { LedId.Mousepad12, 11 },
            { LedId.Mousepad13, 12 },
            { LedId.Mousepad14, 13 },
            { LedId.Mousepad15, 14 },
            { LedId.Mousepad16, 15 },
            { LedId.Mousepad17, 16 },
            { LedId.Mousepad18, 17 },
            { LedId.Mousepad19, 18 },
            { LedId.Mousepad20, 19 },
            { LedId.Mousepad21, 20 },
            { LedId.Mousepad22, 21 },
            { LedId.Mousepad23, 22 },
            { LedId.Mousepad24, 23 },
            { LedId.Mousepad25, 24 },
            { LedId.Mousepad26, 25 },
            { LedId.Mousepad27, 26 },
            { LedId.Mousepad28, 27 },
            { LedId.Mousepad29, 28 },
            { LedId.Mousepad30, 29 },
            { LedId.Mousepad31, 30 },
            { LedId.Mousepad32, 31 },
        };

        public static LedMapping<int> ZoneSpeaker { get; } = new()
        {
            { LedId.Speaker1, 0 },
            { LedId.Speaker2, 1 },
            { LedId.Speaker3, 2 },
            { LedId.Speaker4, 3 },
            { LedId.Speaker5, 4 },
            { LedId.Speaker6, 5 },
            { LedId.Speaker7, 6 },
            { LedId.Speaker8, 7 },
            { LedId.Speaker9, 8 },
            { LedId.Speaker10, 9 },
            { LedId.Speaker11, 10 },
            { LedId.Speaker12, 11 },
            { LedId.Speaker13, 12 },
            { LedId.Speaker14, 13 },
            { LedId.Speaker15, 14 },
            { LedId.Speaker16, 15 },
            { LedId.Speaker17, 16 },
            { LedId.Speaker18, 17 },
            { LedId.Speaker19, 18 },
            { LedId.Speaker20, 19 },
            { LedId.Speaker21, 20 },
            { LedId.Speaker22, 21 },
            { LedId.Speaker23, 22 },
            { LedId.Speaker24, 23 },
            { LedId.Speaker25, 24 },
            { LedId.Speaker26, 25 },
            { LedId.Speaker27, 26 },
            { LedId.Speaker28, 27 },
            { LedId.Speaker29, 28 },
            { LedId.Speaker30, 29 },
            { LedId.Speaker31, 30 },
            { LedId.Speaker32, 31 },
        };
    }
}
