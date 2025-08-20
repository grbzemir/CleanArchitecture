using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Entities;

namespace TestApp.Persistence.Context
{
	public class ApplicationDbContext:DbContext
	{
		public DbSet<Test> Tests { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Test>().HasData(
				new Test() { Id = Guid.NewGuid(), Name = "Test 1", Value = 10, Quantity = 1000 },
				new Test() { Id = Guid.NewGuid(), Name = "Paper A4", Value = 1, Quantity = 200 },
				new Test() { Id = Guid.NewGuid(), Name = "Book", Value = 13, Quantity = 550 });

				base.OnModelCreating(modelBuilder);
		}
	}
}
