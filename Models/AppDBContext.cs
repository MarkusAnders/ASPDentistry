using Microsoft.EntityFrameworkCore;

namespace ASPDentistry.Models
{
	public class AppDBContext : DbContext
	{
		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{

		}
		public DbSet<Client> Clients { get; set; }
		public DbSet<Service> Services { get; set; }
	}
}
