using ChunkingTask;

foreach(var (count, chunkSize) in EnumerateCases())
    if (!IsCorrect(count, chunkSize))
    {
        Console.WriteLine("Test failed!");
        break;
    }

Console.WriteLine("All tests passed!");
return;


static IEnumerable<(int Count, int ChunkSize)> EnumerateCases()
{
    yield return (0, 1);

    yield return (1, 1);
    yield return (2, 1);
    yield return (3, 1);

    yield return (5, 2);
    yield return (5, 3);

    yield return (10, 3);
    yield return (10, 4);
    yield return (10, 11);
}

static bool IsCorrect(int count, int chunkSize)
{
    Console.WriteLine();
    Console.WriteLine($"Count: {count}, chunkSize: {chunkSize}");

    var items = Enumerable.Range(0, count).ToArray();
    Console.WriteLine($"[{string.Join(", ", items)}]");

    var expected = items.Chunk(chunkSize).ToArray();
    Console.WriteLine($"{string.Join(", ", expected.Select(e => $"[{string.Join(" ", e)}]"))}");

    var actual = items.Split(chunkSize).Select(e => e.ToArray()).ToArray();
    Console.WriteLine($"{string.Join(", ", actual.Select(e => $"[{string.Join(" ", e)}]"))}");

    return expected.Length == actual.Length && 
           expected.Zip(actual).All(e => e.First.SequenceEqual(e.Second));
}