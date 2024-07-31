using CsvHelper.Configuration.Attributes;

class Employee
{
    [Name("First Name")]
    public string? FirstName { get; set; }

    [Name("Last Name")]
    public string? LastName { get; set; }

    [Name("Joined Date")]
    public DateOnly? JoinedDate { get; set; }

    [Name("Salary")]
    public decimal? Salary { get; set; }

    [Name("Active")]
    public string? Active { get; set; }
}