

// DateTime dt = new DateTime();
// DateTimeOffset dto = new DateTimeOffset(dt);
DateTime thisHour = DateTime.Now;
// while (thisHour != null)
// {
// thisHour = DateTime.Now;
// Thread.Sleep(1000);
// Console.WriteLine(thisHour);
// }
DateTime dt = new DateTime(2022, 8, 13, 10, 30, 40);
TimeZoneInfo tzi = TimeZoneInfo.Local;

DateTime finalDate = TimeZoneInfo.ConvertTime(dt, tzi);
Console.WriteLine(finalDate);

// Console.WriteLine(tzi);

// DateTime dt = new DateTime();
// dt.AddDays(3);
// Console.WriteLine(dt.AddDays(3));
// Console.WriteLine(DateTime.DaysInMonth(2023, 2));
// string s = "2022-5-28";
// if(DateTime.TryParse(s, out dt))
// {
//     Console.WriteLine(dt);
// }
