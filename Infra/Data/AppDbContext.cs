using EmployeeManagerAPI.Models.Workers;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerAPI.Infra.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options) : base(options) { }

	public DbSet<Employee> Employees { get; set; }
	public DbSet<Manager> Managers { get; set; }
	public DbSet<Task> Tasks { get; set; }
}