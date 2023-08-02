using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class MochrimTable : GeneralTableByAutoKod
    {
        public MochrimTable()
            : base( "Mochrim", "idMocher", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["idMocher"] = from["idMocher"];
            to["firstName"] = from["firstName"];
            to["lastName"] = from["lastName"];
            to["date"] = from["date"];
            to["city"] = from["city"];
            to["street"] = from["street"];
            to["numberOfHouse"] = from["numberOfHouse"];
            to["phone"] = from["phone"];
            to["status"] = from["status"];
            to.EndEdit();

        }
    }
}
