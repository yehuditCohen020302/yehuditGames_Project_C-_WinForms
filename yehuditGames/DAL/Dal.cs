using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace yehuditGames.DAL
{
  public  class Dal
    {
        private static DataSet ds;
        private static OleDbConnection con;
        private static String[] namesOfTables = { "chavotDaat", "mishtamshim", "pratyRechisha", "pritim", "rechishot", "sales", "chevrot" };
        private static OleDbDataAdapter[] adapters;

        public static void ConnectToDb()
        {
            // con=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\תלמידה\Documents\יהודית כהן\‏‏פרויקט יהודית נמוךךךךךךךךךךךךךc# תשפ.mdb"'");
            ds = new DataSet();
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + System.IO.Directory.GetCurrentDirectory() + @"\Games.mdb'");
            adapters = new OleDbDataAdapter[namesOfTables.Length];
            for (int i = 0; i < namesOfTables.Length; i++)
            {
                adapters[i] = new OleDbDataAdapter("select * from " + namesOfTables[i], con);
                //שורה הבעייתית
                adapters[i].Fill(ds, namesOfTables[i]);

                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapters[i]);
                adapters[i].InsertCommand = builder.GetInsertCommand();
                adapters[i].UpdateCommand = builder.GetUpdateCommand();
                adapters[i].DeleteCommand = builder.GetDeleteCommand();

            }
        }
        public static void update(string nameOfTable)
        {
            for (int i = 0; i < namesOfTables.Length; i++)
                if (namesOfTables[i].Equals(nameOfTable))
                {
                    adapters[i].Update(ds, 
                        nameOfTable);
                    break;
                }
        }
        public static DataTable GetQuery(string strSql)
        {
            OleDbDataAdapter adpt = new OleDbDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public static DataTable GetTable(string nameOfTable)
        {
            return ds.Tables[nameOfTable];
        }
    }
}

