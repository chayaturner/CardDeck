using System;

namespace CardDeck.Helpers
{
    class ProgramFlowHelpers
    {
        internal static void StopProgram()
        {
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
