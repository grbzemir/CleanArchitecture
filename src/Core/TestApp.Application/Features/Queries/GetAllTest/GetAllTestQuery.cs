using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Application.Dto;
using TestApp.Application.Interfaces.Repository;

namespace TestApp.Application.Features.Queries.GetAllTest
{
	public class GetAllTestQuery:IRequest<List<TestViewDto>>
	{
		public class GetAllTestQueryHandler : IRequestHandler<GetAllTestQuery, List<TestViewDto>>
		{
			private readonly ITestRepository testRepository;

			public GetAllTestQueryHandler(ITestRepository testRepository)
			{
				this.testRepository = testRepository;
			}

			public async Task<List<TestViewDto>> Handle(GetAllTestQuery request, CancellationToken cancellationToken)
			{
				var tests = await testRepository.GetAllAsync();
				return tests.Select(i => new TestViewDto()
				{
					Id = i.Id,
					Name = i.Name,
				}).ToList();
			}
		}
	}
}
