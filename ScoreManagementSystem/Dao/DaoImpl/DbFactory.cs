using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoreManagementSystem.Dao.DaoImpl
{
    public class DbFactory
    {
        public static IBaseConnect Create(string dBtype)
        {
            if (dBtype == "MySQL")
                return new BaseConnect();
            return new BaseConnect();
        }

        public static IBaseConnect Create(string dBtype,
            string server,
            string database,
            string username,
            string password,
            int port = 3306)
        {
            if (dBtype == "MySQL")
                return new BaseConnect(server, database, username, password, port);
            return new BaseConnect(server, database, username, password);
        }
    }
}