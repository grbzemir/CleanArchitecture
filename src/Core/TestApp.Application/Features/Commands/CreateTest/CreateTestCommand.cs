using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TestApp.Application.Interfaces.Repository;
using TestApp.Application.Wrappers;

namespace TestApp.Application.Features.Commands.CreateTest
{
	public class CreateTestCommand : IRequest<ServiceResponse<Guid>>
	{
		public string Name { get; set; }
		public decimal Value { get; set; }
		public int Quantity { get; set; }

		public class CreateTestCommandHandler : IRequestHandler<CreateTestCommand, ServiceResponse<Guid>>
		{
			private readonly ITestRepository testRepository;
			private readonly IMapper mapper;

			public CreateTestCommandHandler(ITestRepository testRepository, IMapper mapper)
			{
				this.testRepository = testRepository;
				this.mapper = mapper;
			}

			public async Task<ServiceResponse<Guid>> Handle(CreateTestCommand request, CancellationToken cancellationToken)
			{
				var test = mapper.Map<Domain.Entities.Test>(request);
				test.Id = Guid.NewGuid();               
				test.CreatedAt = DateTime.UtcNow;       
				test.CreatedBy = "System";             

				await testRepository.AddAsync(test);

				return new ServiceResponse<Guid>(test.Id);
			}
		}
	}
}
