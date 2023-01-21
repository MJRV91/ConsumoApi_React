using ApiGestores.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiGestores.Context
{
	public class AppDbContext :DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{

		}
		public DbSet<Gestores_Bd> gestores_bd { get; set; }
		

		
	}
}
