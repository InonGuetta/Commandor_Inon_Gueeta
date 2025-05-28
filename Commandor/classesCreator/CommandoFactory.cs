using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class CommandoFactory
{
    public List<Commando> commandos = new List<Commando>();
    Random rand = new Random();

            string[] soldierNames = new string[]
         {
         "John Miller", "James Anderson", "Robert Jackson", "Michael Davis", "William Harris",
         "David Thompson", "Joseph White", "Charles Martin", "Thomas Lewis", "Daniel Walker",
         "Matthew Hall", "Anthony Allen", "Mark Young", "Steven King", "Andrew Scott",
         "Joshua Green", "Kevin Adams", "Brian Baker", "Jason Wright", "Eric Nelson"
         };
            string[] codeNames = new string[]
            {
         "IronWolf", "GhostStrike", "FalconEye", "ShadowBlade", "NightStorm",
         "SteelViper", "EchoHawk", "CrimsonFox", "PhantomZero", "BlackHornet",
         "SilverFang", "RogueEagle", "ThunderFist", "ViperGhost", "CobraClaw",
         "DeltaShade", "BlazeRaven", "StormTiger", "AlphaFrost", "RapidSpecter"
            };
          string[] statusRandom = { "Standing", "walking", "hiding" };


    public void CommandoFactorMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = rand.Next(1, 3);
            if (temp == 1)
            {
                // הייתה אמור להוסיף כאן הניו על מנת שייצר מופע                
                commandos.Add(new SeaCommando(soldierNames[rand.Next(0, soldierNames.Length)],
                    codeNames[rand.Next(0, codeNames.Length)], statusRandom[rand.Next(0, statusRandom.Length)]));
            }
            else if (temp == 2)
            {
                // הייתה אמור להוסיף כאן הניו על מנת שייצר מופע                
                commandos.Add(new AirCommando(soldierNames[rand.Next(0, soldierNames.Length)],
                    codeNames[rand.Next(0, codeNames.Length)], statusRandom[rand.Next(0, statusRandom.Length)]));
            }
        }
    }

    // ----------------------------------------------------------------------------------
    public void AddOneSeaComandor(string name, string codeName, string status)
    {
        commandos.Add(new SeaCommando(name, codeName, status));
    }
    
    // ----------------------------------------------------------------------------------
    public void AddOneAirComandor(string name, string codeName, string status)
    {
        commandos.Add(new AirCommando(name, codeName, status));
    }
}