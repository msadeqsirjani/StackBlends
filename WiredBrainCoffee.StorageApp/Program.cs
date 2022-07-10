using WiredBrainCoffee.StorageApp;

Repository<Employee> employeeRepository = new();
Repository<Organization> organizationRepository = new();

var thomas = new Employee("Thomas");

SaveEmployees(employeeRepository, thomas);

RemoveEmployees(employeeRepository, thomas);

SaveOrganizations(organizationRepository);

Console.WriteLine(employeeRepository.FirstOrDefault(1));
Console.WriteLine(employeeRepository.FirstOrDefault(10));

void SaveEmployees(Repository<Employee> baseRepository, Employee employee)
{
    baseRepository.Add(employee);
    baseRepository.Add(new Employee("David"));
    baseRepository.Save();
}

void RemoveEmployees(Repository<Employee> employeeRepository1, Employee thomas1)
{
    employeeRepository1.Remove(thomas1);
    employeeRepository1.Save();
}

void SaveOrganizations(Repository<Organization> organizationRepository1)
{
    organizationRepository1.Add(new Organization("Jack"));
    organizationRepository1.Save();
}