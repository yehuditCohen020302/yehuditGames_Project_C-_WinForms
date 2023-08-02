using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class salesTable : GeneralTableWithTwoKeys
    {
        public salesTable()
            : base("sales", "kodSale", "kodParit", false)
        { }


        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodSale"] = from["kodSale"];
            to["kodParit"] = from["kodParit"];
            to["fromDate"] = from["fromDate"];
            to["toDate"] = from["toDate"];
            to["priceOfSale"] = from["priceOfSale"];
            to.EndEdit();
        }
    }
}