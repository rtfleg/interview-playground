using BinarySerialization;

const string path = "test.bin";

// Create storage.
var storage = new TracesFileStorage();

// Create array of traces.
var initialTraces = new[]
{
    new Trace(1, 80, 100.234),
    new Trace(2, 81, 101.3),
    new Trace(3, 82, 102)
};

// Write traces to file.
storage.WriteToFile(path, initialTraces);

// Read traces from the same file.
var deserializedTraces = storage.ReadFromFile(path);

// Technically our traces should be the same!
var isSuccess = initialTraces.SequenceEqual(deserializedTraces);