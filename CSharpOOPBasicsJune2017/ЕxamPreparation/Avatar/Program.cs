
using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string command =  Console.ReadLine();

        var nationsBuilder = new NationsBuilder();
        
        while (command!="Quit")
        {
            var commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            switch (commandArgs[0])
            {
                case "Bender":
                    nationsBuilder.AssignBender(commandArgs);
                    break;
                case "Monument":
                    nationsBuilder.AssignMonument(commandArgs);
                    break;
                case "Status":
                    Console.WriteLine(nationsBuilder.GetStatus(commandArgs[1]));
                    break;
                case "War":
                   
                    nationsBuilder.IssueWar(commandArgs[1]);
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(nationsBuilder.GetWarsRecord());
    }
}

