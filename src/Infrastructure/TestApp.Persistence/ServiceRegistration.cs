using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TestApp.Application.Interfaces.Repository;
using TestApp.Persistence.Context;         
using TestApp.Persistence.Repositories;     

namespace TestApp.Application
{
	public static class ServiceRegistration
	{
		public static void AddApplicationRegistration(this IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(opt =>
				opt.UseInMemoryDatabase("memoryDb"));

			services.AddTransient<ITestRepository, TestRepository>();
		}
	}
}
