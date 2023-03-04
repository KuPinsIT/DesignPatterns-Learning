using Upheads.DesignPattern.BuildingBlocks;

namespace Upheads.DesignPattern.Consoles
{

    public static class ProgramExcutor
    {
        private const string ExitCode = "q";
        private static readonly SortedDictionary<int, PatternExecutor> Executors = PatternExecutorsRegistry.Instance.GetAll();

        public static bool IsTerminationRequested(out string? choice)
        {
            ShowAvailableMenuOptions();
            choice = ChooseOneOptionFromMenu();

            return choice is ExitCode;
        }

        private static void ShowAvailableMenuOptions()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Environment.NewLine);

            foreach (var executor in Executors)
            {
                Console.WriteLine($"{executor.Key}. {executor.Value.Name}");
            }

            Console.WriteLine($"{ExitCode}. Quit");
        }

        private static string? ChooseOneOptionFromMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nYour choice: ");

            var choice = Console.ReadLine();

            Console.ResetColor();

            return choice;
        }

        public static bool IsChoiceUnsupported(string? choice, out int choiceKey)
        {
            if (choice == null || !int.TryParse(choice, out int key) || !Executors.ContainsKey(key))
            {
                choiceKey = -1;
                return true;
            }

            choiceKey = key;
            return false;
        }

        public static void WaitForContinuationSignal()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nExecution results can be found above. Press ENTER to continue.");
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
