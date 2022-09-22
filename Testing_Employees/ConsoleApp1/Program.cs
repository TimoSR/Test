// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        var employee1 = new Employee();
        
        employee1.SetDepartment(1);

        Console.WriteLine(employee1.GetDepartment());


    }

    public enum Department
    {
        HR = 1,
        Finance = 2,
        IT = 3,
        Sales = 4,
        GeneralServices = 5
    }
    
}