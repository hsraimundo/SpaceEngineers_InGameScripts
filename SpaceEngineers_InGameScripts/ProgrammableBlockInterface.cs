using System;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Ingame;

namespace SpaceEngineersScripts
{
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
}
