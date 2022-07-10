using WiredBrainCoffee.StorageApp.Extensions;

ListRepository<Employee> employeeRepository = new();

var anotherDan = new Employee("Dan").Clone();

SaveEntities(employeeRepository, new Employee("Dan"), new Employee("Thomas"), new Manager("Smith"));
ShowEntities(employeeRepository);

SqlRepository<Organization> organizationRepository = new();

organizationRepository.Handler += (_, _) => { Console.WriteLine("This method called fom handler"); };

organizationRepository.SaveEntities(new Organization("Jack"), new Organization("Steven"));
ShowEntities(organizationRepository);

void SaveEntities<TEntity>(IWriteRepository<TEntity> repository, params TEntity[] entities)
{
    foreach (var entity in entities)
        repository.Add(entity);

    repository.Save();
}

void ShowEntities(IReadRepository<IEntity> repository)
{
    repository.Select()
        .ToList()
        .ForEach(Console.WriteLine);
}