using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
   public class pratyHatashlomTable : GeneralTableWithTwoKeys
    {
        public pratyHatashlomTable()
            : base("pratyHatashlom", "kodOfPratim", "kodRechisha", false)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodOfPratim"] = from["kodOfPratim"];
            to["kodRechisha"] = from["kodRechisha"];
            to["sugTashlum"] = from["sugTashlum"];
            to["schum"] = from["schum"];
            to["numberOfChek"] = from["numberOfChek"];
            to["dateOfPeraon"] = from["dateOfPeraon"];
            to["nishlachLeperaon"] = from["nishlachLeperaon"];
            to["sugAshrai"] = from["sugAshrai"];
            to["numberAshrai"] = from["numberAshrai"];
            to["TokefAshrai"] = from["TokefAshrai"];
            to["threeSfarotBegavHkartis"] = from["threeSfarotBegavHkartis"];
            to["idOfBaalHakartis"] = from["idOfBaalHakartis"];
            to["numberOfTashlumim"] = from["numberOfTashlumim"];
            to.EndEdit();

        }

    }
}
