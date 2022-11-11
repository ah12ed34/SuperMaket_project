using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;

namespace SuperMaket_project.Properties
{

    public class Login
    {
        connection con = new connection();
        DataTable users = new DataTable();
        security security = new security();
        public Boolean isLogin(string user, string Pass)
        {
            users = new DataTable();
            try
            {
                con.command("select * from Employee where [user] = '" + user + "' and login = 1 ").Fill(users);
                if (users.Rows.Count > 0)
                {
                    if (security.Decrypt(Convert.ToString(users.Rows[0]["password"])) == Pass)
                    {
                        return true;
                    }
                    else return false;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex) { return false; }
            

        }

    }
}
