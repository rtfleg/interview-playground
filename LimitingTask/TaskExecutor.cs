namespace LimitingTask;

internal class TaskExecutor
{
    public async Task ExecuteAsync(int taskIdx, CancellationToken ct)
    {
        Console.WriteLine($"Started {taskIdx}");
        await Task.Delay(TimeSpan.FromSeconds(2), ct);  // Simulate payload.
        Console.WriteLine($"Finished {taskIdx}");
    }
}
