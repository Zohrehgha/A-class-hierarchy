using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class AddressClass
    {
        //Create Class Variables
        private int CStreetNumber;
        private string CStreetName;
        private string CCity;
        private string CProvince;
        private string CZipcode ;
        private string CCountry;
        
        //Implementing overloaded constructors
        public AddressClass()
        {

        }
        //Implementing overloaded constructors
        public AddressClass(int VStreetNumber, string VStreetName, string VCity, string VProvince, string VZipcode, string VCountry)
        {
            CStreetNumber = VStreetNumber;
            CStreetName = VStreetName;
            CCity = VCity;
            CProvince = VProvince;
            CZipcode = VZipcode;
            CCountry = VCountry;
           
        }
        //Copy Constructor
        public AddressClass(AddressClass right)
        {
            this.CStreetNumber = right.GetStreetNumber();
            this.CStreetName = right.GetStreetName();
            this.CCity = right.GetCity();
            this.CProvince = right.GetProvince();
            this.CZipcode = right.GetZipcode();
            this.CCountry = right.GetCountry();
           
        }
        //Creating access functions
        public int GetStreetNumber()
        {
            return CStreetNumber;
        }
        public void SetStreetNumber(int VStreetNumber)
        {
            CStreetNumber = VStreetNumber;
        }
        public string GetStreetName()
        {
            return CStreetName;
        }
        public void SetStreetName(string VStreetName)
        {
            CStreetName = VStreetName;
        }
        public string GetCity()
        {
            return CCity;
        }
        public void SetCity(string VCity)
        {
            CCity = VCity;
        }
        public string GetProvince()
        {
            return CProvince;
        }
        public void SetProvince(string VProvince)
        {
            CProvince = VProvince;
        }
        public string GetZipcode()
        {
            return CZipcode;
        }
        public void SetZipcode(string VZipcode)
        {
            CZipcode = VZipcode;
        }
        public string GetCountry()
        {
            return CCountry;
        }
        public void SetCountry(string VCountry)
        {
            CCountry = VCountry;
        }


        public string MakeString()
        {

            string temp;
            temp = "";
            temp = temp + "StreetNumber=" + CStreetNumber;
            temp = temp + "\nStreetName =" + CStreetName;
            temp = temp + "\nCitys=" + CCity;
            temp = temp + "\nProvince=" + CProvince;
            temp = temp + "\nZipcode=" + CZipcode;
            temp = temp + "\nCountry=" + CCountry;
           
            return temp;
        }
    }
}

    

