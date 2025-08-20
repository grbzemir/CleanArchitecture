using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Application.Dto;
using TestApp.Application.Wrappers;

namespace TestApp.Application.Features.Queries.GetTestById
{
	public class GetTestByIdQuery : IRequest<ServiceResponse<GetTestByIdViewModel>>
	{
        public Guid Id { get; set; }

        public GetTestByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
