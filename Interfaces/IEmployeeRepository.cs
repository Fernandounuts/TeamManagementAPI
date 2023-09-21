using EmployeeManagerAPI.Models.Workers;

namespace EmployeeManagerAPI.Interfaces;

public interface IEmployeeRepository
{
	Task<Employee> GetEmployeeById(int employeeId);
	Task<ICollection<Employee>> GetEmployeesByName(string name);
	Task<ICollection<Employee>> GetEmployeesBySalary(double minSalary, double maxSalary);
	Task<ICollection<Employee>> GetEmployeesBySeniority(Seniority seniority);
	Task<ICollection<Employee>> GetEmployeesByHireDate(DateOnly minDate, DateOnly maxDate);
	bool EmployeeExists(int employeeId);
	bool DeleteEmployee(int employeeId);
	bool PostEmployee(Employee newEmployee);
	bool ChangeSeniority(int employeeId, Seniority seniority);
}