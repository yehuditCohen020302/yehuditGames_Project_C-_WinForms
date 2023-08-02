using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class pratyRechisha
    {
        private int kodRechisha;
        private int kodParit;
        private int amount;
        private double price;

        public int KodRechisha
        {
            get { return kodRechisha; }
            set { kodRechisha = value; }
        }
        public int KodParit
        {
            get { return kodParit; }
            set { kodParit = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public pratyRechisha(int kodRechisha, int kodParit, int amount, double price)
        {
            this.kodRechisha = kodRechisha;
            this.kodParit = kodParit;
            this.amount = amount;
            this.price = price;
        }

        public pratyRechisha(DataRow drOfPratyRechisha)
        {
            this.kodRechisha = Convert.ToInt32(drOfPratyRechisha["kodRechisha"]);
            this.kodParit = Convert.ToInt32(drOfPratyRechisha["kodParit"]);
            this.amount = Convert.ToInt32(drOfPratyRechisha["amount"]);
            this.price = Convert.ToDouble(drOfPratyRechisha["price"]);

        }
        public DataRow ToDataRow()
        {
            DataTable drOfPratyRechisha = new pratyRechishaTable().Dt;
            DataRow dr = drOfPratyRechisha.NewRow();
            dr["kodRechisha"] = this.kodRechisha;
            dr["kodParit"] = this.kodParit;
            dr["amount"] = this.amount;
            dr["price"] = this.price;
            return dr;
        }
    }
}
