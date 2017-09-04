using System;
using System.Linq;

public class Engine
{
    private DraftManager draftManager;

    public Engine()
    {
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        string inputCommand = Console.ReadLine();

        while (inputCommand != "Shutdown")
        {
            var inputArgs = inputCommand.Split().ToList();

            string command = inputArgs[0];
            inputArgs.Remove(command);

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(inputArgs));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(inputArgs));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(inputArgs));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(inputArgs));
                    break;
            }

            inputCommand = Console.ReadLine();
        }

        Console.WriteLine(draftManager.ShutDown());

    }
}

