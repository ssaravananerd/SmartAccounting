using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model
{
    public class UserModel : BaseModel
    {
        [BsonId]
        public ObjectId _Id { get; set; }

        public string LoginId { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public string LastLoginTimestamp { get; set; }

        public string RoleId { get; set; }
    }
}
