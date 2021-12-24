
var nadeem = new Person
{
    FullName = "Nadeem Lari",
    DateOfBirth = new DateOnly(2001, 6, 21)
};
var (fullName, dateOfBirth) = nadeem;

Console.WriteLine($"The name is {fullName} , born in {dateOfBirth:MMM dd}");

var (name, _) = nadeem;

var dictionary = new Dictionary<string, int>
{
    {"Nadeem", 2001}
};

var (key, value) = dictionary.First();

var dob = new DateOnly(2001, 6, 21);
var (year, month, day) = dob;

Console.WriteLine($"The name is {name}");
public class Person
{
    public string FullName { get; init; } = "";
    public DateOnly DateOfBirth { get; set; }

    public void Deconstruct(out string fullName, out DateOnly dateOfBirth)
    {
        fullName = FullName;
         dateOfBirth=DateOfBirth;
    }
}

public static class DeconstructExtension
{
    public static void Deconstruct(this DateOnly dateOnly, out int year, out int month, out int day)
    {
        year = dateOnly.Year;
        month = dateOnly.Month;
        day = dateOnly.Day;
    }
}