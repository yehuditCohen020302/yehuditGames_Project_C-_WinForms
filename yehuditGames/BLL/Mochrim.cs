using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace yehuditGames.BLL
{
    public class Mochrim
    {
        private int idMocher;
        private string firstName;
        private string lastName;
        private DateTime date;
        private string city;
        private string street;
        private int numberOfHouse;
        private string phone;
        private bool status;

        public int IdMocher
        {
            get { return idMocher; }
            //  ???האם לעשות כאן בדיקת תקינות של מספר ת"ז
            set { idMocher = value; }
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
            firstName = value; }
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
            lastName = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
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
                city = value; }
        }

        public string Street
        {
            get { return street; }
            set {
                if (value == "")
                    throw new Exception("  הזן שם רחוב");
                if (value[0] == ' ')
                    throw new Exception("שם רחוב לא יכול להתחיל ברווח");
                street = value; }
        }
        public int NumberOfHouse
        {
            get { return numberOfHouse; }
            set {
                if (value <= 0)
                    throw new Exception("הזן מספר בית גדול מ - 0");

                numberOfHouse = value; }
        }
        public string Phone
        {
            get { return phone; }
            set {
                if (value.Length < 9)
                    throw new Exception("מספר טלפון לא תקין");
                phone = value; }
        }
        public Mochrim()
        {
            this.status = true;
        }
        public Mochrim(int idMoch, string firName, string lasName, DateTime date1, string city1, string street1, int numberHouse, string phone1, bool status1)
        {
            this.idMocher = idMoch;
            this.firstName = firName;
            this.lastName = lasName;
            this.date = date1;
            this.city = city1;
            this.street = street1;
            this.numberOfHouse = numberHouse;
            this.phone = phone1;
            this.status = status1;
        }
        public Mochrim(DataRow drOfProduct)
        {
            this.idMocher = Convert.ToInt32(drOfProduct["idMocher"]);
            this.firstName = Convert.ToString(drOfProduct["firstName"]);
            this.lastName = Convert.ToString(drOfProduct["lastName"]);
            this.date = Convert.ToDateTime(drOfProduct["date"]);
            this.city = Convert.ToString(drOfProduct["city"]);
            this.street = Convert.ToString(drOfProduct["street"]);
            this.numberOfHouse = Convert.ToInt32(drOfProduct["numberOfHouse"]);
            this.phone = Convert.ToString(drOfProduct["phone"]);
            this.status = Convert.ToBoolean(drOfProduct["status"]);
        }

        public DataRow ToDataRow()
        {
            DataTable dtOfProduct = new MochrimTable().Dt;
            DataRow dr = dtOfProduct.NewRow();
            dr["idMocher"] = this.idMocher;
            dr["firstName"] = this.firstName;
            dr["lastName"] = this.lastName;
            dr["date"] = this.date;
            dr["city"] = this.city;
            dr["street"] = this.street;
            dr["numberOfHouse"] = this.numberOfHouse;
            dr["phone"] = this.phone;
            dr["status"] = this.status;
            return dr;
        }





    }
}