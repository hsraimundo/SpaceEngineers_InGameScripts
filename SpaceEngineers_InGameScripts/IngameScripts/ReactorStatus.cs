using Sandbox.ModAPI.Ingame;
using SpaceEngineersScripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngineers_InGameScripts.IngameScripts
{
    public class ReactorStatus : MyGridProgram
    {
        public void Main(string argument)
        {
            //get all reactors
            var reactors = new List<IMyTerminalBlock>();
            GridTerminalSystem.GetBlocksOfType<IMyReactor>(reactors);

            //get the lcd configured in the argument
            var lcd = (IMyTextPanel)GridTerminalSystem.GetBlockWithName(argument);

            double totalPowerOutput = 0;

            for(var i = 0; i< reactors.Count; ++i)
            {
                var match = System.Text.RegularExpressions.Regex.Match(
                    reactors[i].DetailedInfo,
                    @"Current Output: (?<power>[0-9,.]*) (?<scale>[k,M]*)W"
                    );

                double power = 0;
                double.TryParse(match.Groups["power"].Value, out power);
                var powerMultiplier = (match.Groups["scale"].Value == "M") ? 1000000 : (match.Groups["scale"].Value == "k") ? 1000 : 1;

                totalPowerOutput += power * powerMultiplier;
            }

            string echo = "";

            if(totalPowerOutput > 1000000)
            {
                totalPowerOutput /= 1000000;
                echo = totalPowerOutput + "MW";
            }else if(totalPowerOutput > 1000)
            {
                totalPowerOutput /= 1000;
                echo = totalPowerOutput + "kW";
            }
            else
            {
                echo = totalPowerOutput + "W";
            }

            lcd.WritePublicText(echo);
            lcd.ShowTextureOnScreen();
            lcd.ShowPublicTextOnScreen();

            Echo(echo);
        }
    }
}
