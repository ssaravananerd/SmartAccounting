using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model
{
    public class RoleModel
    {
        [BsonId]
        public ObjectId ObjectId { get; set; }

        public string RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
