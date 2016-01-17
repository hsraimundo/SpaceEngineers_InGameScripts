using Sandbox.ModAPI.Ingame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngineers_InGameScripts
{
    public static class Program
    {
        static public void Main(string[] args)
        {
            IMyBatteryBlock battery = new MyBatteryBlock();
            //for the sake of compilation - useful for ad-hoc testing as well
        }
    }
}
