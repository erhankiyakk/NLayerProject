using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.DTOs
{
    public class ErrorDto
    {
        public List<String> Errors { get; set; }
        public int Status { get; set; }
        public ErrorDto()
        {
            Errors = new List<string>();
        }
    }
}
