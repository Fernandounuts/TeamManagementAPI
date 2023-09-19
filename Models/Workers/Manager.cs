using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EmployeeManagerAPI.Models.Workers;

public class Manager
{
	[Key]
	public int ManagerId { get; set; }
	[Required]
	[MaxLength(50)]
	public string? Name { get; set; }

	public double Salary { get; set; }
	public Seniority Seniority { get; set; }
	public DateOnly HireDate { get; set; }
	public DateOnly TerminationDate { get; set; }
	public ICollection<Employee>? Team { get; set; }
}