using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace yehuditGames.BLL
{
 public   class GeneralTableByAutoKod :GeneralTable
    {
        public GeneralTableByAutoKod(string tableName, String kayName, bool hasStatus1)
           : base(tableName, kayName, hasStatus1)
        { }
        public int GetNextKod()
        {
            int max = 0;
            foreach (DataRow row in this.dt.Rows)
            {
                if (Convert.ToInt32(row[this.keyName]) > max)
                    max = Convert.ToInt32(row[this.keyName]);

            }
            return max + 1;

        }

    }
}

