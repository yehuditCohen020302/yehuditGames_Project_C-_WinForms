using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
   public class sales
    {
        private int kodSale;
        private int kodParit;
        private DateTime fromDate;
        private DateTime toDate;
        private double priceOfSale;

        public int KodSale
        {
            get { return kodSale; }
            set { kodSale = value; }
        }
        public int KodParit
        {
            get { return kodParit; }
            set { kodParit = value; }
        }
        public DateTime FromDate
        {
            get { return fromDate; }
            set
            {
                //if (value < DateTime.Today)
                // throw new Exception("הזן תאריך מוקדם יותר"); 
                fromDate = value; }
        }
        public DateTime ToDate
        {
            get { return toDate; }
            set
            {
                //if (value < DateTime.Today)
                // throw new Exception("הזן תאריך מוקדם יותר"); 
                toDate = value; }
        }
        public double PriceOfSale
        {
            get { return priceOfSale; }
            set { priceOfSale = value; }
        }

        public sales(int kodSale, int kodParit, DateTime fromDate, DateTime ToDate, double priceOfSale)
        {
            this.kodSale = kodSale;
            this.kodParit = kodParit;
            this.fromDate = fromDate;
            this.ToDate = ToDate;
            this.priceOfSale = priceOfSale;
        }

        public sales(DataRow drOfSales)
        {
            this.kodSale = Convert.ToInt32(drOfSales["kodSale"]);
            this.kodParit = Convert.ToInt32(drOfSales["kodParit"]);
            this.fromDate = Convert.ToDateTime(drOfSales["fromDate"]);
            this.toDate = Convert.ToDateTime(drOfSales["toDate"]);
            this.priceOfSale = Convert.ToDouble(drOfSales["priceOfSale"]);


        }
        public DataRow ToDataRow()
        {
            DataTable dtOfProduct = new salesTable().Dt;
            DataRow dr = dtOfProduct.NewRow();
            dr["kodSale"] = this.kodSale;
            dr["kodParit"] = this.kodParit;
            dr["fromDate"] = this.fromDate;
            dr["toDate"] = this.toDate;
            dr["priceOfSale"] = this.priceOfSale;
            return dr;
        }
    }
}
