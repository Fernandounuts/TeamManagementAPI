using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerAPI.Models.Workers;

public class Sector
{
	[Key]
	public int Id { get; set; }
	[Required]
	[MaxLength(60)]
	public string? SectorName { get; set; }
	[Required]
	[MaxLength(200)]
	public string? SectorDescription { get; set; }
	[Required]
	public ICollection<Employee>? SectorTeam { get; set; }
	[Required]
	public ICollection<Manager>? ManagersSector { get; set; }
}