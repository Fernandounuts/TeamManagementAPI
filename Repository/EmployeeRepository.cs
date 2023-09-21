using EmployeeManagerAPI.Infra.Data;
using EmployeeManagerAPI.Interfaces;
using EmployeeManagerAPI.Models.Workers;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerAPI.Repository;

public class EmployeeRepository : IEmployeeRepository
{
	public AppDbContext _context { get; }
	public EmployeeRepository(AppDbContext context)
	{
		_context = context;

	}
	public bool ChangeSeniority(int employeeId, Seniority seniority)
	{
		var employee = _context.Employees.Where(i => i.Id == employeeId).FirstOrDefault();

		if (employee == null)
		{
			return false;
		}

		employee.Seniority = seniority;
		return true;
	}

	public bool DeleteEmployee(int employeeId)
	{
		var employee = _context.Employees.Where(i => i.Id == employeeId).FirstOrDefault();
		if (employee == null)
		{
			return false;
		}

		_context.Employees.Remove(employee);
		return true;
	}

	public bool EmployeeExists(int employeeId)
	{
		return _context.Employees.Any(i => i.Id == employeeId);
	}

	public async Task<ICollection<Employee>> GetEmployeesByHireDate(DateOnly minDate, DateOnly maxDate)
	{
		var employeeArr = await _context.Employees.Where(e => e.HireDate >= minDate && e.HireDate <= maxDate).ToArrayAsync();
		if (employeeArr == null)
		{
			throw new NullReferenceException("No employees were found between those dates");
		}
		return employeeArr;
	}

	public async Task<ICollection<Employee>> GetEmployeesByName(string name)
	{
		var employeeArr = await _context.Employees.Where(i => i.Name == name).ToListAsync();
		if (employeeArr == null)
		{
			throw new NullReferenceException("employeeArr cannot be null");
		}
		return employeeArr;
	}

	public async Task<ICollection<Employee>> GetEmployeesBySalary(double minSalary, double maxSalary)
	{
		var employeeArr = await _context.Employees.Where(e => e.Salary >= minSalary && e.Salary <= maxSalary).ToArrayAsync();

		if (employeeArr == null || employeeArr.Length <= 0)
		{
			throw new NullReferenceException("No employee found in the specified range");
		}
		return employeeArr;
	}

	public async Task<ICollection<Employee>> GetEmployeesBySeniority(Seniority seniority)
	{
		var employeeArr = await _context.Employees.Where(e => e.Seniority == seniority).ToArrayAsync();

		if (employeeArr == null || employeeArr.Length <= 0)
		{
			throw new NullReferenceException("No employees found with this specified seniority");
		}
		return employeeArr;
	}

	public bool PostEmployee(Employee newEmployee)
	{
		if (newEmployee == null)
		{
			throw new NullReferenceException("No new employee to be posted in the database was specified");
		}
		_context.Employees.Add(newEmployee);
		_context.SaveChangesAsync();
		return true;

	}

	public async Task<Employee> GetEmployeeById(int employeeId)
	{
		var employee = await _context.Employees.Where(e => e.Id == employeeId).FirstOrDefaultAsync();

		if (employee == null)
		{
			throw new NullReferenceException("The employee doesn't exist");
		}
		return employee;
	}
}
