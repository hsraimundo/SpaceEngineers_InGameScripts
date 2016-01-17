# SpaceEngineers_InGameScripts
InGame Scripts helper classes and actual scripts for intelisense support.

Programming "Programmable Blocks" in game is actually very complicated when trying to achieve more complex functionality. 

The aim of this project is to help on implementing these scripts using visual studio and the "ProgrammableBlockInterface" base class. Using as per the example below:

```c#
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
```
