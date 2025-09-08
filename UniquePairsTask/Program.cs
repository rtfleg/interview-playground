using UniquePairsTask;

int[] itemsA = [0, 2, 7, 0, 2];
int[] itemsB = [2, 1, 3, 2, 1];
int[] itemsC = [3, 2, 3, 3, 2];

foreach (var (a, b, c) in Processor.EnumerateUniqueTriplets(itemsA, itemsB, itemsC)) 
    Console.WriteLine($"{a} {b} {c}");