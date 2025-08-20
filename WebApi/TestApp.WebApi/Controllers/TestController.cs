using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Application.Dto;
using TestApp.Application.Features.Queries.GetAllTest;
using TestApp.Application.Interfaces.Repository;

namespace TestApp.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
       private readonly IMediator mediator;
        public TestController(IMediator mediator)
        {
           this.mediator = mediator;
        }
		[HttpGet]
		public async Task<IActionResult> Get()
		{
		   var query = new GetAllTestQuery();
		   return Ok(await mediator.Send(query));
		}
	}
}
