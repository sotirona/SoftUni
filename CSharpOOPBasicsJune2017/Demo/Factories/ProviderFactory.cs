
using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider GetProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);

        if (type =="Solar")
        {
            return new SolarProvider(id, energyOutput);
        }

        return new PressureProvider(id, energyOutput);
    }

   
}

