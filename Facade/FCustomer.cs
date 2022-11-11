using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SuperMaket_project.Facade
{
    public class FCustomer
    {
        connection con = new connection();
        
        public SqlDataAdapter getAll()
        {
            return con.command("select * from Customer");
        }

        public Boolean Add(string FallName, string street, string city, decimal phone, string gender, string Email, decimal snn, string type, DateTime dateTimeStert, decimal Balance)
        {

            return con.commandExecute("insert Customer (Customer_name,email,phone,street,city,snn,Customer_Gender,Customer_type,Customer_Balance,Customer_date)Values"
               + "(N'" + FallName + "','" + Email + "', '" + phone + "', N'" + street.Replace("'", "''") + "', N'" + city.Replace("'", "''") + "', '" + snn + "', N'" + gender + "', '" + type + "', '" + Balance + "', '" + dateTimeStert + "')");
        }
        public bool delete(int id)
        {
            return con.commandExecute("delete from Customer where id= '" + id + "'");
        }

       
        public bool updata(int id, string FallName, string street, string city, decimal phone, string gender, string Email, decimal snn, string type, DateTime dateTimeStert, decimal Balance)
        {

            return con.commandExecute("	update Customer set Customer_name = N'" + FallName + "',email =  '" + Email + "',phone = '" + phone + "',street =  N'" + street.Replace("'", "''") + "',city = N'" + city.Replace("'", "''") + "',snn = '" + snn + "',Customer_Gender =  N'" + gender + "',Customer_type = '" + type + "',Customer_Balance = '" + Balance + "' ,Customer_date = '" + dateTimeStert + "'  where id= '" + id + "'");

        }
    }
}
