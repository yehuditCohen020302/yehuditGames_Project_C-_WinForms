using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class sugeiGamesTable:GeneralTableByAutoKod
    {
        public sugeiGamesTable()
            : base("sugeiGames", "kodSugeiGame", false)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodSugeiGame"] = from["kodSugeiGame"];
            to["nameSugeiGame"] = from["nameSugeiGame"];
            to.EndEdit();
        }
    }
}
