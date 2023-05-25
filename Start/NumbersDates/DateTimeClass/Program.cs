// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime myTimeNow = DateTime.Now; //time
System.Console.WriteLine(myTimeNow);

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today; // midnight
System.Console.WriteLine(today);


// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly date = DateOnly.FromDateTime(DateTime.Now);
System.Console.WriteLine(date);

TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
System.Console.WriteLine(time);


// TODO: Dates have properties that can be inspected
System.Console.WriteLine(today.DayOfWeek);
System.Console.WriteLine(today.DayOfYear);


// TODO: Dates also have methods to change their values
DateTime nextTime =  today.AddDays(5); // AddHours  AddMonths
System.Console.WriteLine(nextTime);


// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(today.Year, 4, 1);
DateTime NewYears = new DateTime(today.Year, 1, 1);

TimeSpan interval = AprilFools - NewYears;
System.Console.WriteLine(interval);



// TODO: Dates can be compared using regular operators
System.Console.WriteLine( AprilFools > NewYears);
System.Console.WriteLine( AprilFools < NewYears);