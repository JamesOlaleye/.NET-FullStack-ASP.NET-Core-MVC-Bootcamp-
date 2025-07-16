using System.Globalization;

DateTime dateOfBirth = new DateTime(1990, 9, 21);
Console.WriteLine(dateOfBirth.DayOfWeek);

// computed values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now; 
DateTime utcNow = DateTime.UtcNow;

// DateTime Parsing
//DateTime localDate = DateTime.Parse("21.9.1990");
DateTime localDate = DateTime.ParseExact("21.9.1990", "d.M.yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"localDate: {localDate}");

DateTime usDate = DateTime.Parse("09/21/1990", new CultureInfo("en-US"));

Console.WriteLine($"localeDate: {localDate}, usDate: {usDate}");

Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
