using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
   public class Chevrot
    {
        private int kodChevra;
        private string nameChevra;

        public int KodChevra
        {
            get { return kodChevra; }
            set { kodChevra = value; }
        }
        public string NameChevra
        {
            get { return nameChevra; }
            set {
                if (value == "")
                    throw new Exception("  הזן שם תוכנית");
                if (value[0] == ' ')
                    throw new Exception("שם תוכנית לא יכול להתחיל ברווח");

                nameChevra = value; }
        }
        public Chevrot(int kodChevr, string nameChevr)
        {
            this.kodChevra = kodChevr;
            this.nameChevra = nameChevr;
        }
        public Chevrot(DataRow drOfChevrot)
        {
            this.kodChevra = Convert.ToInt32(drOfChevrot["kodChevra"]);
            this.nameChevra = Convert.ToString(drOfChevrot["nameChevra"]);

        }
        public Chevrot()
        { }


        public DataRow ToDataRow()
        {
            DataTable drOfChevrot = new ChevrotTable().Dt;
            DataRow dr = drOfChevrot.NewRow();
            dr["kodChevra"] = this.kodChevra;
            dr["nameChevra"] = this.nameChevra;
            return dr;
        }

    }
}
