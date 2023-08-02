using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class ChavotDaatTable : GeneralTableByAutoKod
    {
        public ChavotDaatTable()
            : base("ChavotDaat", "kodChavatDaat", false)
        { }
        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodChavatDaat"] = from["kodChavatDaat"];
            to["kodParit"] = from["kodParit"];
            to["sviutRatzon"] = from["sviutRatzon"];
            to["description"] = from["description"];
            to["idMishtamesh"] = from["idMishtamesh"];
            to.EndEdit();
        }
        public DataTable GetTableByIdFor(string idMishtamesh)
        {
            return  DAL.Dal.GetQuery("SELECT chavotDaat.* FROM ChavotDaat WHERE(((chavotDaat.idMishtamesh) = '" + idMishtamesh + "'))");
            
        }

    }
}

