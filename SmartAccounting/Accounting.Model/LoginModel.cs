using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model
{
    public class LoginModel
    {
        [BsonId]
        public ObjectId ObjectId { get; set; }

        public string LoginId { get; set; }

        public string Password { get; set; }

    }
}
