using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model
{
    public class SearchResponse
    {
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public Dictionary<string,BaseModel> Response { get; set; }
    }
}
