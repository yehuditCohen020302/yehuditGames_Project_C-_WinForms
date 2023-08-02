using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class MishtamshimTable : GeneralTableByAutoKod
    {
        public MishtamshimTable()
            : base( "Mishtamshim", "idMishtamesh", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["idMishtamesh"] = from["idMishtamesh"];
            to["firstName"] = from["firstName"];
            to["lastName"] = from["lastName"];
            to["Birthdate"] = from["Birthdate"];
            to["city"] = from["city"];
            to["street"] = from["street"];
            to["numberOfHouse"] = from["numberOfHouse"];
            to["phone"] = from["phone"];
            to["status"] = from["status"];
            to["pass"] = from["pass"];
            to["mylevel"] = from["mylevel"];
            to.EndEdit();
        }
        public DataTable GetResultFromSearch(string idMishtamesh)
        {
            return DAL.Dal.GetQuery("SELECT mishtamshim.idMishtamesh, mishtamshim.firstName, mishtamshim.lastName, mishtamshim.birthDate, mishtamshim.city, mishtamshim.street, mishtamshim.numberOfHouse, mishtamshim.phone, mishtamshim.pass FROM mishtamshim WHERE(((mishtamshim.idMishtamesh) = "+ idMishtamesh + ") AND((mishtamshim.status) = True))");
           
        }
        public DataTable GetTableById(string idMishtamesh)
        {string st= "SELECT mishtamshim.* FROM mishtamshim WHERE(((mishtamshim.idMishtamesh) = '"+ idMishtamesh + "'))";
            
            return DAL.Dal.GetQuery(st);


        }
        public DataTable GetTableByCity(string city)
        {
            return DAL.Dal.GetQuery("SELECT mishtamshim.*, mishtamshim.city FROM mishtamshim WHERE(((mishtamshim.city) = '"+ city + "'))");



        }
        public DataTable GetTableByName(string name)
        {
            return DAL.Dal.GetQuery("SELECT mishtamshim.*, mishtamshim.firstName FROM mishtamshim WHERE(((mishtamshim.firstName) = '" + name + "'))");

        }

    }
}


  