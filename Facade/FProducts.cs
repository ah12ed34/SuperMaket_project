using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SuperMaket_project.Facade
{
    public class FProducts
    {
        protected connection conn = new connection();

        public SqlDataAdapter getAllProdectNRQ()
        {
            return conn.command(" SELECT * "
                                + "FROM Product t1 "
                               + " WHERE Quantity > 0 and" +
                                " NOT EXISTS(SELECT 1 FROM Product t2"
                + " WHERE t1.Barcode = t2.Barcode and t1.unit = t2.unit  AND t1.id > t2.id) ");
        }
        public SqlDataAdapter getProdect(int id)
        {
            return conn.command("select * from Product where id ='" + id + "'");
        }
        public SqlDataAdapter getAllProdect()
        {
            return conn.command(" SELECT * "
                                + " FROM Product ");
        }
        public SqlDataAdapter getProdect(string name)
        {
            return conn.command("select * from Product where product_name LIKE  '%" + name + "%'");
        }
    }
}
