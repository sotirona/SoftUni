
using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester GetHarvester(List<string> arguments)
    {
        var type = arguments[0];        
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);

        if (type=="Sonic")
        {
            var sonicFactor = int.Parse(arguments[4]);
            return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }

        return new HammerHarvester(id, oreOutput, energyRequirement);

    }


}

