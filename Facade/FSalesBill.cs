using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SuperMaket_project.Facade
{
    public class FSalesBill : FProducts
    {
       
        public SqlDataAdapter getAll()
        {
            return conn.command("select * from SalesBill");
        }
        public SqlDataAdapter Search(int id)
        { 
            return conn.command("select * from SalesBill SB inner join SBproduct SBp on SBp.sb_id = SB.id inner join Product p on p.id_buy = SBp.pro_id inner join Employee Emp on Emp.id = SB.Employee_id left join Customer cus on cus.id = SB.Customer_id where SB.id = '"+id+"' ");
        }
        
        public Boolean add(int id_emp, int id_Cus,string name , decimal price,string type, DateTime date, List<Products> products)
        {
            string sql = "BEGIN TRANSACTION";

            sql += "declare @SB_Id int ,@qty int" +
                       "declare @table table(id int)" +
                        "insert into SalesBill(Employee_id, Customer_id, name, price, type_sales, date) output inserted.id into @table values" +
                        "('"+id_emp+ "','"+id_Cus+ "','"+name+ "',"+price+ ",'"+type+ "','"+date+"')"+
                        "select @SB_Id = id from @table" ;
            for(int i = 0; i < products.Count; i++)
            {
                sql += "insert into SBproduct (sb_id,pro_id,price,quantity) values (@SB_Id,(select top 1 id from Product where Barcode = '"+products[i].Barcode+"' and Quantity >= '"+products[i].Qty1+"' ),'"+products[i].Sell_price+ "','" + products[i].Qty1 + "') ";
                sql += "update top (1) Product  set Quantity = (select top 1  Quantity - 10 from Product where Barcode = '" + products[i].Barcode + "' and Quantity >= '" + products[i].Qty1 + "' )  where Barcode = '" + products[i].Barcode + "' and Quantity >= '" + products[i].Qty1 + "'";
            }
            sql += " commit ";
            return conn.commandExecute(sql);
        }

    }
}
