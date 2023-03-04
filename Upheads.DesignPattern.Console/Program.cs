
using Upheads.DesignPattern.BuildingBlocks;
using Upheads.DesignPattern.Consoles;

SortedDictionary<int, PatternExecutor> Executors = PatternExecutorsRegistry.Instance.GetAll();

while (!ProgramExcutor.IsTerminationRequested(out string? choice))
{
    if (ProgramExcutor.IsChoiceUnsupported(choice, out int choiceKey))
    {
        Console.WriteLine("Please choose one of the following options!");
        continue;
    }

    Executors[choiceKey].Execute();
    ProgramExcutor.WaitForContinuationSignal();
}

Console.WriteLine("Thank you!");
Console.ReadLine();