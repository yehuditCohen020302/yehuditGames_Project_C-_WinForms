using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
   public class Pritim
    {
        private int kodParit;
        private String nameParit;
        private double price;
        private int minAmount;
        private int maxAmount;
        private int nowAmount;
        private String nameChevra;
        private int matimMegil;
        private int matimAdGil;
        private int minMistatfim;
        private int maxMistatfim;
        private bool status;
        private int kodSugeiGames;

        public int KodParit
        {
            get { return kodParit; }
            set { kodParit = value; }
        }
        public String NameParit
        {
            get { return nameParit; }
            set { nameParit = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int MinAmount
        {
            get { return minAmount; }
            set { minAmount = value; }
        }
        public int MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; }
        }
        public int NowAmount
        {
            get { return nowAmount; }
            set { nowAmount = value; }
        }
        public String NameChevra
        {
            get { return nameChevra; }
            set { nameChevra = value; }
        }
        public int MatimMegil
        {
            get { return matimMegil; }
            set { matimMegil = value; }
        }
        public int MatimAdGil
        {
            get { return matimAdGil; }
            set { matimAdGil = value; }
        }
        public int MinMistatfim
        {
            get { return minMistatfim; }
            set { minMistatfim = value; }
        }
        public int MaxMistatfim
        {
            get { return maxMistatfim; }
            set { maxMistatfim = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public int KodSugeiGames
        {
            get { return kodSugeiGames; }
            set { kodSugeiGames = value; }
        }
        
        public Pritim(int kodParit, String nameParit, double price, int minAmount, int maxAmount, int nowAmount, String nameChevra, int matimMegil, int matimAdGil, int minMistatfim, int maxMistatfim, bool status, int kodSugeiGames)
        {
            this.kodParit = kodParit;
            this.nameParit = nameParit;
            this.price = price;
            this.minAmount = minAmount;
            this.maxAmount = maxAmount;
            this.nowAmount = nowAmount;
            this.nameChevra = nameChevra;
            this.matimMegil = matimMegil;
            this.matimAdGil = matimAdGil;
            this.minMistatfim = minMistatfim;
            this.maxMistatfim = maxMistatfim;
            this.status = status;
            this.kodSugeiGames = kodSugeiGames;
        }
        public Pritim()
        { }
        public Pritim(DataRow drOfPritim)
        {
            this.kodParit = Convert.ToInt32(drOfPritim["kodParit"]);
            this.nameParit = Convert.ToString(drOfPritim["nameParit"]);
            this.price = Convert.ToDouble(drOfPritim["price"]);
            this.minAmount = Convert.ToInt32(drOfPritim["minAmount"]);
            this.maxAmount = Convert.ToInt32(drOfPritim["maxAmount"]);
            this.nowAmount = Convert.ToInt32(drOfPritim["nowAmount"]);
            this.nameChevra = Convert.ToString(drOfPritim["nameChevra"]);
            this.matimMegil = Convert.ToInt32(drOfPritim["matimMegil"]);
            this.matimAdGil = Convert.ToInt32(drOfPritim["matimAdGil"]);
            this.minMistatfim = Convert.ToInt32(drOfPritim["minMistatfim"]);
            this.maxMistatfim = Convert.ToInt32(drOfPritim["maxMistatfim"]);
            this.status = Convert.ToBoolean(drOfPritim["status"]);
            this.kodSugeiGames = Convert.ToInt32(drOfPritim["kodSugeiGames"]);
        }
        public DataRow ToDataRow()
        {
            PritimTable allChavotDaat = new PritimTable();
            DataTable drOfPritim = new PritimTable().Dt;
            DataRow dr = drOfPritim.NewRow();
            dr["kodParit"] = this.kodParit;
            dr["nameParit"] = this.nameParit;
            dr["price"] = this.price;
            dr["minAmount"] = this.minAmount;
            dr["maxAmount"] = this.maxAmount;
            dr["nowAmount"] = this.nowAmount;
            dr["nameChevra"] = this.nameChevra;
            dr["matimMegil"] = this.matimMegil;
            dr["matimAdGil"] = this.matimAdGil;
            dr["minMistatfim"] = this.minMistatfim;
            dr["maxMistatfim"] = this.maxMistatfim;
            dr["status"] = this.status;
            dr["kodSugeiGames"] = this.kodSugeiGames;
            return dr;
        }
    }
}
