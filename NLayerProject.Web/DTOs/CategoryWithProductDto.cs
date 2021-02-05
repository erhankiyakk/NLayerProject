using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTOs
{
    public class CategoryWithProductDto:CategoryDto
    {
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
