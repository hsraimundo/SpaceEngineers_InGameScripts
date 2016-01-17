using Sandbox.ModAPI.Ingame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngineersScripts.InGame
{
    public class BatteryStatus : ProgrammableBlockInterface
    {
        public override void Main(string argument)
        {
            //get all batteries
            var batteries = new List<IMyTerminalBlock>();
            GridTerminalSystem.GetBlocksOfType<IMyBatteryBlock>(batteries);

            //get the lcd configured in the argument
            var lcd = (IMyTextPanel)GridTerminalSystem.GetBlockWithName(argument);

            //auxiliary
            List<String> statuses = new List<string>();
            double avgPower = 0;

            for (int i = 0; i < batteries.Count; ++i)
            {
                var match = System.Text.RegularExpressions.Regex.Match(
                    batteries[i].DetailedInfo, 
                    @"Max Stored Power: (?<power>[0-9,.]*) (?<scale>[k,M]*)Wh(.|\W)*Stored power: (?<power2>[0-9,.]*) (?<scale2>[k,M]*)Wh"
                    );
                
                var maxStoredPower = match.Groups["power"].Value;
                var maxStoredPowerMultiplier = (match.Groups["scale"].Value == "M") ? 1000000 : (match.Groups["scale"].Value == "k") ? 1000 : 1;
                var storedPower = match.Groups["power2"].Value;
                var storedPowerMultiplier = (match.Groups["scale2"].Value == "M") ? 1000000 : (match.Groups["scale2"].Value == "k") ? 1000 : 1;

                double d1 = 0, d2 = 0;
                double.TryParse(storedPower, out d1);
                double.TryParse(maxStoredPower, out d2);

                var batteryPerc = (d1*storedPowerMultiplier) / (maxStoredPowerMultiplier * d2) * 100;
                avgPower += batteryPerc;

                statuses.Add(String.Format("{0}: {1}%", batteries[i].CustomName, batteryPerc));
            }


            avgPower = avgPower / statuses.Count;

            statuses.Add("Avg. Power: " + avgPower + "%");
            string echo = String.Join("\n", statuses);

            lcd.WritePublicText(echo);
            lcd.ShowTextureOnScreen();
            lcd.ShowPublicTextOnScreen();

            Echo(echo);
        }
    }
}
