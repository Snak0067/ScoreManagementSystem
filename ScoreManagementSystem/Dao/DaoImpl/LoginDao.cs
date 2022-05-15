using ScoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ScoreManagementSystem.Dao.DaoImpl
{
    public class LoginDao : ILoginDao
    {
        DBHelper dBHelper = new DBHelper();
        public bool Login(User user)
        {
            string sql = "select password from teacherView where tno = " + user.Username;

            DataSet dataSet = dBHelper.GetResult(sql);

            Console.WriteLine(dataSet);
            return true;

        }
    }
}