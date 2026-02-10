
        using System;
using System.Data;
using System.Data.SqlClient;

namespace Govt.BDPension.Forms
{
        internal class DataAccess
        {
            private SqlConnection sqlcon;

            public DataAccess()
            {
                this.sqlcon = new SqlConnection(
                    @"Data Source=LAPTOP-E4JN8FLC\SQLEXPRESS;
                  Initial Catalog=Project;
                  Integrated Security=True");
            }

            
            public DataSet ExecuteQuery(string sql)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, this.sqlcon))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            sda.Fill(ds);
                            return ds;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            
            public DataTable ExecuteQueryTable(string sql)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, this.sqlcon))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            
            public int ExecuteUpdateQuery(string sql)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, this.sqlcon))
                    {
                        this.sqlcon.Open();
                        int result = cmd.ExecuteNonQuery();
                        this.sqlcon.Close();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    this.sqlcon.Close();
                    throw ex;
                }
            }
        }
    }

