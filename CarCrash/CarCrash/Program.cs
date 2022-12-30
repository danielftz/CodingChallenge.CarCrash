using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System;

namespace CarCrash
{
    /// <summary>
    /// Write a program, that calculates a number of individual collisions that happened based on the direction of the cars in front of the office right before the accident.
    /// All cars going left or right were going at the same speed. You can assume that a car involved in an accident stops and becomes stationary at the moment of the collision.
    /// Collision happens when a car in motion hits a car that is either moving in an opposite direction or is stationary.
    /// Any car that is involved in a collision and is in motion at the time counts as one(so head collision of two cars moving against each other counts as two, 
    /// while car hitting a stationary car counts as one).
    ///Program output
    ///Your program should take a single string as an input.The string is comprised of '>' going right), '<' (going left), and '=' (stationary) signs indicating a car direction.
    ///    Program output
    ///    Your program should output a single number indicating the number of collisions.
    ///    Examples:
    ///"><><" => 4 // two head on collisions
    ///"<=>" => 0 // cars on the sides move away and the car in the centre stays put
    ///">>=<><" => 5
    ///">>><><<><<>>==<>==<><<>><><>=><=" => 26
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert the traffic condition. '>' indicates a car going to the right, '<' indicates a car going to the left, '=' indicates a parked car. All other symbols will be ignored");
                string useInput = Console.ReadLine() ?? string.Empty;
                int result = CountCarCrash(useInput);
                Console.WriteLine($"There are a totla of {result} crashes.");
            }
            
        }

        public static int CountCarCrash(string trafficString)
        {
            int total = 0;
            int crashesToBeAdded = 0;
            CarCrashCheckingStages currentStage = CarCrashCheckingStages.WaitingToStart;
            char[] trafficList = trafficString.ToCharArray();

            foreach(char traffic in trafficList )
            {
                switch(traffic)
                {
                    case '<':
                        if (currentStage is CarCrashCheckingStages.CountingCrashes)
                        {
                            crashesToBeAdded++;
                            currentStage = CarCrashCheckingStages.WaitingToTally;
                        }
                        else if (currentStage is CarCrashCheckingStages.WaitingToTally)
                        {
                            crashesToBeAdded++;
                        }
                        break;

                    case '=':
                        if (currentStage is CarCrashCheckingStages.WaitingToStart)
                        {
                            currentStage = CarCrashCheckingStages.CountingCrashes;
                        }
                        else if (currentStage is CarCrashCheckingStages.CountingCrashes)
                        {
                            currentStage = CarCrashCheckingStages.WaitingToTally;
                        }
                        break;

                    case '>':
                        if (currentStage is CarCrashCheckingStages.WaitingToStart)
                        {
                            currentStage = CarCrashCheckingStages.CountingCrashes;
                            crashesToBeAdded++;
                        }
                        else if (currentStage is CarCrashCheckingStages.CountingCrashes)
                        {
                            crashesToBeAdded++;
                        }
                        else if (currentStage is CarCrashCheckingStages.WaitingToTally)
                        {
                            total += crashesToBeAdded;
                            currentStage = CarCrashCheckingStages.CountingCrashes;
                            crashesToBeAdded = 1;
                        }
                        break;
                }
            }

            if (currentStage is CarCrashCheckingStages.WaitingToTally)
            {
                total += crashesToBeAdded;
            }

            return total;
        }
    }

    public enum CarCrashCheckingStages
    {
        WaitingToStart,
        CountingCrashes,
        WaitingToTally
    }
}