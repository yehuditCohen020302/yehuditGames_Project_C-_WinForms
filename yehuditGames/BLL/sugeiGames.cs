using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
      public class sugeiGames
    {
        private int kodSugeiGame;
        private string nameSugeiGame;
       
        public int KodSugeiGame
        {
            get { return kodSugeiGame; }
            set { kodSugeiGame = value; }
        }
        public string NameSugeiGame
        {
            get { return nameSugeiGame; }
            set { nameSugeiGame = value; }
        }
       

        public sugeiGames(int kodSugeiGame, string nameSugeiGame)
        {
            this.kodSugeiGame = kodSugeiGame;
            this.nameSugeiGame = nameSugeiGame;
        }

        public sugeiGames(DataRow drOfProduct)
        {
            this.kodSugeiGame = Convert.ToInt32(drOfProduct["kodSugeiGame"]);
            this.nameSugeiGame = Convert.ToString(drOfProduct["nameSugeiGame"]);

        }
        public DataRow ToDataRow()
        {
            DataTable dtOfProduct = new sugeiGamesTable().Dt;
            DataRow dr = dtOfProduct.NewRow();
            dr["kodSugeiGame"] = this.kodSugeiGame;
            dr["nameSugeiGame"] = this.nameSugeiGame;
            return dr;
        }
    }
}

