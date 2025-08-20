using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Application.Mapping
{
	public class GeneralMapping:Profile
	{
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Test, Dto.TestViewDto>().ReverseMap();
        }
    }
}
