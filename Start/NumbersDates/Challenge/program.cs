DateTime today = DateTime.Today;

string thedate;

DateTime parsedDate;

TimeSpan ts;

do
{
    Console.WriteLine("Enter your date");
    thedate = Console.ReadLine();

    if (DateTime.TryParse(thedate, out parsedDate))
    {
        if (today > parsedDate)
        {
            ts = today - parsedDate;
            Console.WriteLine($"{ts.Days} days ago!");
        }
        else if (today < parsedDate)
        {
            ts = parsedDate - today;
            Console.WriteLine($"{ts.Days} more days to go!");
        }
        else
        {
            Console.WriteLine("it's today!!!");
        }

    }
    else
    {
        Console.WriteLine("can't get parsed");
    }
}
while (thedate != "exit");
