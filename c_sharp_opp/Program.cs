// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
var employee1 = new Employee("James Kabera", "IT")
{
    // employee1.Department = "Finance";
    // employee1.EmployeeName = "James Kabera";
    EmployeeGender = Employee.Gender.Male
};
Console.WriteLine(employee1.GetEmployee() +" "+ employee1.EmployeeGender);