var nowLocal = DateTime.Now;
var nowUtc = DateTime.SpecifyKind(nowLocal, DateTimeKind.Utc);

Console.WriteLine(DateTime.Compare(nowLocal, nowUtc));