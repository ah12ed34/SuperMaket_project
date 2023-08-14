using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace SuperMaket_project.Facade
{
    public class FEmployee
    {
        connection con = new connection();
        security security = new security();
        
        public Boolean Add(string FallName, string user, string pass, string street, string city, decimal phone, string gender, string Email, decimal snn, float salary, DateTime dateTimeStert, Boolean islogin)
        {
              
            return con.commandExecute("insert Employee (FullName,[user],email,phone,password,street,city,snn,gender,Salary,login,start_date)Values"
               + "(N'"+FallName+ "', '"+user+ "', '"+Email+ "', '"+phone+ "', '"+ security.Encrypt(pass) + "', N'"+street.Replace("'", "''") + "', N'"+ city.Replace("'", "''") + "', '"+snn+ "', N'"+gender+ "', '"+salary+ "', '"+islogin+ "', '"+dateTimeStert+"')");
        }
        public bool delete(int id)
        {
            return con.commandExecute("delete from Employee where id= '"+id+"'");
        }

        public SqlDataAdapter getAll()
        {
            return con.command("select * from Employee");
        }

        public bool updata(int id,string FallName, string user, string pass, string street, string city, decimal phone, string gender, string Email, decimal snn, float salary, DateTime dateTimeStert, Boolean islogin)
        {

            return con.commandExecute("	update Employee set FullName = N'" + FallName + "',[user] = '" + user + "',email =  '" + Email + "',phone = '" + phone + "',password =  '" + security.Encrypt(pass) + "',street =  N'" + street.Replace("'", "''") + "',city = N'" + city.Replace("'","''") + "',snn = '" + snn + "',gender =  N'" + gender + "',Salary = '" + salary + "',login = '" + islogin + "' ,start_date = '" + dateTimeStert + "'  where id= '" + id + "'");
            
        }
    }
}
