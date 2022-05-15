using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ScoreManagementSystem.Dao.DaoImpl
{
    public class BaseConnect : IBaseConnect
    {
        public string ConnectionString { get; set; }

        public BaseConnect()
        {
            ConnectionString = "";
        }

        public BaseConnect(string server,
            string database,
            string username,
            string password,
            int port = 3306)
        {
            ConnectionString = "Data Source=" + server + //创建数据库连接串
                               ";DataBase=" + database +
                               ";User ID=" + username +
                               ";Password=" + password +
                               ";Port=" + port +
                               ";Charset=utf8" +
                               ";default command timeout=0" + //此字符表示将命令超时时间改为无限等待
                               ";Allow Zero DateTime=True"; //此字符串用于将数据库的DateTime类型装换
        }

        public void Dispose()
        {
        }

        public void SetDBConnectionPararmeter(string server,
            string database,
            string username,
            string password,
            int port = 3306)
        {
            ConnectionString = "Data Source=" + server + //创建数据库连接串
                               ";DataBase=" + database +
                               ";User ID=" + username +
                               ";Password=" + password +
                               ";Port=" + port +
                               ";Charset=utf8";
        }

        /// <summary>
        /// 保存图片到数据库
        /// </summary>
        /// <param name="imageByte"></param>
        /// <param name="picturename"></param>
        /// <param name="picType"></param>
        /// <param name="picTypeId"></param>
        /// <returns></returns>
        public int SavePictureToDB(byte[] imageByte,
            string picturename,
            string picType,
            int picTypeId)
        {
            var result = 0;
            try
            {
                if (imageByte != null && imageByte.Length != 0)
                {
                    using (var conn = new MySqlConnection())
                    {
                        conn.ConnectionString = ConnectionString;
                        conn.Open();

                        var insertStr = @"INSERT INTO studentmanager.picture 
                                                    (
                                                    Picturename, 
                                                    PicType, 
                                                    PicTypeId, 
                                                    imageByte
                                                    )
                                                    VALUES
                                                    (
                                                    @Picturename, 
                                                    @PicType, 
                                                    @PicTypeId, 
                                                    @imageByte
                                                    );";
                        var comm = new MySqlCommand();
                        comm.Connection = conn;
                        comm.CommandText = insertStr;
                        comm.CommandType = CommandType.Text;

                        //设置数据库字段类型MediumBlob的值为图片字节数组imageByte
                        comm.Parameters.Add(new MySqlParameter("@imageByte", MySqlDbType.MediumBlob)).Value = imageByte;
                        comm.Parameters.Add(new MySqlParameter("@Picturename", MySqlDbType.VarChar)).Value = picturename;
                        comm.Parameters.Add(new MySqlParameter("@PicType", MySqlDbType.VarChar)).Value = picType;
                        comm.Parameters.Add(new MySqlParameter("@PicTypeId", MySqlDbType.Int32)).Value = picTypeId;
                        //execute sql
                        result = comm.ExecuteNonQuery();

                        comm.Dispose();
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                // throw ex;
            }
            return result;
        }

        /// <summary>
        /// 更新图片
        /// </summary>
        /// <param name="imageByte"></param>
        /// <param name="pictureName"></param>
        /// <param name="picType"></param>
        /// <param name="picTypeId"></param>
        /// <returns></returns>
        public int UpdatePictureToDb(byte[] imageByte, string pictureName, string picType, int picTypeId)
        {
            var result = 0;
            try
            {
                if (imageByte != null && imageByte.Length != 0)
                {
                    using (var conn = new MySqlConnection())
                    {
                        conn.ConnectionString = ConnectionString;
                        conn.Open();

                        var insertStr = @"UPDATE studentmanager.picture 
                                                    SET
                                                    Picturename = @Picturename , 
                                                    imageByte = @imageByte

                                                    WHERE
                                                    PicType = @PicType AND PicTypeId = @PicTypeId ";
                        var comm = new MySqlCommand
                        {
                            Connection = conn,
                            CommandText = insertStr,
                            CommandType = CommandType.Text
                        };

                        //设置数据库字段类型MediumBlob的值为图片字节数组imageByte
                        comm.Parameters.Add(new MySqlParameter("@imageByte", MySqlDbType.MediumBlob)).Value = imageByte;
                        comm.Parameters.Add(new MySqlParameter("@Picturename", MySqlDbType.VarChar)).Value = pictureName;
                        comm.Parameters.Add(new MySqlParameter("@PicType", MySqlDbType.VarChar)).Value = picType;
                        comm.Parameters.Add(new MySqlParameter("@PicTypeId", MySqlDbType.Int32)).Value = picTypeId;
                        //execute sql
                        result = comm.ExecuteNonQuery();

                        comm.Dispose();
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                // throw ex;
            }
            return result;
        }

        public int GetPictureFromDB(ref byte[] byPictureBytes,
            string picType,
            int picTypeId)
        {
            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    //设置命令参数
                    var sqLstring = $@"SELECT  
                                        imageByte

                                        FROM 
                                        studentmanager.picture 
                                        WHERE PicType ='{picType}' AND PicTypeId='{picTypeId}'";
                    var comm = new MySqlCommand(sqLstring, conn);

                    //执行命令并获得数据读取器
                    var dr = comm.ExecuteReader();
                    if (dr.Read())
                    {
                        try
                        {
                            //读出图片字节数组至byte[]
                            var len = dr.GetBytes(0, 0, null, 0, int.MaxValue);
                            byPictureBytes = new byte[len];
                            if (byPictureBytes.Length != 0)
                                dr.GetBytes(0, 0, byPictureBytes, 0, byPictureBytes.Length);
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                    dr.Dispose();
                    comm.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception)
            {
                // throw ex;
            }
            return 0;
        }

        public DataSet ExecSQLQuery(string sqlString, object[] prams)
        {
            MySqlDataAdapter dap;
            DataSet dsRet = null;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("ConnectionString Error");
            }

            if (string.IsNullOrEmpty(sqlString))
            {
                throw new Exception("SQL String Error");
            }

            if (!DsafConnectionTest())
            {
                throw new Exception("Database Connect Error");
            }

            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    dap = CreateDataAdaper(sqlString, prams, conn); //创建桥接器对象
                    dsRet = new DataSet(); //创建数据集对象
                    dap.Fill(dsRet); //填充数据集

                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException)
            {
                // // throw ex;
            }
            catch (Exception)
            {
                //  // throw ex;
            }
            return dsRet; //返回数据集
        }

        /// <summary>
        ///     初始化参数值
        /// </summary>
        private object MakeParam(string paramName, //存储过程名称或命令文本
            MySqlDbType dbType, //参数类型
            int size, //参数大小
            ParameterDirection direction, //参数方向
            object value) //参数值
        {
            MySqlParameter param; //声明SQL参数对象
            if (size > 0) //判断参数字段是否大于0
                param = new MySqlParameter(paramName, dbType, size); //根据指定的类型和大小创建SQL参数
            else
                param = new MySqlParameter(paramName, dbType); //根据指定的类型创建SQL参数

            param.Direction = direction; //设置SQL参数的类型
            if (!(direction == ParameterDirection.Output && value == null)) //判断是否为输出参数
                param.Value = value; //设置参数返回值

            //转换object对象返回
            return param; //返回SQL参数
        }

        #region 将命令文本添加到SqlDataAdapter

        /// <summary>
        ///     创建一个SqlDataAdapter对象以此来执行命令文本
        /// </summary>
        private MySqlDataAdapter CreateDataAdaper(string sqLstring, //命令文本
            object[] prams,
            MySqlConnection conn) //参数对象
        {
            var dap = new MySqlDataAdapter(sqLstring, conn); //创建桥接器对象
            dap.SelectCommand.CommandType = CommandType.Text; //指定要执行的类型为命令文本

            if (prams != null) //判断SQL参数是否不为空
            {
                foreach (var parameter in prams) //遍历传递的每个SQL参数
                {
                    var param = (MySqlParameter)parameter;
                    dap.SelectCommand.Parameters.Add(param); //将SQL参数添加到执行命令对象中
                }
            }

            //加入返回参数
            dap.SelectCommand.Parameters.Add(new MySqlParameter("ReturnValue",
                MySqlDbType.Int32,
                4,
                ParameterDirection.ReturnValue,
                false,
                0,
                0,
                string.Empty,
                DataRowVersion.Default,
                null));


            //返回桥接器对象
            return dap;
        }

        #endregion

        #region   将命令文本添加到SqlCommand

        /// <summary>
        ///     创建一个SqlCommand对象以此来执行命令文本
        /// </summary>
        private MySqlCommand CreateCommand(string procName, //命令文本
            object[] prams,
            MySqlConnection conn) //命令文本所需参数
        {
            var cmd = new MySqlCommand(procName, conn); //创建SqlCommand命令对象
            cmd.CommandType = CommandType.Text; //指定要执行的类型为命令文本

            // 依次把参数传入命令文本
            if (prams != null) //判断SQL参数是否不为空
            {
                foreach (var parameter in prams) //遍历传递的每个SQL参数
                {
                    var param = (MySqlParameter)parameter;
                    cmd.Parameters.Add(param); //将SQL参数添加到执行命令对象中
                }
            }

            //加入返回参数
            cmd.Parameters.Add(new MySqlParameter("ReturnValue",
                MySqlDbType.Int32,
                4,
                ParameterDirection.ReturnValue,
                false,
                0,
                0,
                string.Empty,
                DataRowVersion.Default,
                null));

            //返回SqlCommand命令对象
            return cmd;
        }

        #endregion

        #region   执行参数命令文本(无数据库中数据返回)

        /// <summary>
        ///     执行命令
        /// </summary>
        public int ExecSQL(string sqlString, //命令文本
            object[] prams) //参数对象
        {
            var nRet = 0;
            MySqlCommand cmd;
            MySqlTransaction transaction = null;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("ConnectionString Error");
            }

            if (string.IsNullOrEmpty(sqlString))
            {
                throw new Exception("SQL String Error");
            }

            if (!DsafConnectionTest())
            {
                throw new Exception("Database Connect Error");
            }

            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    transaction = conn.BeginTransaction();
                    cmd = CreateCommand(sqlString, prams, conn); //创建SqlCommand命令对象
                    cmd.Transaction = transaction;

                    nRet = cmd.ExecuteNonQuery(); //执行SQL命令
                    transaction.Commit();

                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException)
            {
                transaction?.Rollback();
            }
            catch (Exception)
            {
                // ignored
            }
            return nRet;
        }

        /// <summary>
        ///     直接执行SQL语句
        /// </summary>
        public int ExecSQL(string sqlString)
        {
            var nRet = 0;

            MySqlCommand cmd;
            MySqlTransaction transaction = null;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("ConnectionString Error");
            }

            if (string.IsNullOrEmpty(sqlString))
            {
                throw new Exception("SQL String Error");
            }

            if (!DsafConnectionTest())
            {
                throw new Exception("Database Connect Error");
            }

            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    transaction = conn.BeginTransaction();
                    cmd = new MySqlCommand(sqlString, conn); //创建SqlCommand命令对象
                    cmd.Transaction = transaction;
                    nRet = cmd.ExecuteNonQuery(); //执行SQL命令
                    transaction.Commit();

                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException)
            {
                transaction?.Rollback();
            }
            catch (Exception)
            {
                // ignored
            }
            //返回>0，表示执行成功
            return nRet;
        }

        #region   执行参数命令文本(有返回值)

        /// <summary>
        ///     执行查询命令文本，并且返回DataSet数据集
        /// </summary>
        public DataSet ExecSQLQuery(string sqlString, //命令文本
            object[] prams, //参数对象
            string tbName) //数据表名称
        {
            MySqlDataAdapter dap;
            DataSet dsRet = null;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("ConnectionString Error");
            }

            if (string.IsNullOrEmpty(sqlString))
            {
                throw new Exception("SQL String Error");
            }

            if (!DsafConnectionTest())
            {
                throw new Exception("Database Connect Error");
            }

            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    dap = CreateDataAdaper(sqlString, prams, conn); //创建桥接器对象
                    dsRet = new DataSet(); //创建数据集对象
                    dap.Fill(dsRet, tbName); //填充数据集

                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException)
            {
                // // throw ex;
            }
            catch (Exception)
            {
                //  // throw ex;
            }
            return dsRet; //返回数据集
        }

        public DataSet ExecSQLQuery(string sqlString, //命令文本
            object[] prams, //参数对象
            string tbName, //数据表名称
            ref object cmd //返回SQL command
            )
        {
            MySqlDataAdapter dap;
            DataSet dsRet = null;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("ConnectionString Error");
            }

            if (string.IsNullOrEmpty(sqlString))
            {
                throw new Exception("SQL String Error");
            }

            if (!DsafConnectionTest())
            {
                throw new Exception("Database Connect Error");
            }

            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    dap = CreateDataAdaper(sqlString, prams, conn); //创建桥接器对象
                    dsRet = new DataSet(); //创建数据集对象
                    dap.Fill(dsRet, tbName); //填充数据集

                    cmd = dap.SelectCommand;

                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException)
            {
                // throw ex;
            }
            catch (Exception)
            {
                // throw ex;
            }
            return dsRet; //返回数据集
        }

        //执行一个SQL命令体
        public DataSet ExecSQLQuery(object cmd) //命令对象
        {
            MySqlDataAdapter dap;
            DataSet dsRet = null;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("ConnectionString Error");
            }

            if (!DsafConnectionTest())
            {
                throw new Exception("Database Connect Error");
            }

            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    dap = new MySqlDataAdapter((MySqlCommand)cmd); //创建桥接器对象
                    dsRet = new DataSet(); //创建数据集对象
                    dap.Fill(dsRet); //填充数据集

                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException)
            {
                // throw ex;
            }
            catch (Exception)
            {
                // throw ex;
            }
            return dsRet; //返回数据集
        }

        public DataSet ExecSQLQuery(string sqlString)
        {
            MySqlDataAdapter dap;
            DataSet dsRet = null;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("ConnectionString Error");
            }

            if (string.IsNullOrEmpty(sqlString))
            {
                throw new Exception("SQL String Error");
            }

            if (!DsafConnectionTest())
            {
                throw new Exception("Database Connect Error");
            }

            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    dap = CreateDataAdaper(sqlString, null, conn); //创建桥接器对象
                    dsRet = new DataSet(); //创建数据集对象
                    dap.Fill(dsRet); //填充数据集

                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException)
            {
                // throw ex;
            }
            catch (Exception)
            {
                // throw ex;
            }
            return dsRet; //返回数据集
        }

        #endregion

        private bool DsafConnectionTest()
        {
            var bRet = false;

            try
            {
                using (var conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConnectionString;
                    conn.Open();

                    bRet = true;

                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException)
            {
                //// throw ex;      
                // CommonFunction.MessageShow("数据库连接失败", "提示", "OK", "Information");
            }
            return bRet;
        }

        #endregion

        #region   传入参数并且转换为SqlParameter类型

        /// <summary>
        ///     转换参数
        /// </summary>
        public object MakeInParam(string paramName, //存储过程名称或命令文本
            SqlDbType dbType, //参数类型
            int size, //参数大小
            object value) //参数值
        {
            var mydbtype = TransTypeFromSqlDBtype(dbType);
            return MakeParam(paramName, mydbtype, size, ParameterDirection.Input, value); //创建SQL参数
        }

        private MySqlDbType TransTypeFromSqlDBtype(SqlDbType dbType)
        {
            MySqlDbType dbRet = 0;

            switch (dbType)
            {
                case SqlDbType.BigInt:
                    dbRet = MySqlDbType.Int32;
                    break;
                case SqlDbType.Binary:
                    dbRet = MySqlDbType.Binary;
                    break;
                case SqlDbType.Char:
                    dbRet = MySqlDbType.Byte;
                    break;
                case SqlDbType.Date:
                    dbRet = MySqlDbType.Date;
                    break;
                case SqlDbType.DateTime:
                    dbRet = MySqlDbType.DateTime;
                    break;
                case SqlDbType.DateTime2:
                    dbRet = MySqlDbType.DateTime;
                    break;
                case SqlDbType.DateTimeOffset:
                    dbRet = MySqlDbType.Timestamp;
                    break;
                case SqlDbType.Decimal:
                    dbRet = MySqlDbType.Decimal;
                    break;
                case SqlDbType.Float:
                    dbRet = MySqlDbType.Float;
                    break;
                case SqlDbType.Image:
                    dbRet = MySqlDbType.LongBlob;
                    break;
                case SqlDbType.Int:
                    dbRet = MySqlDbType.Int32;
                    break;
                case SqlDbType.Money:
                    dbRet = MySqlDbType.Double;
                    break;
                case SqlDbType.NChar:
                    dbRet = MySqlDbType.UByte;
                    break;
                case SqlDbType.NText:
                    dbRet = MySqlDbType.Text;
                    break;
                case SqlDbType.NVarChar:
                    dbRet = MySqlDbType.Text;
                    break;
                case SqlDbType.Real:
                    dbRet = MySqlDbType.Double;
                    break;
                case SqlDbType.SmallDateTime:
                    dbRet = MySqlDbType.Newdate;
                    break;
                case SqlDbType.SmallInt:
                    dbRet = MySqlDbType.Int16;
                    break;
                case SqlDbType.SmallMoney:
                    dbRet = MySqlDbType.Float;
                    break;
                case SqlDbType.Text:
                    dbRet = MySqlDbType.Text;
                    break;
                case SqlDbType.Time:
                    dbRet = MySqlDbType.Time;
                    break;
                case SqlDbType.Timestamp:
                    dbRet = MySqlDbType.Timestamp;
                    break;
                case SqlDbType.TinyInt:
                    dbRet = MySqlDbType.Int16;
                    break;
                case SqlDbType.UniqueIdentifier:
                    dbRet = MySqlDbType.Guid;
                    break;
                case SqlDbType.VarBinary:
                    dbRet = MySqlDbType.VarBinary;
                    break;
                case SqlDbType.VarChar:
                    dbRet = MySqlDbType.VarChar;
                    break;
                case SqlDbType.Variant:
                    dbRet = MySqlDbType.VarString;
                    break;
                case SqlDbType.Xml:
                    dbRet = MySqlDbType.LongText;
                    break;
            }
            return dbRet;
        }

        #endregion
    }
}