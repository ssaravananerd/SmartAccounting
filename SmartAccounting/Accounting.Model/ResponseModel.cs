﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model
{
    public class ResponseModel
    {
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public BaseModel Response { get; set; }
    }
}
