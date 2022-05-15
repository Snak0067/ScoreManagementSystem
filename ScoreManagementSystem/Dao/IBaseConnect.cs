using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ScoreManagementSystem.Dao
{
    public interface IBaseConnect
    {
        string ConnectionString { get; set; }

        void SetDBConnectionPararmeter(string server,
            string database,
            string username,
            string password,
            int port = 3306);

        int ExecSQL(string sqlString, object[] prams);
        int ExecSQL(string sqlString);
        DataSet ExecSQLQuery(string sqlString);
        DataSet ExecSQLQuery(string sqlString, //命令文本
            object[] prams); //参数对象

        DataSet ExecSQLQuery(string sqlString, //命令文本
            object[] prams, //参数对象
            string tbName); //数据表名称

        DataSet ExecSQLQuery(string sqlString, //命令文本
            object[] prams, //参数对象
            string tbName, //数据表名称
            ref object objcmd //返回SqlCommand
            );

        DataSet ExecSQLQuery(object objcmd); //执行SqlCommand

        object MakeInParam(string paramName, //存储过程名称或命令文本
            SqlDbType dbType, //参数类型
            int size, //参数大小
            object value); //参数值

        int SavePictureToDB(byte[] imageByte,
            string picturename,
            string picType,
            int picTypeId);

        int UpdatePictureToDb(byte[] imageByte, string pictureName, string picType, int picTypeId);

        int GetPictureFromDB(ref byte[] byPictureBytes,
            string picType,
            int picTypeId);
    }
}