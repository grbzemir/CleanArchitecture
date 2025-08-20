using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Application.Dto;
using TestApp.Application.Interfaces.Repository;
using TestApp.Application.Wrappers;

namespace TestApp.Application.Features.Queries.GetAllTest
{
	public class GetAllTestQuery : IRequest<ServiceResponse<List<TestViewDto>>>
	{
		public class GetAllTestQueryHandler : IRequestHandler<GetAllTestQuery, ServiceResponse<List<TestViewDto>>>
		{
			private readonly ITestRepository testRepository;
			private readonly IMapper mapper;
			public GetAllTestQueryHandler(ITestRepository testRepository , IMapper mapper)
			{
				this.testRepository = testRepository;
				this.mapper = mapper;
			}

			public async Task<ServiceResponse<List<TestViewDto>>> Handle(GetAllTestQuery request, CancellationToken cancellationToken)
			{
				var tests = await testRepository.GetAllAsync();
				var viewModels = mapper.Map<List<TestViewDto>>(tests);

				return new ServiceResponse<List<TestViewDto>>(viewModels);
			}
		}
	}
}