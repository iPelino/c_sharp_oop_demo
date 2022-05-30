public class Employee
{
    private string EmployeeName;
    private string Department;
    public Gender EmployeeGender;

    public Employee(string employeeName, string department)
    {
        this.EmployeeName = employeeName;
        this.Department = department;
    }

    public string GetEmployee()
    {
        return $"Name: {EmployeeName} \n Department: {Department}";
    }
    
    public enum Gender
    {
        Female,
        Male,
        Other,
    }
}