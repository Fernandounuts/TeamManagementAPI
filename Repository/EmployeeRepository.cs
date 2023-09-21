using EmployeeManagerAPI.Infra.Data;
using EmployeeManagerAPI.Interfaces;
using EmployeeManagerAPI.Models.Workers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerAPI.Repository;

public class EmployeeRepository : IEmployeeRepository
{
	public AppDbContext _context { get; }
	public EmployeeRepository(AppDbContext context)
	{
		_context = context;
	}

	public Employee GetEmployee(int employeeId)
	{
		throw new NotImplementedException();
	}

	public ICollection<Employee> GetEmployeesByName(string name)
	{
		throw new NotImplementedException();
	}

	public ICollection<Employee> GetEmployeesBySalary(decimal minSalary, decimal maxSalary)
	{
		throw new NotImplementedException();
	}

	public ICollection<Employee> GetEmployeesBySeniority(Seniority seniority)
	{
		throw new NotImplementedException();
	}

	public ICollection<Employee> GetEmployeesByHireDate(DateOnly minDate, DateOnly maxDate)
	{
		throw new NotImplementedException();
	}

	public bool EmployeeExists(int employeeId)
	{
		return _context.Employees.Any(i => i.Id == employeeId);
	}

	public bool DeleteEmployee(int employeeId)
	{
		throw new NotImplementedException();
	}

	public bool PostEmployee(Employee newEmployee)
	{
		throw new NotImplementedException();
	}

	public bool ChangeSeniority(int employeeId, Seniority seniority)
	{
		throw new NotImplementedException();
	}
}