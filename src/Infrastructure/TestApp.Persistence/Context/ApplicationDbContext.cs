using Microsoft.EntityFrameworkCore;
using System;
using TestApp.Domain.Entities;

namespace TestApp.Persistence.Context
{
	public class ApplicationDbContext : DbContext
	{
		
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Test> Tests { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			    modelBuilder.Entity<Test>().HasData(
				new Test()
				{
					Id = Guid.NewGuid(),
					Name = "Test 1",
					Value = 10,
					Quantity = 1000,
					CreatedBy = "System",
					CreatedAt = DateTime.UtcNow
				},
				new Test()
				{
					Id = Guid.NewGuid(),
					Name = "Paper A4",
					Value = 1,
					Quantity = 200,
					CreatedBy = "System",
					CreatedAt = DateTime.UtcNow
				},
				new Test()
				{
					Id = Guid.NewGuid(),
					Name = "Book",
					Value = 13,
					Quantity = 550,
					CreatedBy = "System",
					CreatedAt = DateTime.UtcNow
				}
			);


			base.OnModelCreating(modelBuilder);
		}

	}
}
