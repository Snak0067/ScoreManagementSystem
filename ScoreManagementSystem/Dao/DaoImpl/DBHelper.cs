using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScoreManagementSystem.Dao.DaoImpl
{
    public class DBHelper
    {
        private readonly IBaseConnect db;

        public DBHelper()
        {
            db = DbFactory.Create("MySQL", "localhost", "zjutuser", "root", "123456");
        }

        public object MakeInParam(string ParamName, //存储过程名称或命令文本
            SqlDbType DbType, //参数类型
            int Size, //参数大小
            object Value) //参数值
        {
            var mydbtype = TransTypeFromSqlDBtype(DbType);
            return MakeParam(ParamName, mydbtype, Size, ParameterDirection.Input, Value); //创建SQL参数
        }

        /// <summary>
        ///     初始化参数值
        /// </summary>
        private object MakeParam(string ParamName, //存储过程名称或命令文本
            MySqlDbType DbType, //参数类型
            int Size, //参数大小
            ParameterDirection Direction, //参数方向
            object Value) //参数值
        {
            MySqlParameter param; //声明SQL参数对象
            if (Size > 0) //判断参数字段是否大于0
                param = new MySqlParameter(ParamName, DbType, Size); //根据指定的类型和大小创建SQL参数
            else
                param = new MySqlParameter(ParamName, DbType); //根据指定的类型创建SQL参数

            param.Direction = Direction; //设置SQL参数的类型
            if (!(Direction == ParameterDirection.Output && Value == null)) //判断是否为输出参数
                param.Value = Value; //设置参数返回值

            //转换object对象返回
            return param; //返回SQL参数
        }

        public int ExecSQLInt(string SQLString, object[] prams)
        {
            return db.ExecSQL(SQLString, prams);
        }

        public DataSet ExecSQL(string SQLString, object[] prams)
        {
            return db.ExecSQLQuery(SQLString, prams);
        }

        public DataSet GetResult(string sqlStr)
        {
            var ds = new DataSet();
            try
            {
                ds = db.ExecSQLQuery(sqlStr);
                if (ds != null && ds.Tables[0].Rows.Count != 0)
                {
                    return ds;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int GetResultInt(string sqlStr)
        {
            try
            {
                var ds = db.ExecSQL(sqlStr);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <returns></returns>
        public int SavePictureToDB(byte[] imageByte, string Picturename, string PicType, int PicTypeId)
        {
            return db.SavePictureToDB(imageByte, Picturename, PicType, PicTypeId);
        }

        public int UpdatePictureToDb(byte[] imageByte, string pictureName, string picType, int picTypeId)
        {
            return db.UpdatePictureToDb(imageByte, pictureName, picType, picTypeId);
        }

        /// <summary>
        ///     获取图片
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public byte[] GetImage(string PicType, int PicTypeId)
        {
            try
            {
                var imageByte = new byte[0];
                var result = db.GetPictureFromDB(ref imageByte, PicType, PicTypeId);
                if (result == 0 && imageByte != null && imageByte.Length != 0)
                {
                    return imageByte;
                }
            }
            catch (Exception)
            {
                //CommonFunction.MessageShow(ex.Message);
            }
            return null;
        }

        private MySqlDbType TransTypeFromSqlDBtype(SqlDbType DbType)
        {
            MySqlDbType dbRet = 0;

            switch (DbType)
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
    }
}