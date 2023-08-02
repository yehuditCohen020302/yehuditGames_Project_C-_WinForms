using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
 public   class GeneralTable
    {
        protected DataTable dt;

        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        protected string keyName;
        protected Boolean hasStatus;


        public GeneralTable(string tableName, string keyName1, bool hasStatus1)
        {
            this.dt = DAL.Dal.GetTable(tableName);
            this.keyName = keyName1;
            this.hasStatus = hasStatus1;
        }
        public DataRow Find(Object valueOfKey)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (row[this.keyName].ToString().Equals(valueOfKey.ToString()))

                    if (hasStatus)
                        if (Convert.ToBoolean(row["status"]) == true)
                            return row;
                        else
                            return null;
                    else return row;


            }
            return null;
        }
        public DataRow Find(string nameOfField, object valueOfField)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (row[nameOfField].Equals(valueOfField))
                    if (hasStatus)
                    {
                        if (Convert.ToBoolean(row["status"]) == true)
                            return row;

                    }
                    else return row;

            }
            return null;
        }
        public bool Add(DataRow drToAdd)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (IsSameKeys(row, drToAdd))
                    if (this.hasStatus)
                        if (Convert.ToBoolean(row["status"]) == true)
                            return false;
                        else
                        {
                            this.Update(drToAdd, row);
                            DAL.Dal.update(this.dt.TableName);
                            return true;
                        }
                    else
                        return false;
            }

            this.dt.Rows.Add(drToAdd);
            DAL.Dal.update(this.dt.TableName);
            return true;
        }

        public virtual void Update(DataRow from, DataRow to)
        {

        }

        public bool Update(DataRow drToUpdate)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (IsSameKeys(row, drToUpdate))
                {
                    if (hasStatus)
                        if (Convert.ToBoolean(row["status"]) == true)
                        {
                            this.Update(drToUpdate, row);
                            DAL.Dal.update(this.dt.TableName);
                            return true;
                        }
                        else
                            return false;
                    else
                    {
                        this.Update(drToUpdate, row);
                        DAL.Dal.update(this.dt.TableName);
                        return true;
                    }

                }


            }

            return false;
        }
        public bool Delete(DataRow drToDelete)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (IsSameKeys(row, drToDelete))
                {
                    if (hasStatus)
                    {
                        row["status"] = false;
                        DAL.Dal.update(this.dt.TableName);
                        return true;
                    }
                    else
                    {
                        row.Delete();

                        DAL.Dal.update(this.dt.TableName);
                        return true;
                    }

                }

            }
            return false;
        }

        public DataTable GetTable()
        {
            string st;
            if (this.hasStatus)
                st = "select * from " + this.dt.TableName + " where status=true";
            else
                st = "select * from " + this.dt.TableName;
            DataTable dt = DAL.Dal.GetQuery(st);
            return dt;
        }

        public virtual bool IsSameKeys(DataRow row1, DataRow row2)
        {
            return row1[this.keyName].Equals(row2[this.keyName]);
        }


        //הפעולה מקבלת שתי שדות ומחזירה טבלה המכילה 2 עמודות . האחת, מכילה את שדה המפתח והשניה מכילה שרשור של שדה המפתח ושני השדות שהתקבלו   
        public DataTable GetTableForComboBox(string filedName1, string filedName2)
        {
            string st;

            if (this.hasStatus)
                st = "SELECT " + this.keyName + ", [" + this.keyName + "] & '-' & [" + filedName1 + "] & ' ' & [" + filedName2 + "] AS fullName FROM " + this.dt.TableName + " where status=true";
            else
                st = "SELECT " + this.keyName + ", [" + this.keyName + "] & '-' & [" + filedName1 + "] & ' ' & [" + filedName2 + "] AS fullName FROM " + this.dt.TableName;

            DataTable dt = DAL.Dal.GetQuery(st);
            return dt;
        }

    }
}

   