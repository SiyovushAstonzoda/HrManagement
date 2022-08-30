namespace Infrastructure;
using Domain.Models;

public class EmployeeService
{
    private List<Employee> employees;

    public EmployeeService()
     {
         employees = new List<Employee>();
     }

    public List<Employee> GetEmployees()
    {
        return employees;
    }

    public void Add(Employee employee)
    {
        employees.Add(employee);
    }

    public void Update(Employee employee, int id)
    {
        var find = employees.Find(x=>x.Id == id);
        find.FirstName = employee.FirstName;
        find.LastName = employee.LastName;
        find.BirthDate = employee.BirthDate;
        find.Address = employee.Address;
        find.Phone = employee.Phone;
    }

    public Employee? GetEmployeetById(int id)
    {
        var employee =  employees.Find(element=> element.Id == id);
        return employee;
    }

    public List<Role> GetRolesByUserId(int id)
    {
        var employee =  employees.Find(element=> element.Id == id);
        return employee.Roles;
    }

    public List<Experience> GetExperiencesByUserId(int id)
    {
        var employee =  employees.Find(element=> element.Id == id);
        return employee.Experiences;
    }

    public void Delete(int id)
    {
         var find = employees.Find(x=>x.Id == id);
         employees.Remove(find);
    }

    public int Count()
    {
        return employees.Count;
    }

}
