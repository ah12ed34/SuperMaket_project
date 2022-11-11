using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SuperMaket_project.Facade
{
    public class FSuppliers
    {
        connection con = new connection();

        public SqlDataAdapter getAll()
        {
            return con.command("select * from Suppliers");
        }

        public Boolean Add(string FallName, string street, string city, decimal phone, string Email, decimal snn)
        {

            return con.commandExecute("insert Suppliers (name,email,phone,street,city,snn)Values"
               + "(N'" + FallName + "','" + Email + "', '" + phone + "', N'" + street.Replace("'", "''") + "', N'" + city.Replace("'", "''") + "', '" + snn + "')");
        }
        public bool delete(int id)
        {
            return con.commandExecute("delete from Suppliers where id= '" + id + "'");
        }


        public bool updata(int id, string FallName, string street, string city, decimal phone, string Email, decimal snn)
        {

            return con.commandExecute("	update Suppliers set name = N'" + FallName + "',email =  '" + Email + "',phone = '" + phone + "',street =  N'" + street.Replace("'", "''") + "',city = N'" + city.Replace("'", "''") + "',snn = '" + snn +"'  where id= '" + id + "'");

        }
    }
}
