using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class pratyRechishaTable : GeneralTableWithTwoKeys
    {
        public pratyRechishaTable()
            : base("pratyRechisha", "kodRechisha", "kodParit", false)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodRechisha"] = from["kodRechisha"];
            to["kodParit"] = from["kodParit"];
            to["amount"] = from["amount"];
            to["price"] = from["price"];
            to.EndEdit();
        }
    }
}

