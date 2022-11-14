using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMaket_project
{
    public class Products
    {
        string name, unit;
<<<<<<< HEAD
        decimal buy_price,sell_price,barcode,Quantity ,Qty;
        int id ,id_buy;
        DateTime buyDate, EndDate;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unit"></param>
        /// <param name="buy_price"></param>
        /// <param name="sell_price"></param>
        /// <param name="barcode"></param>
        /// <param name="quantity"></param>
        /// <param name="id"></param>
        /// <param name="id_buy"></param>
        /// <param name="qty">الكمية المراد بيعة غي فاتورت الشراء تكون القيمه null</param>
        /// <param name="buyDate"></param>
        /// <param name="endDate"></param>
        public Products(string name, string unit, decimal buy_price, decimal sell_price, decimal barcode, decimal quantity, int id, int id_buy,int qty, DateTime buyDate, DateTime endDate)
=======
        decimal buy_price,sell_price,barcode,Quantity;
        int id ,id_buy;
        DateTime buyDate, EndDate;
        
        public Products(string name, string unit, decimal buy_price, decimal sell_price, decimal barcode, decimal quantity, int id, int id_buy, DateTime buyDate, DateTime endDate)
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a
        {
            this.Name = name;
            this.Unit = unit;
            this.Buy_price = buy_price;
            this.Sell_price = sell_price;
            this.Barcode = barcode;
            Quantity1 = quantity;
            this.Id = id;
            this.Id_buy = id_buy;
<<<<<<< HEAD
            this.Qty = qty;
=======
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a
            this.BuyDate = buyDate;
            EndDate1 = endDate;
        }
        public Products() { }

        public string Name { get => name; set => name = value; }
        public string Unit { get => unit; set => unit = value; }
        public decimal Buy_price { get => buy_price; set => buy_price = value; }
        public decimal Sell_price { get => sell_price; set => sell_price = value; }
        public decimal Barcode { get => barcode; set => barcode = value; }
        public decimal Quantity1 { get => Quantity; set => Quantity = value; }
        public int Id { get => id; set => id = value; }
        public int Id_buy { get => id_buy; set => id_buy = value; }
        public DateTime BuyDate { get => buyDate; set => buyDate = value; }
        public DateTime EndDate1 { get => EndDate; set => EndDate = value; }
<<<<<<< HEAD
       /// <summary>
       /// الكمية المراد بيعة 
       /// </summary>
        public decimal Qty1 { get => Qty; set => Qty = value; }
=======
>>>>>>> 39482c426b59c769bcff8e543752f7b0df6c880a
    }

}
