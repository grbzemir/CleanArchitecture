using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Entities;

namespace TestApp.Application.Interfaces.Repository
{
	public interface ITestRepository: IGenericRepositoryAsync<Test>
	{
		
	}
}
