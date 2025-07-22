using LimitingTask;

var executor = new TaskExecutor();

await Task.WhenAll(
    Enumerable
        .Range(0, 10)
        .Select(e => executor.ExecuteAsync(e, CancellationToken.None))
);
