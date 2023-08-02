using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
   public class ChevrotTable:GeneralTableByAutoKod
    {
        public ChevrotTable()
            : base("chevrot", "kodChevra", false)
        { }
        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodChevra"] = from["kodChevra"];
            to["nameChevra"] = from["nameChevra"];
           
            to.EndEdit();

        }
    }
}

