using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using EmployeeManagerAPI.Models.Workers.AbstractClasses;

namespace EmployeeManagerAPI.Models.Workers;

public class Employee : AbstractWorker
{

	[Required]
	public ICollection<Task>? Tasks { get; set; }

}