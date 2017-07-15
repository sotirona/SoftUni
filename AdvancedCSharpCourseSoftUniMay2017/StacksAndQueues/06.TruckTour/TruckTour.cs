using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TruckTour
{
    public class TruckTour
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<GasPump> pumps = new Queue<GasPump>();

            for (int i = 0; i < n; i++)
            {
                int[] pumpInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int distanceToNext = pumpInfo[1];
                int amountOfGas = pumpInfo[0];

                GasPump pump = new GasPump(distanceToNext, amountOfGas,i);

                pumps.Enqueue(pump);                
            }

            GasPump starterPump = null;
            bool completeJourney = false;
            
            while (true)
            {
                GasPump currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);

                starterPump = currentPump;
                int gasInTank = currentPump.amountOfGas;

                while (gasInTank>=currentPump.DistanceToNext)
                {
                    gasInTank -= currentPump.DistanceToNext;

                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);

                    if (currentPump ==starterPump)
                    {
                        completeJourney = true;
                        break;
                    }
                    gasInTank += currentPump.amountOfGas;
                }
                if (completeJourney)
                {
                    Console.WriteLine(starterPump.indexOfPump);
                    break;
                }
            }
            
        }
    }

    public class GasPump
    {
        public int DistanceToNext;
        public int amountOfGas;
        public int indexOfPump;

        public GasPump(int DistanceToNext, int amountOfGas, int indexOfPump)
        {
            this.DistanceToNext = DistanceToNext;
            this.amountOfGas = amountOfGas;
            this.indexOfPump = indexOfPump;
        }
    }
}
