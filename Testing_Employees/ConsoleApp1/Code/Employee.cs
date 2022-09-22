namespace ConsoleApp1.Code;

public class Employee
{
    private int _cpr;
    
    private string _firstName;
    
    private string _lastName;
    
    // I use the enums to have track of what numbers translates to

    public enum Department
    {
        HR = 9,
        Finance = 2,
        IT = 3,
        Sales = 4,
        GeneralServices = 5
    }
    
    private Department _department;

    private int _baseSalary;

    // I use the enums to have track of what numbers translates to
    
    public enum EducationalLevel
    {
        None = 0,
        Primary = 1,
        Secondary = 2,
        Tertiary = 3
    }

    private int _educationalLevel;

    private DateOnly _dateOfBirth;

    private DateOnly _dateOfEmployment;

    private string _country;

    public void SetCpr(int cpr)
    {
        _cpr = cpr;
    }

    public int GetCpr()
    {
        return _cpr;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }

    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public void SetDepartment(string department)
    {
        switch (department)
        {
            case "HR":
                _department = Department.HR;
                break;
            case "Finance":
                _department = Department.Finance;
                break;
            case "IT":
                _department = Department.IT;
                break;
            case "Sales":
                _department = Department.Sales;
                break;
            case "General Services":
                _department = Department.GeneralServices;
                break;
            default:
                Console.WriteLine("Error: Department don't exist");
                break;
        }

    }


    public void SetDepartment(int department)
    {
        switch (department)
        {
            case 1:
                _department = Department.HR;
                break;
            case 2:
                _department = Department.Finance;
                break;
            case 3:
                _department = Department.IT;
                break;
            case 4:
                _department = Department.Sales;
                break;
            case 5:
                _department = Department.GeneralServices;
                break;
            default:
                Console.WriteLine("Error: Department don't exist");
                break;
        }

    }



    public Department GetDepartment()
    {
        return _department;
    }

    public void SetBaseSalary(int baseSalary)
    {
        _baseSalary = baseSalary;
    }

    public int GetBaseSalary()
    {
        return _baseSalary;
    }

    public void SetEducationLevel(int educationalLevel)
    {
        _educationalLevel = educationalLevel;
    }

    public int GetEducationalLevel()
    {
        return _educationalLevel;
    }




}