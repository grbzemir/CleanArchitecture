using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Application.Features.Queries.GetTestById
{
	public class GetTestByIdViewModel
	{
		public Guid Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public string Name { get; set; }
		public decimal Value { get; set; }
		public int Quantity { get; set; }
	}
}
