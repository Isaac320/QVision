using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace QVision.Tools
{
    class D2RManager
    {
        static string mDeviceDBPath = Application.StartupPath + "\\Device2Recipe.db";
        static object _lock = new object();

        public static string QueryRecipe(string device)
        {
            string rpt = null;
            lock (_lock)
            {
                using (SQLiteConnection sqliteConn = new SQLiteConnection("Data Source=" + mDeviceDBPath))
                {
                    try
                    {
                        sqliteConn.Open();
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = sqliteConn;
                        cmd.CommandText = "SELECT Recipes FROM Table1 WHERE Devices='" + device + "'";
                        rpt = (string)cmd.ExecuteScalar();
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        sqliteConn.Close();
                    }
                }
            }
            return rpt;
        }

        public static DataTable Query(string sql)
        {
            lock (_lock)
            {
                using (SQLiteConnection sqliteConn = new SQLiteConnection("Data Source=" + mDeviceDBPath))
                {
                    try
                    {
                        if (sqliteConn.State != System.Data.ConnectionState.Open)
                        {
                            DataSet myds = new DataSet();
                            sqliteConn.Open();

                            SQLiteDataAdapter myda = new SQLiteDataAdapter(sql, sqliteConn);
                            myda.Fill(myds, "Table1");
                            return myds.Tables[0];
                        }
                        return null;
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        sqliteConn.Close();
                    }
                }
            }
        }


        public static int Save(string device,string recipe,string description)
        {

            lock (_lock)
            {               
                using (SQLiteConnection sqliteConn = new SQLiteConnection("Data Source=" + mDeviceDBPath))
                {
                    sqliteConn.Open();
                    using (SQLiteCommand cmd = sqliteConn.CreateCommand())
                    {
                        try
                        {
                            //cmd.CommandText = SQLString;
                            string strSql = "INSERT INTO Table1(Devices,Recipes,Description) VALUES(@device,@recipe,@description)";
                            cmd.CommandText = strSql;
                            SQLiteParameter[] parameters =
                            {
                                new SQLiteParameter("@device",device),
                                new SQLiteParameter("@recipe",recipe),
                                new SQLiteParameter("@description",description),
                            };

                            foreach (var param in parameters)
                            {
                                cmd.Parameters.Add(param);
                            }

                            int rows = cmd.ExecuteNonQuery();

                            return rows;
                        }
                        catch (SQLiteException ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            sqliteConn.Close();
                        }
                    }
                }
            }
        }


        public static int DeleteDevice(string device)
        {
            int rows = 0;
            lock (_lock)
            {                
                using (SQLiteConnection sqliteConn = new SQLiteConnection("Data Source=" + mDeviceDBPath))
                {
                    try
                    {
                        sqliteConn.Open();
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = sqliteConn;
                        cmd.CommandText = "DELETE FROM Table1 WHERE Devices='" + device + "'";
                        rows = cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        sqliteConn.Close();
                    }
                }
            }
            return rows;
        }

    }
}

