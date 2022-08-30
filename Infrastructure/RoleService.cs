namespace Infrastructure;
using Domain.Models;

public class RoleService
{
    private List<Role> roles;

    public RoleService()
     {
         roles = new List<Role>();
     }

    public List<Role> GetRoles()
    {
        return roles;
    }

    public void Add(Role role)
    {
        roles.Add(role);
    }

    public void Update(Role role, int id)
    {
        var find = roles.Find(x=>x.Id == id);
        find.Name = role.Name;
        find.Description = role.Description;
        find.EmployeeId = role.EmployeeId;
    }

    public Role? GetRoleById(int id)
    {
        var role =  roles.Find(element=> element.Id == id);
        return role;
    }

    public void Delete(int id)
    {
         var find = roles.Find(x=>x.Id == id);
         roles.Remove(find);
    }

    private int Count()
    {
        return roles.Count;
    }
}
