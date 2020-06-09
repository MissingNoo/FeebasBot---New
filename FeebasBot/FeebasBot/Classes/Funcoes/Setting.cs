﻿using System;
using System.IO;
using System.Reflection;

namespace FeebasBot.Classes
{
    public sealed class Setting
    {
        public static bool Running { get; set; }
        public static bool PlayerOnScreen { get; set; }
        public static int offset { get; set; }
        public static int tries { get; set; }
        public static string GameName { get; set; }
        #region Positions
        public static int RodX { get; set; }
        public static int RodY { get; set; }
        public static int WaterX { get; set; }
        public static int WaterY { get; set; }
        public static int FishX { get; set; }
        public static int FishY { get; set; }
        public static int BattleX { get; set; }
        public static int BattleY { get; set; }
        public static int TargetX { get; set; }
        public static int TargetY { get; set; }
        public static int TargetX2 { get; set; }
        public static int TargetY2 { get; set; }
        public static int PlayerX { get; set; }
        public static int PlayerY { get; set; }
        public static int SlotX { get; set; }
        public static int SlotY { get; set; }
        public static int SQMX { get; set; }
        public static int SQMY { get; set; }
        public static int CloseX { get; set; }
        public static int CloseY { get; set; }
        public static int OrderX { get; set; }
        public static int OrderY { get; set; }        
        public static bool Player { get; set; }
        #endregion
        #region Troca de poke
        public static int PortraitX { get; set; }
        public static int PortraitY { get; set; }
        public static string portraitdead { get; set; }
        public static int Poke1X { get; set; }
        public static int Poke1Y { get; set; }
        public static int Poke2X { get; set; }
        public static int Poke2Y { get; set; }
        public static int Poke3X { get; set; }
        public static int Poke3Y { get; set; }
        public static int Poke4X { get; set; }
        public static int Poke4Y { get; set; }
        public static int Poke5X { get; set; }
        public static int Poke5Y { get; set; }
        public static int Poke6X { get; set; }
        public static int Poke6Y { get; set; }
        #endregion
        #region Moves
        public static int attacktime { get; set; }
        public static int m1 { get; set; }
        public static int m2 { get; set; }
        public static int m3 { get; set; }
        public static int m4 { get; set; }
        public static int m5 { get; set; }
        public static int m6 { get; set; }
        public static int m7 { get; set; }
        public static int m8 { get; set; }
        public static int m9 { get; set; }
        public static int m10 { get; set; }
        #endregion
        #region Funções
        public static int Pescar { get; set; }
        public static int PescarSemParar { get; set; }
        public static int Atacar { get; set; }
        public static int TrocarDePokemon { get; set; }
        public static int Targetar { get; set; }
        public static int Lootear { get; set; }
        public static int catchpoke { get; set; }
        #endregion
        #region Login        
        public static string login { get; set; }
        public static bool LoggedIn { get; set; }
        public static int PodeUsarCaveBot { get; set; }
        public static int PodeUsarLooting { get; set; }
        public static int PodeUsarTrocaDePokemon { get; set; }
        public static int caverun { get; set; }               
        public static int version { get; set; }
        public static int random { get; set; }
        public static string notes { get; set; }
        public static int PodeCapturar { get; set; }
        #endregion
        #region Captura de Pokes
        public static int pokeballX { get; set; }
        public static int pokeballY { get; set; }
        public static int ball1X { get; set; }
        public static int ball1Y { get; set; }
        public static int ball2X { get; set; }
        public static int ball2Y { get; set; }
        public static int ball3X { get; set; }
        public static int ball3Y { get; set; }
        public static int useBall1 { get; set; }
        public static int useBall2 { get; set; }
        public static int useBall3 { get; set; }
        #endregion
        


        public static void SaveSettings()
        {
            // Create a string array with the lines of text
            string[] lines = { "RodX : " + Setting.RodX, "RodY : " + Setting.RodY,
                "WaterX : " + Setting.WaterX, "WaterY : " + Setting.WaterY,
                "FishX : " + Setting.FishX, "FishY : " + Setting.FishY,
                "BattleX : " + Setting.BattleX, "BattleY : " + Setting.BattleY,
                "TargetX : " + Setting.TargetX, "TargetY : " + Setting.TargetY,
                "TargetX2 : " + Setting.TargetX2, "TargetY2 : " + Setting.TargetY2,
                "m1 : " + Setting.m1,
                "m2 : " + Setting.m2,
                "m3 : " + Setting.m3,
                "m4 : " + Setting.m4,
                "m5 : " + Setting.m5,
                "m6 : " + Setting.m6,
                "m7 : " + Setting.m7,
                "m8 : " + Setting.m8,
                "m9 : " + Setting.m9,
                "m10 : " + Setting.m10,
                "Pescar : " + Setting.Pescar,
                "Atacar : " + Setting.Atacar,
                "Targetar : " + Setting.Targetar,
                "Lootear : " + Setting.Lootear,
                "TrocarDePokemon : " + Setting.TrocarDePokemon,
                "PlayerX : " + Setting.PlayerX,
                "PlayerY : " + Setting.PlayerY,
                "SQMX : " + Setting.SQMX,
                "SQMY : " + Setting.SQMY,
                "SlotX : " + Setting.SlotX,
                "SlotY : " + Setting.SlotY,
                "CloseX : " + Setting.CloseX,
                "CloseY : " + Setting.CloseY,
                "OrderX : " + Setting.OrderX,
                "OrderY : " + Setting.OrderY,
                "login : " + Setting.login,
                "Poke1X : " + Setting.Poke1X,
                "Poke1Y : " + Setting.Poke1Y,
                "Poke2X : " + Setting.Poke2X,
                "Poke2Y : " + Setting.Poke2Y,
                "PortraitX : " + Setting.PortraitX,
                "PortraitY : " + Setting.PortraitY,
                "portraitdead : " + Setting.portraitdead,
                "caverun : " + Setting.caverun,
                "random : " + Setting.random,
                "catchpoke : " + Setting.catchpoke,
                "pokeballX : " + Setting.pokeballX,
                "pokeballY : " + Setting.pokeballY,
                "ball1X : " + Setting.ball1X,
                "ball1Y : " + Setting.ball1Y,
                "ball2X : " + Setting.ball2X,
                "ball2Y : " + Setting.ball2Y,
                "ball3X : " + Setting.ball3X,
                "ball3Y : " + Setting.ball3Y,
                "useBall1 : " + Setting.useBall1,
                "useBall2 : " + Setting.useBall2,
                "useBall3 : " + Setting.useBall3,
            };

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter("./Settings.ini"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

            static readonly string SETTINGS = "./Settings.ini";
        static readonly Setting instance = new Setting();
        Setting() { }
        static Setting()
        {
            if (File.Exists("./Settings.ini") == false)
            {
                // Create a string array with the lines of text
                string[] lines = { "a" };

                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter("./Settings.ini"))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
            }
            string property = "";
            string[] settings = File.ReadAllLines(SETTINGS);
            foreach (string s in settings)
                try
                {
                    string[] split = s.Split(new char[] { ':' }, 2);
                    if (split.Length != 2)
                        continue;
                    property = split[0].Trim();
                    string value = split[1].Trim();
                    PropertyInfo propInfo = instance.GetType().GetProperty(property);
                    switch (propInfo.PropertyType.Name)
                    {
                        case "Int32":
                            propInfo.SetValue(null, Convert.ToInt32(value), null);
                            break;
                        case "String":
                            propInfo.SetValue(null, value, null);
                            break;
                    }
                }
                catch
                {
                    throw new Exception("Invalid setting '" + property + "'");
                }
        }
    }
}