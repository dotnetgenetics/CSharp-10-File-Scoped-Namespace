namespace FileScopedNamespace;
internal class Program
{
    /// <summary>
    /// Replace nested namespace and class
    /// </summary>
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.ID = 1001;
        employee.Name = "Greg Esguerra";
        employee.Address = "Cebu Philippines";
        Console.WriteLine($"{employee.ID}, {employee.Name}, {employee.Address}");
        Console.ReadLine();
    }
}
