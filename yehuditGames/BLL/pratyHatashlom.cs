using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
   public class pratyHatashlom
    {
        private int kodOfPratim;
        private int kodRechisha;
        private string sugTashlum;
        private double schum;
        private int numberOfChek;
        private DateTime dateOfPeraon;
        private bool nishlachLeperaon;
        private string sugAshrai;
        private int numberAshrai;
        private DateTime tokefAshrai;
        private int threeSfarotBegavHkartis;
        private int idOfBaalHakartis;
        private int numberOfTashlumim;

        public int KodOfPratim
        {
            get { return kodOfPratim; }
            set { kodOfPratim = value; }
        }
        public int KodRechisha
        {
            get { return kodRechisha; }
            set { kodRechisha = value; }
        }
        public string SugTashlum
        {
            get { return sugTashlum; }
            set { sugTashlum = value; }
        }
        public double Schum
        {
            get { return schum; }
            set { schum = value; }
        }
        public int NumberOfChek
        {
            get { return numberOfChek; }
            set { numberOfChek = value; }
        }
        public DateTime DateOfPeraon
        {
            get { return dateOfPeraon; }
            set
            {
              //  if (value < DateTime.Today)
               //     throw new Exception("הזן תאריך מוקדם יותר");
                dateOfPeraon = value; }
        }
        public bool NishlachLeperaon
        {
            get { return nishlachLeperaon; }
            set { nishlachLeperaon = value; }
        }
        public string SugAshrai
        {
            get { return sugAshrai; }
            set { sugAshrai = value; }
        }
        public int NumberAshrai
        {
            get { return numberAshrai; }
            set { numberAshrai = value; }
        }
        public DateTime TokefAshrai
        {
            get { return tokefAshrai; }
            set
            {
                //if (value < DateTime.Today)
                  //  throw new Exception("הזן תאריך מוקדם יותר");
                tokefAshrai = value; }
        }
        public int ThreeSfarotBegavHkartis
        {
            get { return threeSfarotBegavHkartis; }
            set { threeSfarotBegavHkartis = value; }
        }
        public int IdOfBaalHakartis
        {
            get { return idOfBaalHakartis; }
            set { idOfBaalHakartis = value; }
        }
        public int NumberOfTashlumim
        {
            get { return numberOfTashlumim; }
            set { numberOfTashlumim = value; }
        }
       

        public pratyHatashlom(int kodOfPratim, int kodRechisha, string sugTashlum, double schum, int numberOfChek, DateTime dateOfPeraon, bool nishlachLeperaon, string sugAshrai, int numberAshrai, DateTime TokefAshrai, int threeSfarotBegavHkartis, int idOfBaalHakartis, int numberOfTashlumim)
        {
            this.kodOfPratim = kodOfPratim;
            this.kodRechisha = kodRechisha;
            this.sugTashlum = sugTashlum;
            this.schum = schum;
            this.numberOfChek = numberOfChek;
            this.dateOfPeraon = dateOfPeraon;
            this.nishlachLeperaon = nishlachLeperaon;
            this.sugAshrai = sugAshrai;
            this.numberAshrai = numberAshrai;
            this.TokefAshrai = TokefAshrai;
            this.threeSfarotBegavHkartis = threeSfarotBegavHkartis;
            this.idOfBaalHakartis = idOfBaalHakartis;
            this.numberOfTashlumim = numberOfTashlumim;
        }
        public pratyHatashlom(DataRow drOfPratyHatashlom)
        {
            this.kodOfPratim = Convert.ToInt32(drOfPratyHatashlom["kodOfPratim"]);
            this.kodRechisha = Convert.ToInt32(drOfPratyHatashlom["kodRechisha"]);
            this.sugTashlum = Convert.ToString(drOfPratyHatashlom["sugTashlum"]);
            this.schum = Convert.ToDouble(drOfPratyHatashlom["schum"]);
            this.numberOfChek = Convert.ToInt32(drOfPratyHatashlom["numberOfChek"]);
            this.dateOfPeraon = Convert.ToDateTime(drOfPratyHatashlom["dateOfPeraon"]);
            this.nishlachLeperaon = Convert.ToBoolean(drOfPratyHatashlom["nishlachLeperaon"]);
            this.sugAshrai = Convert.ToString(drOfPratyHatashlom["sugAshrai"]);
            this.numberAshrai = Convert.ToInt32(drOfPratyHatashlom["numberAshrai"]);
            this.TokefAshrai = Convert.ToDateTime(drOfPratyHatashlom["TokefAshrai"]);
            this.threeSfarotBegavHkartis = Convert.ToInt32(drOfPratyHatashlom["threeSfarotBegavHkartis"]);
            this.idOfBaalHakartis = Convert.ToInt32(drOfPratyHatashlom["idOfBaalHakartis"]);
            this.numberOfTashlumim = Convert.ToInt32(drOfPratyHatashlom["numberOfTashlumim"]);
        }

        public DataRow ToDataRow()
        {
            DataTable drOfPratyHatashlom = new pratyHatashlomTable().Dt;
            DataRow dr = drOfPratyHatashlom.NewRow();
            dr["kodOfPratim"] = this.kodOfPratim;
            dr["kodRechisha"] = this.kodRechisha;
            dr["sugTashlum"] = this.sugTashlum;
            dr["schum"] = this.schum;
            dr["numberOfChek"] = this.numberOfChek;
            dr["dateOfPeraon"] = this.dateOfPeraon;
            dr["nishlachLeperaon"] = this.nishlachLeperaon;
            dr["sugAshrai"] = this.sugAshrai;
            dr["numberAshrai"] = this.numberAshrai;
            dr["TokefAshrai"] = this.TokefAshrai;
            dr["threeSfarotBegavHkartis"] = this.threeSfarotBegavHkartis;
            dr["idOfBaalHakartis"] = this.idOfBaalHakartis;
            dr["numberOfTashlumim"] = this.numberOfTashlumim;
            return dr;
        }
        
    }
}
