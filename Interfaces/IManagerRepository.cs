using EmployeeManagerAPI.Models.Workers;

namespace EmployeeManagerAPI.Interfaces;

public interface IManagerRepository
{
	Manager getManagerById(int managerId);
	ICollection<Manager> GetManagersByName(string managerName);
	ICollection<Manager> GetManagersBySalary(decimal minSalary, decimal maxSalary);
	ICollection<Manager> GetManagersBySeniority(Seniority seniority);
	ICollection<Manager> GetManagersByDate(DateOnly minDate, DateOnly maxDate);
}