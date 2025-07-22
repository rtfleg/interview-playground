var nowLocal = DateTime.Now;
var nowUtc = DateTime.SpecifyKind(nowLocal, DateTimeKind.Utc);

var result = DateTime.Compare(nowLocal, nowUtc);