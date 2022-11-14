using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMaket_project
{
<<<<<<< HEAD
    public class connection
=======
    class connection
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Application.StartupPath + @"\db\SuperSalesMangement.mdf;Integrated Security = True;Connect Timeout=30");

        public  connection()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                conn.Close();
            }

        }
        public void delete(string sql)
        {
            try
            { 
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n " + Application.StartupPath);
            }
            finally { if (conn != null & conn.State == ConnectionState.Open) { conn.Close(); } }


        }
        public SqlDataAdapter command(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();
                
                return new SqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message + "\n " + Application.StartupPath);
                return new SqlDataAdapter();
            }
            finally { if(conn != null&conn.State==ConnectionState.Open) { conn.Close(); } }
            
        }

        public Boolean commandExecute(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n " + Application.StartupPath);
                return false;
            }
            finally { if (conn != null & conn.State == ConnectionState.Open) { conn.Close(); } }

        }
    }
}
