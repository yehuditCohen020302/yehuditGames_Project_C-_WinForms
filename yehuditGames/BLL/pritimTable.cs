using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
   public class PritimTable:GeneralTableByAutoKod
    {
        
        public PritimTable()
         : base("pritim", "kodParit", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodParit"] = from["kodParit"];
            to["nameParit"] = from["nameParit"];
            to["price"] = from["price"];
            to["minAmount"] = from["minAmount"];
            to["maxAmount"] = from["maxAmount"];
            to["nowAmount"] = from["nowAmount"];
            to["nameChevra"] = from["nameChevra"];
            to["matimMegil"] = from["matimMegil"];
            to["matimAdGil"] = from["matimAdGil"];
            to["minMistatfim"] = from["minMistatfim"];
            to["maxMistatfim"] = from["maxMistatfim"];
            to["status"] = from["status"];
            to["kodSugeiGames"] = from["kodSugeiGames"];
            to.EndEdit();

        }
        public DataTable GetResultFromSearch(int FromPrice, int ToPrice, int KodChevra, int MatimMegil, int matimAdGil, int minMistatfim, int maxMistatfim)
        {
            DataTable dt = DAL.Dal.GetQuery(" SELECT pritim.nameChevra,pritim.nameParit, pritim.price, pritim.matimMegil, pritim.matimAdGil, pritim.minMistatfim, pritim.maxMistatfim, pritim.status FROM pritim WHERE(((pritim.nameChevra) = " + KodChevra + ") AND([pritim]![price] > " + FromPrice + " And[pritim]![price] < " + ToPrice + ") AND((pritim.matimMegil) <= " + MatimMegil + ") AND((pritim.matimAdGil) >= " + matimAdGil + ") AND((pritim.minMistatfim) <= " + minMistatfim + ") AND((pritim.maxMistatfim) >= " + maxMistatfim + ") AND((pritim.status) = True)); ");
            return dt;
        }
        public DataTable GetResultFromSearch(int FromPrice, int ToPrice, int MatimMegil, int matimAdGil, int minMistatfim, int maxMistatfim)
        {
            DataTable dt = DAL.Dal.GetQuery(" SELECT pritim.nameChevra,pritim.nameParit, pritim.price, pritim.matimMegil, pritim.matimAdGil, pritim.minMistatfim, pritim.maxMistatfim, pritim.status FROM pritim WHERE(([pritim]![price] > " + FromPrice + " And[pritim]![price] < " + ToPrice + ") AND((pritim.matimMegil) <= " + MatimMegil + ") AND((pritim.matimAdGil) >= " + matimAdGil + ") AND((pritim.minMistatfim) <= " + minMistatfim + ") AND((pritim.maxMistatfim) >= " + maxMistatfim + ") AND((pritim.status) = True)); ");
            return dt;
        }


    }
}

