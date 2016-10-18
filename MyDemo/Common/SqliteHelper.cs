using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MyDemo.Common
{
    public class SqliteHelper
    {
        /// <summary>
        /// 获取Connection连接对象
        /// </summary>
        /// <returns></returns>
        private static SQLiteConnection GetConnection()
        {
            string connetionString = string.Format("Data Source={0}\\{1};Version=3", Application.StartupPath,
                "PageData.db");
            SQLiteConnection sqlitConn = new SQLiteConnection(connetionString);
            try
            {
                sqlitConn.Open();
            }
            catch (SQLiteException er)
            {
                sqlitConn.Close();
                sqlitConn.ConnectionString = ConfigDeal.ConnectionRead("MyDb");
                sqlitConn.Open();
            }
            finally
            {
                sqlitConn.Close();
            }
            return sqlitConn;
        }

        /// <summary>
        /// 为Command对象匹配参数 
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="commandParms"></param>
        private static void PrepareCommand(SQLiteCommand sqlCommand, SQLiteParameter[] commandParms)
        {
            if (commandParms != null)
            {
                foreach (SQLiteParameter parameter in commandParms)
                {
                    if (parameter.Value == null)
                    {
                        parameter.Value = DBNull.Value;
                    }
                    sqlCommand.Parameters.Add(parameter);
                }
            }
        }

        /// <summary>
        /// 返回DataReader对象
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="commandParm"></param>
        /// <returns></returns>
        public static SQLiteDataReader ExecuteReader(string commandText, SQLiteParameter[] commandParm)
        {
            SQLiteConnection sqlitConntion = GetConnection();
            sqlitConntion.Open();
            SQLiteCommand sqlitCmd = new SQLiteCommand(commandText, sqlitConntion);
            PrepareCommand(sqlitCmd, commandParm);
            SQLiteDataReader sqliteReader;
            try
            {

                sqliteReader = sqlitCmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SQLiteException er)
            {
                sqliteReader = null;
            }
            return sqliteReader;
        }

        /// <summary>
        /// 返回DataTable对象
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="commandParm"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string commandText, SQLiteParameter[] commandParm)
        {
            DataTable myTable = new DataTable();
            SQLiteConnection sqlitConntion = GetConnection();
            sqlitConntion.Open();
            SQLiteCommand sqlitCmd = new SQLiteCommand(commandText, sqlitConntion);
            PrepareCommand(sqlitCmd, commandParm);
            try
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlitCmd);
                sda.Fill(myTable);
                sqlitConntion.Close();
            }
            catch (SQLiteException er)
            {
                sqlitConntion.Close();
            }
            return myTable;
        }

        /// <summary>
        /// 执行无返回命令
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="commandParm"></param>
        /// <returns></returns>
        public static int ExecuteNonce(string commandText, SQLiteParameter[] commandParm)
        {
            SQLiteConnection sqlitConntion = GetConnection();
            SQLiteCommand sqlitCmd = new SQLiteCommand(commandText, sqlitConntion);
            PrepareCommand(sqlitCmd, commandParm);
            int nflag = 0;
            try
            {
                sqlitConntion.Open();
                nflag = sqlitCmd.ExecuteNonQuery();
                sqlitConntion.Close();
            }
            catch (SQLiteException er)
            {
                sqlitConntion.Close();
            }
            return nflag;
        }

        /// <summary>
        /// 更新数据表
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyField"></param>
        /// <param name="dtTable"></param>
        /// <returns></returns>
        public static int UpdateTable(string tableName, string keyField, DataTable dtTable)
        {
            int nflag = 0;
            SQLiteConnection sqlitConntion = GetConnection();
            try
            {
                foreach (DataRow dRow in dtTable.Rows)
                {
                    string keyValue = dRow[keyField].ToString();
                    if (keyValue == string.Empty)
                        keyValue = "-1";
                    string strSql = string.Format("select * from {0} where {1} = {2}", tableName, keyField,
                        keyValue);
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(strSql, sqlitConntion);
                    SQLiteCommandBuilder scb = new SQLiteCommandBuilder(sda);
                    //上面的顺序不能改动
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dRow.ItemArray.Length; i++)
                        {
                            dt.Rows[0][i] = dRow[i];
                        }
                    }
                    else
                    {
                        DataRow newDataRow = dt.NewRow();
                        dt.Rows.Add(newDataRow);
                        //如此修改
                        for (int i = 0; i < dRow.ItemArray.Length; i++)
                        {  
                            newDataRow[i] = dRow[i];
                        }
                        newDataRow[keyField] = GetKey(tableName, keyField, sqlitConntion);
                    }
                    sda.Update(dt);
                    nflag++;
                }
                sqlitConntion.Close();
            }
            catch(SQLiteException er)
            {
                sqlitConntion.Close();
            }
            return nflag;
        }


         //<summary>
         //copy行
         //</summary>
         //<param name="oldRow"></param>
         //<param name="childRow"></param>
        private static void CopyRow(DataRow oldRow, DataRow childRow)
        {
            try
            {
                for (int i = 0; i < oldRow.ItemArray.Length;i++)
                {
                    childRow.ItemArray[i] = oldRow.ItemArray[i];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        /// <returns></returns>
        private static int GetKey(string tableName, string keyField, SQLiteConnection sqlConntion)
        {
            int nflag = 0;
            string strSql = string.Format("select max({0}) from {1}", keyField, tableName);
            try
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(strSql, sqlConntion);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                    nflag = 1;
                else
                    nflag = int.Parse(dt.Rows[0][0].ToString())+1;
            }
            catch (SQLiteException er)
            {
                nflag = 0;
            }
            return nflag;
        }
    }
}
    

