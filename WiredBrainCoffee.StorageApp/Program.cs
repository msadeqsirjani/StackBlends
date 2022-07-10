using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

SqlRepository<Employee> employeeRepository = new();
ListRepository<Organization> organizationRepository = new();

var thomas = new Employee("Thomas");

SaveEmployees(employeeRepository, thomas);

RemoveEmployees(employeeRepository, thomas);

SaveOrganizations(organizationRepository);

Console.WriteLine(employeeRepository.FirstOrDefault(2));
Console.WriteLine(organizationRepository.FirstOrDefault(1));

void SaveEmployees(IRepository<Employee> repository, Employee employee)
{
    repository.Add(employee);
    repository.Add(new Employee("David"));
    repository.Save();
}

void RemoveEmployees(IRepository<Employee> repository, Employee employee)
{
    repository.Remove(employee);
    repository.Save();
}

void SaveOrganizations(IRepository<Organization> repository)
{
    repository.Add(new Organization("Jack"));
    repository.Save();
}