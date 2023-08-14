using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SuperMaket_project.Facade
{
    public class Fbuying : FProducts
    {
        
        Products product = new Products();
        public SqlDataAdapter getAll()
        {
            return conn.command("select bb.id as [number Bill] , sup.name as [Suppliers name] ,  Emp.FullName as [Employee name] , bb.price as [total] , p.product_name as [product name] ,p.Barcode,p.price_Buy,p.price_sell,p.Quantity,p.StartDate,p.ExpiryDate,p.unit from BuyBill bb INNER  join  Product p on p.id_buy = bb.id left join Employee Emp on Emp.id = bb.emp_id left join Suppliers sup on sup.id = bb.Sup_id");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">الخاص بال فاتورة</param>
        /// <returns></returns>
        public SqlDataAdapter Search(int id)
        {
            return conn.command("select bb.id as [number Bill] ,  sup.name as [Suppliers name] ,  Emp.FullName as [Employee name] , bb.price as [total] , p.product_name as [product name] ,p.Barcode,p.price_Buy,p.price_sell,p.Quantity,p.StartDate,p.ExpiryDate,p.unit from BuyBill bb INNER  join  Product p on p.id_buy = bb.id left join Employee Emp on Emp.id = bb.emp_id left join Suppliers sup on sup.id = bb.Sup_id where bb.id = '" + id + "'");
        }
        public Boolean add(int id_emp,int id_sup,decimal price,DateTime date,List<Products> products)
        { string id_empS, id_supS;
             product = new Products();
            if (id_emp > 0) { id_empS = "'"+id_emp+"'"; }else { id_empS = "NULL"; }
            if (id_sup > 0) { id_supS = "'" + id_sup+"'" ; }else { id_supS = "NULL"; }
            string  sql = "BEGIN TRANSACTION \n" +
               "  declare @Buy_Id int , @Pro_id int \n" +
               "  declare @table table(id int) \n" +
               " insert  BuyBill(emp_id, Sup_id, price, buyDate) output inserted.id into @table values(" +
                                    id_empS+ "," + id_supS + ",'" + price + "','" + date + "')" +
                " select @Buy_Id = id from @table" +
                " insert  Product (product_name, price_Buy, price_sell, Barcode, unit, Quantity, StartDate, ExpiryDate, id_buy) values ";
                  for(int i = 0; i < products.Count-1; i++)
            {
                product=products[i];
               sql += " ('"+product.Name+"','"+product.Buy_price+ "','"+product.Sell_price+ "','"+product.Barcode+ "','"+product.Unit+ "','"+product.Quantity1+ "','"+product.BuyDate+ "','"+product.EndDate1+"',@Buy_Id),";
            }
             product=products[products.Count-1];
            sql += "('"+product.Name+"', '"+product.Buy_price+ "', '"+product.Sell_price+ "', '"+product.Barcode+ "', '"+product.Unit+ "', '"+product.Quantity1+ "', '"+product.BuyDate+ "', '"+product.EndDate1+"', @Buy_Id) commit";
         return conn.commandExecute(sql);
        }
        /// <summary>
        /// سيتم حذف الفاتورة مع جميع المنتاجات التابعه له
        /// </summary>
        /// <param name="id">رقم الفاتوة</param>
        /// <returns></returns>
        public Boolean delete(int id)
        {
            return conn.commandExecute("BEGIN TRANSACTION "
                    +" delete from Product where id_buy ='"+id
                    +"' delete from BuyBill where id = '"+id
                     + "' commit ");
        }

        public Boolean update(int id ,int id_emp, int id_sup, decimal price, DateTime date, List<Products> products)
        {
           product = new Products();
            string sql = "BEGIN TRANSACTION " +

               " update BuyBill set emp_id = '" + id_emp + "', Sup_id = '" + id_sup + "', price ='" + price + "', buyDate = '" + date + "' where id = '" + id + "'";

                
            for (int i = 0; i < products.Count; i++)
            {
                product = products[i];
                sql += " update Product set product_name = '" + product.Name + "', price_Buy = '" + product.Buy_price + "', price_sell = '" + product.Sell_price + "', Barcode ='" + product.Barcode + "', unit = '" + product.Unit + "', Quantity ='" + product.Quantity1 + "', StartDate = '" + product.BuyDate + "', ExpiryDate = '" + product.EndDate1 + "' where id_buy ='" + id + "' and id ='"+product.Id+" "; 
            }
            sql += " commit ";
            return conn.commandExecute(sql);
        }



    }
}
