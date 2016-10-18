using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Data.SQLite;


    public class SQLiteHelper
    {
        public static SQLiteConnection GetNewConnection()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["DBConnString"];
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
            }
            return sqlConnection;
        }

        /// <summary>
        /// 执行SQL语句，并返回一个SQLiteDataReader对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <returns>SQLiteDataReader对象</returns>
        public static SQLiteDataReader ExecuteReader(string commandText, SQLiteParameter[] commandParm)
        {
            SQLiteConnection sqlConnection = GetNewConnection();
            SQLiteCommand sqlCommand = new SQLiteCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParm);
            try
            {
                SQLiteDataReader dbDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dbDataReader;
            }
            catch (Exception e)
            {
                sqlConnection.Close();
            }
            return null;
        }

        public static DataTable ExecuteDataTable(string commandText, SQLiteParameter[] commandParm)
        {
            SQLiteConnection sqlConnection = GetNewConnection();
            SQLiteCommand sqlCommand = new SQLiteCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParm);
            try
            {
                DataTable datatable = new DataTable();
                SQLiteDataAdapter Datapter = new SQLiteDataAdapter(sqlCommand);
                Datapter.Fill(datatable);
                sqlConnection.Close();
                return datatable;
            }
            catch (Exception e)
            {
                sqlConnection.Close();
            }
            return null;
        }

        /// <summary>
        /// 执行SQL语句，不返回任何对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        public static int ExecuteNonQuery(string commandText, SQLiteParameter[] commandParm)
        {
            SQLiteConnection sqlConnection = GetNewConnection();
            SQLiteCommand sqlCommand = new SQLiteCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParm);
            int rowCount = 0;
            try
            {
                rowCount = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                sqlConnection.Close();
            }
            return rowCount;
        }

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
    }

