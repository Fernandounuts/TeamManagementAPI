using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerAPI.Models.Workers.AbstractClasses;

public class AbstractWorker
{
	[Key]
	public int Id { get; set; }
	[MaxLength(60)]
	[Required]
	public string Name { get; set; }
	[Required]
	public double Salary { get; set; }
	[Required]
	public Seniority Seniority { get; set; }
	[Required]
	public DateOnly HireDate { get; set; }
	public DateOnly TerminationDate { get; set; }
}