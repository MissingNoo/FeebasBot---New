using System;
using System.IO;
using System.Reflection;

namespace FeebasBot.Classes
{
    public sealed class Setting
    {
        public static int charx { get; set; }
        public static int chary { get; set; }
        public static int newversion { get; set; }
        public static int IsTargeting { get; set; }
        public static int PausarNoTarget { get; set; }
        public static int CaveChat { get; set; }
        public static int CavePlayer { get; set; }
        public static bool UseHk { get; set; }
        public static bool click { get; set; }
        public static bool clicklock { get; set; }
        public static bool Kill { get; set; }
        public static bool Running { get; set; }
        public static int randomfish { get; set; }
        public static bool PlayerOnScreen { get; set; }
        public static int offset { get; set; }
        public static int tries { get; set; }
        public static int triestotal { get; set; }
        public static string GameName { get; set; }
        public static int diff { get; set; }
        #region LootingPos
        public static int p1 { get; set; }
        public static int p2 { get; set; }
        public static int p3 { get; set; }
        public static int p4 { get; set; }
        public static int p5 { get; set; }
        public static int p6 { get; set; }
        public static int p7 { get; set; }
        public static int p8 { get; set; }

        #endregion
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
        public static int poke { get; set; }
        public static bool verificandopoke{ get; set; }
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
        #region Chat
        public static int ChatEsquerdaX { get; set; }
        public static int ChatDireitaX { get; set; }
        public static int ChatY { get; set; }
        public static int ChatStop { get; set; }
        #endregion
        #region Funções
        public static int Pescar { get; set; }
        public static int PescarSemParar { get; set; }
        public static int Atacar { get; set; }
        public static int AtacarSemTarget { get; set; }
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
        public static int SQMBX { get; set; }
        public static int SQMBY { get; set; }

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
                "PescarSemParar : " + Setting.PescarSemParar,
                "Atacar : " + Setting.Atacar,
                "AtacarSemTarget : " + Setting.AtacarSemTarget,
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
                "PortraitX : " + Setting.PortraitX,
                "PortraitY : " + Setting.PortraitY,
                "portraitdead : " + Setting.portraitdead,
                "caverun : " + Setting.caverun,
                "randomfish : " + Setting.randomfish,
                "catchpoke : " + Setting.catchpoke,
                "pokeballX : " + Setting.pokeballX,
                "pokeballY : " + Setting.pokeballY,
                "SQMBX: " + Setting.SQMBX,
                "SQMBY: " + Setting.SQMBY,
                "triestotal : " + Setting.triestotal,
                "attacktime : " + Setting.attacktime,
                "diff : " + Setting.diff,
                "p1 : " + Setting.p1,
                "p2 : " + Setting.p2,
                "p3 : " + Setting.p3,
                "p4 : " + Setting.p4,
                "p5 : " + Setting.p5,
                "p6 : " + Setting.p6,
                "p7 : " + Setting.p7,
                "p8 : " + Setting.p8,
                "Poke1X : " + Setting.Poke1X,
                "Poke1Y : " + Setting.Poke1Y,
                "Poke2X : " + Setting.Poke2X,
                "Poke2Y : " + Setting.Poke2Y,
                "Poke3X : " + Setting.Poke3X,
                "Poke3Y : " + Setting.Poke3Y,
                "Poke4X : " + Setting.Poke4X,
                "Poke4Y : " + Setting.Poke4Y,
                "Poke5X : " + Setting.Poke5X,
                "Poke5Y : " + Setting.Poke5Y,
                "Poke6X : " + Setting.Poke6X,
                "Poke6Y : " + Setting.Poke6Y,
                "ChatEsquerdaX : " + Setting.ChatEsquerdaX,
                "ChatDireitaX : " + Setting.ChatDireitaX,
                "ChatY : " + Setting.ChatY,
                "ChatStop : " + Setting.ChatStop,
                "CaveChat : " + Setting.CaveChat,
                "CavePlayer : " + Setting.CavePlayer,
                "PausarNoTarget : " + Setting.PausarNoTarget,
                "newversion : " + Setting.newversion,
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
