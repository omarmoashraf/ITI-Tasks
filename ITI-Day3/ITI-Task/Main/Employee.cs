namespace Main;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int salary { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, int salary, string department)
    {
        ID = id;
        Name = name;
        salary = salary;
        Department = department;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {ID}\nName: {Name}\nSalary: {salary}\nDepartment: {Department}");
    }

}