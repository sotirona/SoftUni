
using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
    : base(id, energyOutput)
    {
        this.EnergyOutput += base.EnergyOutput / 2;
    }

    public override string ToString()
    {
        return $"Successfully registered Pressure Provider - {this.Id}";
    }

    public override string PrintCheckCommand()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Pressure Provider - {this.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().Trim();
    }
}

