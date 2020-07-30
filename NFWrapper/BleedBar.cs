using DarkSoulsScripting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Numerics;

namespace NFWrapper
{
    public static partial class Wrapper
    {
        static EzDrawHook.Box[] bars = new EzDrawHook.Box[8];
        static EzDrawHook.Box[] bgs = new EzDrawHook.Box[8];
        static Vector2 fullSize = new Vector2(120, 5);

        public static void InitBleedBar()
        {
            for (int x = 0; x < 8; x++)
            {
                bgs[x] = new EzDrawHook.Box();
                bgs[x].Size = fullSize;
                bgs[x].Color1 = Color.FromArgb(127, Color.Black);
                bgs[x].Color2 = Color.FromArgb(127, Color.Black);
                bgs[x].IgnoreCulling = true;

                bars[x] = new EzDrawHook.Box();
                bars[x].Size = fullSize;
                bars[x].Color1 = Color.FromArgb(127, Color.Red);
                bars[x].Color2 = Color.FromArgb(127, Color.Red);
                bars[x].IgnoreCulling = true;
            }
        }

        public static void DisplayBleedBar()
        {
            try
            {
                for (int x = 0; x < 8; x++)
                {
                    Vector2 scrRatio = FrpgWindow.DisplaySize / new Vector2(1280, 720);
                    MenuMan.FloatingHPBar hpBar = MenuMan.HpBars[x];
                    if ((hpBar.Visible > -1) && (hpBar.Pos.X > 0) && (hpBar.Pos.Y > 0) && (hpBar.Handle > -1))
                    {
                        float BleedRatio = 1f;
                        EzDrawHook.Box redbar = bars[x];
                        EzDrawHook.Box blackbar = bgs[x];
                        Vector2 basePos = hpBar.Pos * scrRatio; 
                        try
                        {
                            Enemy nme = Enemy.FromPtr(GetPlayerInsFromHandle(hpBar.Handle));
                            BleedRatio = 1f - ((float)nme.BleedResist / (float)nme.MaxBleedResist);

                            redbar.Size = new Vector2(fullSize.X * BleedRatio, fullSize.Y);
                            blackbar.Size = new Vector2(fullSize.X - redbar.Size.X, redbar.Size.Y);

                            redbar.Pos = basePos - new Vector2((fullSize.X - redbar.Size.X) / 2, 0);
                            blackbar.Pos = basePos + new Vector2(redbar.Size.X / 2f, 0);
                        }
                        catch (Exception ex) { Output(ex.Message); }
                    }
                    else
                    {
                        bgs[x].Pos = new Vector2(-2000, -2000);
                        bars[x].Pos = bgs[x].Pos;
                    }
                }
            }
            catch (Exception ex)
            {
                Output(ex.Message);
            }
        }
    }
}
