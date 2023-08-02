
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class Mishtamshim
    {
        private string idMishtamesh;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string city;
        private string street;
        private int numberOfHouse;
        private string phone;
        private bool status;
        private string pass;
        private bool mylevel;

        public String IdMishtamesh
        {
            get { return idMishtamesh; }

            //בדיקת תקינות של מספר ת"ז
            set
            {
                /*
                while (value.Length < 9)
                    value = "0" + value;
                int a = 0;
                for (int i = 0; i < 9; i++)
                {
                    int b = value[i] - '0';
                    if (i % 2 == 0)
                        a = a + b;
                    else
                    {
                        b = b * 2;
                        b = (b / 10) + (b % 10);
                        a = a + b;
                    }
                }
                if (a % 10 == 0)
                    throw new Exception("הזן תעודת זהות תקינה");
                    */
                idMishtamesh = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם");
                if (value[0] == ' ')
                    throw new Exception("שם לא מתחיל ברווח");
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם");
                if (value[0] == ' ')
                    throw new Exception("שם משפחה לא מתחיל ברווח");
                lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Today)
                    throw new Exception("הזן תאריך מוקדם יותר");
                birthDate = value; }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (value == "")
                    throw new Exception("  הזן שם עיר");
                if (value[0] == ' ')
                    throw new Exception("שם עיר לא יכול להתחיל ברווח");
                city = value;
            }
        }
        public string Street
        {
            get { return street; }
            set
            {
                if (value == "")
                    throw new Exception("  הזן שם רחוב");
                if (value[0] == ' ')
                    throw new Exception("שם רחוב לא יכול להתחיל ברווח");
                street = value;
            }
        }
        public int NumberOfHouse
        {
            get { return numberOfHouse; }
            set
            {
                if (value <= 0)
                    throw new Exception("הזן מספר בית גדול מ - 0");

                numberOfHouse = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.Length < 9 && value.Length >10)
                    throw new Exception("מספר טלפון לא תקין");
                phone = value;
            }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public bool Status { get; set; }
        public bool Mylevel
        {
            get { return mylevel; }
            set { mylevel = value; }
        }
        public Mishtamshim()
        {
            this.status = true;
        }
        public Mishtamshim(string idMishtamesh, string firName, string lasName, DateTime date1, string city1, string street1, int numberHouse, string phone1, bool status1, string pass, bool mylevel)
        {
            this.idMishtamesh = idMishtamesh;
            this.firstName = firName;
            this.lastName = lasName;
            this.birthDate = date1;
            this.city = city1;
            this.street = street1;
            this.numberOfHouse = numberHouse;
            this.phone = phone1;
            this.status = status1;
            this.pass = pass;
            this.mylevel = mylevel;
        }
        public Mishtamshim(DataRow drOfMishtamshim)
        {
            this.idMishtamesh = Convert.ToString(drOfMishtamshim["idMishtamesh"]);
            this.firstName = Convert.ToString(drOfMishtamshim["firstName"]);
            this.lastName = Convert.ToString(drOfMishtamshim["lastName"]);
            this.birthDate = Convert.ToDateTime(drOfMishtamshim["birthDate"]);
            this.city = Convert.ToString(drOfMishtamshim["city"]);
            this.street = Convert.ToString(drOfMishtamshim["street"]);
            this.numberOfHouse = Convert.ToInt32(drOfMishtamshim["numberOfHouse"]);
            this.phone = Convert.ToString(drOfMishtamshim["phone"]);
            this.status = Convert.ToBoolean(drOfMishtamshim["status"]);
            this.pass = Convert.ToString(drOfMishtamshim["pass"]);
            this.mylevel = Convert.ToBoolean(drOfMishtamshim["mylevel"]);
        }
        public DataRow ToDataRow()
        {
            MishtamshimTable allMishtamshim = new MishtamshimTable();
            DataTable drOfMishtamshim = new MishtamshimTable().Dt;
            DataRow dr = drOfMishtamshim.NewRow();
            dr["idMishtamesh"] = this.idMishtamesh;
            dr["firstName"] = this.firstName;
            dr["lastName"] = this.lastName;
            dr["birthDate"] = this.birthDate;
            dr["city"] = this.city;
            dr["street"] = this.street;
            dr["numberOfHouse"] = this.numberOfHouse;
            dr["phone"] = this.phone;
            dr["status"] = this.status;
            dr["pass"] = this.pass;
            dr["mylevel"] = this.mylevel;
            return dr;
        }
    }
}
