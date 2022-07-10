using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Entities.Common;
using WiredBrainCoffee.StorageApp.Repositories;

SqlRepository<Employee> employeeRepository = new();

SaveEmployee(employeeRepository, new Employee("Thomas"));
SaveManager(employeeRepository, new Manager("Smith"));
ShowEntities(employeeRepository);

ListRepository<Organization> organizationRepository = new();

SaveOrganization(organizationRepository, new Organization("Jack"));  
ShowEntities(organizationRepository);

void SaveEmployee(IWriteRepository<Employee> repository, Employee entity)
{
    repository.Add(entity);
    repository.Save();
}

void SaveManager(IWriteRepository<Manager> repository, Manager entity)
{
    repository.Add(entity);
    repository.Save();
}

void SaveOrganization(IWriteRepository<Organization> repository, Organization entity)
{
    repository.Add(entity);
    repository.Save();
}

void ShowEntities(IReadRepository<IEntity> repository)
{
    repository.Select()
        .ToList()
        .ForEach(Console.WriteLine);
}