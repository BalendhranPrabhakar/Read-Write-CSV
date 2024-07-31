using CsvHelper;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<Employee> 
        {
   new Employee 
   {
      FirstName = "John", LastName = "Doe", JoinedDate = new DateOnly(2020, 1, 1), Salary = 50000.00M, Active = "Yes"
   },
   new Employee 
   {
      FirstName = "Jane", LastName = "Doe", JoinedDate = new DateOnly(2021, 6, 15), Salary = 60000.00M, Active = "Yes"
   },
   new Employee 
   {
      FirstName = "Bob", LastName = "Smith", JoinedDate = new DateOnly(2019, 3, 10), Salary = 70000.00M, Active = "No"
   }
};


        using var writer = new StreamWriter("output.csv");
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);


        csv.WriteHeader<Employee>();
        csv.NextRecord();
        foreach (var employee in employees)
        {
            csv.WriteRecord(employee);
            csv.NextRecord();
        }

    }
}