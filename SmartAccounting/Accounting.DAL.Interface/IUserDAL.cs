using Accounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DAL.Interface
{
    public interface IUserDAL
    {
        string RegisterUser(RequestModel um);

        bool Login(RequestModel lm);

        SearchResponse FetchUsers(SearchRequest um);
    }
}
