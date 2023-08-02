using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
 public  class rechishot
    {
        private int kodRechisha;
        private int idMocher;
        private DateTime date;
        private double finalPrice;
        private string idMishtamesh;

        public int KodRechisha
        {
            get { return kodRechisha; }
            set { kodRechisha = value; }
        }
        public int IdMocher
        {
            get { return idMocher; }
            set { idMocher = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { if (value< DateTime.Today)
                    throw new Exception ("הזן תאריך מוקדם יותר");
                    date = value; }
        }
        public double FinalPrice
        {
            get { return finalPrice; }
            set { finalPrice = value; }
        }
        public string IdMishtamesh
        {
            get { return idMishtamesh; }
            set { idMishtamesh = value; }
        }
       
        public rechishot(int kodRechisha, int idMocher, DateTime date, double finalPrice,string idMishtamesh)
        {
            this.kodRechisha = kodRechisha;
            this.idMocher = idMocher;
            this.date = date;
            this.finalPrice = finalPrice;
            this.idMishtamesh = idMishtamesh;
        }

        public rechishot(DataRow drOfRechishot)
        {
            this.kodRechisha = Convert.ToInt32(drOfRechishot["kodRechisha"]);
            this.idMocher = Convert.ToInt32(drOfRechishot["idMocher"]);
            this.date = Convert.ToDateTime(drOfRechishot["date"]);
            this.finalPrice = Convert.ToDouble(drOfRechishot["finalPrice"]);
            this.idMishtamesh = Convert.ToString(drOfRechishot["idMishtamesh"]);

        }
        public DataRow ToDataRow()
        {
            DataTable drOfRechishot = new rechishotTable().Dt;
            DataRow dr = drOfRechishot.NewRow();
            dr["kodRechisha"] = this.kodRechisha;
            dr["idMocher"] = this.idMocher;
            dr["date"] = this.date;
            dr["finalPrice"] = this.finalPrice;
            dr["idMishtamesh"] = this.idMishtamesh;
            return dr;
        }
    }
}
