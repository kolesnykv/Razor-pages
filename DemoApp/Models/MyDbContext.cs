using System;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Models
{
	public class MyDbContext : DbContext
	{
		public MyDbContext()
		{
		}

		public DbSet<Person> People { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("MyDb");
		}
	}
}

