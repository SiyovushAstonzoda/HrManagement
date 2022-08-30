namespace Infrastructure;
using Domain.Models;

public class DepartmentService
{
    private List<Department> departments;

    public DepartmentService()
     {
         departments = new List<Department>();
     }

    public List<Department> GetDepartments()
    {
        return departments;
    }

    public void Add(Department department)
    {
        departments.Add(department);
    }

    public void Update(Department department, int id)
    {
        var find = departments.Find(x=>x.Id == id);
        find.Name = department.Name;
        find.Description = department.Description;
    }

    public Department? GetDepartmentById(int id)
    {
        var department =  departments.Find(element=> element.Id == id);
        return department;
    }

    public void Delete(int id)
    {
         var find = departments.Find(x=>x.Id == id);
         departments.Remove(find);
    }

    private int Count()
    {
        return departments.Count;
    }
}
