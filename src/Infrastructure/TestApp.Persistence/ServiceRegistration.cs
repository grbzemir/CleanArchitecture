using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TestApp.Application.Interfaces.Repository;
using TestApp.Persistence.Context;
using TestApp.Persistence.Repositories;

namespace TestApp.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceRegistration(this IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(opt =>
				opt.UseInMemoryDatabase("memoryDb"));

			services.AddTransient<ITestRepository, TestRepository>();
		}
	}
}
