using System.ComponentModel.DataAnnotations;
using EmployeeManagerAPI.Models.Workers;

namespace EmployeeManagerAPI.Models.Tasks;

public class Task
{
	[Key]
	public int Id { get; set; }
	[MaxLength(60)]
	[Required]
	public string? TaskName { get; set; }
	[Required]
	public ICollection<Employee>? TaskTeam { get; set; }
	[Required]
	public ICollection<Manager>? TaskManagers { get; set; }
	public DateOnly DeadlineDate { get; set; }
}