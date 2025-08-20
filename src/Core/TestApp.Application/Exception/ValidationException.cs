using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Application.Exceptions
{
	public class ValidationException:Exception
	{
        public ValidationException(): base("Validation error occured")
        {
            
        }

        public ValidationException(String message): base(message)
        {
            
        }

        public ValidationException(Exception ex): this(ex.Message)
        {
            
        }
    }
}
