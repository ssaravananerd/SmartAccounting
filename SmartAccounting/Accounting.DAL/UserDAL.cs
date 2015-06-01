using Accounting.DAL.Interface;
using Accounting.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Accounting.DAL
{
    public class UserDAL : IUserDAL
    {
        MySqlConnection connection;

        private void CreateDBConnection()
        {
            server = new MongoServer(new MongoServerSettings { Server = new MongoServerAddress(CommonHelper.GetAppSettings("DBServer"), int.Parse(CommonHelper.GetAppSettings("PortNo"))) });
            db = server.GetDatabase(CommonHelper.GetAppSettings("DBName"));
        }

        private void CloseDBConnection()
        {
            if (db != null)
                db = null;
            if (server != null)
                server.Disconnect();
        }


        #region IUserDAL Implementation
        string IUserDAL.RegisterUser(UserModel um)
        {
            string reply = string.Empty;
            if (um == null)
                throw new ArgumentNullException("Argument um should not a null");
            try
            {
                CreateDBConnection();
                MongoCollection<BsonDocument> userMDB = db.GetCollection<BsonDocument>("Users");
                userMDB.Insert<UserModel>(um);
                reply = "User created successfully...";
            }
            catch { reply = "Server Error. Please check error log"; throw; }
            finally
            {
                CloseDBConnection();
            }
            return reply;
        }

        bool IUserDAL.Login(LoginModel lm)
        {
            throw new NotImplementedException();
        }

        string IUserDAL.RegisterUser(RequestModel um)
        {
            throw new NotImplementedException();
        }

        bool IUserDAL.Login(RequestModel lm)
        {
            throw new NotImplementedException();
        }

        SearchResponse IUserDAL.FetchUsers(SearchRequest um)
        {
            SearchResponse response = new SearchResponse();
            try
            {
                UserModel usm = um.SearchModel as UserModel;
                CreateDBConnection();
                MongoCollection<BsonDocument> userMDB = db.GetCollection<BsonDocument>("Users");
                IMongoQuery query = {LoginId:usm.LoginId};
                userMDB.Find()
            }
            catch { throw; }
            finally { CloseDBConnection(); }
            return response;
        }
        #endregion
    }
}
