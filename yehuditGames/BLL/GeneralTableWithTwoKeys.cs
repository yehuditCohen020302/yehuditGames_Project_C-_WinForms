using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class GeneralTableWithTwoKeys :GeneralTable
    {
        protected string anotherKeyName;
        public GeneralTableWithTwoKeys(string nameOfTable, string keyName1, string keyName2, bool hasStatus1)
            : base(nameOfTable, keyName1, hasStatus1)
        {
            this.anotherKeyName = keyName2;
        }
        public DataRow Find(object valueOfKey1, object valueOfKey2)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (row[this.keyName].Equals(valueOfKey1) && row[this.anotherKeyName].Equals(valueOfKey2))
                    return row;
            }
            return null;
        }
        public override bool IsSameKeys(DataRow row1, DataRow row2)
        {
            return base.IsSameKeys(row1, row2) && row1[this.anotherKeyName].Equals(row2[this.anotherKeyName]);
        }

    }
}
       

