using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TestApp.Application.Interfaces.Repository;
using TestApp.Persistence.Context;         
using TestApp.Persistence.Repositories;     

namespace TestApp.Application
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddDbContext<ApplicationDbContext>(opt =>
				opt.UseInMemoryDatabase("memoryDb"));

			serviceCollection.AddTransient<ITestRepository, TestRepository>();
		}
	}
}
