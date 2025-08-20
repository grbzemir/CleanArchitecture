using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Common;

namespace TestApp.Domain.Entities
{
	public class Test: BaseEntity
	{
		public string Name { get; set; }
		public decimal Value { get; set; }	
		public int Quantity { get; set; }
	}
}
