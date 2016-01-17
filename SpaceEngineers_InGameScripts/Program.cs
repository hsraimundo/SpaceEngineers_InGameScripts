using Sandbox.ModAPI;
using Sandbox.ModAPI.Ingame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngineers_InGameScripts
{
    class Program
    {
        static void Main(string[] args)
        {
            //main method for... nothing?
        }
    }

    public abstract class ProgrammableBlockInterface : IMyGridProgram
    {
        #region IMygridProgram
        /// <summary>
        /// Writes to the detailed info pane
        /// </summary>
        public Action<string> Echo
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the elapsed time since the last execution
        /// </summary>
        public TimeSpan ElapsedTime
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Access to the full grid terminal system
        /// </summary>
        public IMyGridTerminalSystem GridTerminalSystem
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Auxiliary function. Inner works only.
        /// </summary>
        public bool HasMainMethod
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// The current programmable block
        /// </summary>
        public IMyProgrammableBlock Me
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Storage string. This is persisted between saves.
        /// </summary>
        public string Storage
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        abstract public void Main(string argument);
    }

    public class BatteryStatusScript : ProgrammableBlockInterface
    {
        public override void Main(string argument)
        {
            //all the code you want here...

            //access to the persistent string storage
            Storage = "Storage";

            //access to the current block
            Me.SetCustomName("new custom name");

            //...
        }
    }
}
