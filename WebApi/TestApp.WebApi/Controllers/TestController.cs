using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Application.Dto;
using TestApp.Application.Interfaces.Repository;

namespace TestApp.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
       private readonly ITestRepository testRepository;
        public TestController(ITestRepository testRepository)
        {
            this.testRepository = testRepository;
        }
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var allList = await testRepository.GetAllAsync();
			var result = allList.Select(i => new TestViewDto()
			{
				Id = i.Id,
				Name = i.Name,
			}).ToList();

			return Ok(result);
		}
	}
}
