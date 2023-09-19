using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EmployeeManagerAPI.Models.Workers;

public class Employee
{
	[Key]
	public int EmployeeId { get; set; }

	[Required]
	[MaxLength(60)]
	public string? Name { get; set; }
	[Required]
	public double Salary { get; set; }
	[Required]
	public Seniority Seniority { get; set; }
	[Required]
	public DateOnly HireDate { get; set; }

	public DateOnly TerminationDate { get; set; }
	[Required]
	public ICollection<Task>? Tasks { get; set; }

}