using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TestApp.Application.Dto;
using TestApp.Application.Interfaces.Repository;
using TestApp.Application.Wrappers;

namespace TestApp.Application.Features.Queries.GetTestById
{
	public class GetTestByIdQueryHandler : IRequestHandler<GetTestByIdQuery, ServiceResponse<GetTestByIdViewModel>>
	{
		private readonly ITestRepository testRepository;
		private readonly IMapper mapper;

		public GetTestByIdQueryHandler(ITestRepository testRepository, IMapper mapper)
		{
			this.testRepository = testRepository;
			this.mapper = mapper;
		}

		public async Task<ServiceResponse<GetTestByIdViewModel>> Handle(GetTestByIdQuery request, CancellationToken cancellationToken)
		{
			var test = await testRepository.GetByIdAsync(request.Id);
			var viewModel = mapper.Map<GetTestByIdViewModel>(test);
			return new ServiceResponse<GetTestByIdViewModel>(viewModel);
		}
	}
}
