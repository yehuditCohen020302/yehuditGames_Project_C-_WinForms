using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
   public class ChavotDaat
    {
        private int kodChavatDaat;
        private int kodParit;
        private int sviutRatzon;
        private string description;
        private string idMishtamesh;
        public int KodChavatDaat
        {
            get { return kodChavatDaat; }
            set { kodChavatDaat = value; }
        }
        public int KodParit
        {
            get { return kodParit; }
            set { kodParit = value; }
        }
        public int SviutRatzon
        {
            get { return sviutRatzon; }
            set {
                if (value > 10 || value < 0)
                    throw new Exception("חוות דעת לא תקינה");
                sviutRatzon = value; }
        }
        public string Description
        { 
            get { return description; }
            set {
                if (value == "")
                    throw new Exception("אנא מלאו את פרטי חוות הדעת");
             description = value; }
        }
        public string IdMishtamesh
        {
            get { return idMishtamesh; }
            set { idMishtamesh = value; }
        }
        public ChavotDaat()
        { }

        public ChavotDaat(int kodChava, int kodPa, int sviutRa, string describe1, string idMishtamesh)
        {
            this.kodChavatDaat = kodChava;
            this.kodParit = kodPa;
            this.sviutRatzon = sviutRa;
            this.description = describe1;
            this.idMishtamesh = idMishtamesh;
        }
        public ChavotDaat(DataRow drOfChavotDaat)
        {

            this.kodChavatDaat = Convert.ToInt32(drOfChavotDaat["kodChavatDaat"]);
            this.kodParit = Convert.ToInt32(drOfChavotDaat["kodParit"]);
            this.sviutRatzon = Convert.ToInt32(drOfChavotDaat["sviutRatzon"]);
            this.description = Convert.ToString(drOfChavotDaat["description"]);
            this.idMishtamesh = Convert.ToString(drOfChavotDaat["idMishtamesh"]);
        }
        public DataRow ToDataRow()
        {
            ChavotDaatTable allChavotDaat = new ChavotDaatTable();
            DataTable drOfChavotDaat = new ChavotDaatTable().Dt;
            DataRow dr = drOfChavotDaat.NewRow();
            dr["kodChavatDaat"] = this.kodChavatDaat;
            dr["kodParit"] = this.kodParit;
            dr["sviutRatzon"] = this.sviutRatzon;
            dr["description"] = this.description;
            dr["idMishtamesh"] = this.idMishtamesh;
            return dr;
        }
    }
}
