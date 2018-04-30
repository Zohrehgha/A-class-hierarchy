using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class UnitClass
    {
        //Create Class Variables
        private int CUnitNo;
        private int CSquarefeet;
        private int CNoofBedrooms;
        private int CNoofBathrooms;
        private int CLocatedinfloor;
        private int CUnitName;
        private String CDirection;
        //Implementing overloaded constructors
        public UnitClass()
        {
            
        }
        //Implementing overloaded constructors
        public UnitClass(int VUnitNo, int VSquarefeet, int VNoofBedrooms, int VNoofBathrooms, int VLocatedinfloor, int VUnitName, String VDirection)
        {
            CUnitNo = VUnitNo;
            CSquarefeet = VSquarefeet;
            CNoofBedrooms = VNoofBedrooms;
            CNoofBathrooms = VNoofBathrooms;
            CLocatedinfloor = VLocatedinfloor;
            CUnitName = VUnitName;
            CDirection = VDirection;
        }
        //Copy Constructor
        public UnitClass(UnitClass right)
        {
            this.CUnitNo = right.GetUnitNo();
            this.CSquarefeet = right.GetSquarefeet();
            this.CNoofBedrooms = right.GetNoofBedrooms();
            this.CNoofBathrooms = right.GetNoofBathrooms();
            this.CLocatedinfloor = right.GetLocatedinfloor();
            this.CUnitName = right.GetUnitName();
            this.CDirection = right.GetDirection();
        }
        //Creating access functions
        public int GetUnitNo()
        {
            return CUnitNo;
        }
        public void SetUnitNo(int VUnitNo)
        {
            CUnitNo = VUnitNo;
        }
        public int GetSquarefeet()
        {
            return CSquarefeet;
        }
        public void SetSquarefeet(int VSquarefeet)
        {
            CSquarefeet = VSquarefeet;
        }
        public int GetNoofBedrooms()
        {
            return CNoofBedrooms;
        }
        public void SetNoofBedrooms(int VNoofBedrooms)
        {
            CNoofBedrooms = VNoofBedrooms;
        }
        public int GetNoofBathrooms()
        {
            return CNoofBathrooms;
        }
        public void SetNoofBathrooms(int VNoofBathrooms)
        {
            CNoofBathrooms = VNoofBathrooms;
        }
        public int GetLocatedinfloor()
        {
            return CLocatedinfloor;
        }
        public void SetLocatedinfloor(int VLocatedinfloor)
        {
            CLocatedinfloor = VLocatedinfloor;
        }
        public int GetUnitName()
        {
            return CUnitName;
        }
        public void SetUnitName(int VUnitName)
        {
            CUnitName = VUnitName;
        }
        public string GetDirection()
        {
            return CDirection;
        }
        public void SetDirection(string VDirection)
        {
            CDirection = VDirection;
        }

        public string MakeString()
        {

            string temp;
            temp = "";
            temp = temp + "UnitNo=" + CUnitNo;
            temp = temp + "\nSquarefeet =" + CSquarefeet;
            temp = temp + "\nNoofBedrooms=" + CNoofBedrooms;
            temp = temp + "\nNoofBathrooms=" + CNoofBathrooms;
            temp = temp + "\nLocatedinfloor=" + CLocatedinfloor;
            temp = temp + "\nUnitName=" + CUnitName;
            temp = temp + "\nDirection=" + CDirection;
            return temp;
        }
    }
}

    

