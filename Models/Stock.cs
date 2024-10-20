using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_dotnet_tutorial.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        
    }
}