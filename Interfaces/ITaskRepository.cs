using EmployeeManagerAPI.Models.Workers;

namespace EmployeeManagerAPI.Interfaces;

public interface ITaskRepository
{
	Task GetTask(int taskId);
	ICollection<Manager> GetManagers(int taskId);
	ICollection<Employee> GetTeam(int taskId);
	bool TaskExists(int taskId);
	bool PostTask(Task newTask);
	bool DeleteTask(int taskId);
	bool UpdateTask(int taskId);
}