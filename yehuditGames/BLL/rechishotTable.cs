using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class rechishotTable:GeneralTableWithTwoKeys
    {
    public rechishotTable()
           : base("rechishot", "kodRechisha", "idMocher", false)
    { }

    public override void Update(DataRow from, DataRow to)
    {
        to.BeginEdit();
        to["kodRechisha"] = from["kodRechisha"];
        to["idMocher"] = from["idMocher"];
        to["date"] = from["date"];
        to["finalPrice"] = from["finalPrice"];
        to["idMishtamesh"] = from["idMishtamesh"];
            to.EndEdit();
    }
}
}
