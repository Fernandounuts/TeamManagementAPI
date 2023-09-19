using EmployeeManagerAPI.Models.Workers;

namespace EmployeeManagerAPI.Interfaces;

public interface IEmployeeRepository
{
	Employee GetEmployee(int employeeId);
	ICollection<Employee> GetEmployeesByName(string name);
	ICollection<Employee> GetEmployeesBySalary(decimal minSalary, decimal maxSalary);
	ICollection<Employee> GetEmployeesBySeniority(Seniority seniority);
	ICollection<Employee> GetEmployeesByHireDate(DateOnly minDate, DateOnly maxDate);
	bool EmployeeExists(int employeeId);
	bool DeleteEmployee(int employeeId);
	bool PostEmployee(Employee newEmployee);
	bool ChangeSeniority(int employeeId, Seniority seniority);
}