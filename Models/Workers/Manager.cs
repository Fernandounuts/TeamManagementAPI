using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using EmployeeManagerAPI.Models.Workers.AbstractClasses;

namespace EmployeeManagerAPI.Models.Workers;

public class Manager : AbstractWorker
{
	public ICollection<Employee>? Team { get; set; }
}