using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Application.Interfaces.Repository;
using TestApp.Domain.Entities;
using TestApp.Persistence.Context;

namespace TestApp.Persistence.Repositories
{
	public class TestRepository : GenericRepository<Test>, ITestRepository
	{
		public TestRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}
