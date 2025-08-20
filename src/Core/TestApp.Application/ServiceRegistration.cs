using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using AutoMapper;

namespace TestApp.Application
{
	public static class ServiceRegistration
	{
		public static void AddApplicationRegistration(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		}
	}
}
