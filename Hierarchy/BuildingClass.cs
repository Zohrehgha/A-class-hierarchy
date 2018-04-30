using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class BuildingClass
    {
        //Create Class Variables
        private string CBuildingName ;
        private FloorClass[] CFloor;
        private AddressClass CAddress;
        FloorClass[] Unit = new FloorClass[50];
        //Implementing default constructor
        public int i;
        public BuildingClass()
        {

        }
        public BuildingClass(string VBuildingName, FloorClass VFloor, AddressClass VAddress)
        {
            CBuildingName = VBuildingName;
            for (int i = 0; i < 50; i++)
            {
                CFloor[i] = VFloor;
                
            }
            CAddress = VAddress;
        }
        //Copy Constructor
        public BuildingClass(BuildingClass right)
        {
            this.CBuildingName = right.GetBuildingName();
            this.CFloor[i] = right.GetFloor(50);
            this.CAddress = right.GetAddress();
        }
        //Creating access functions
        public string GetBuildingName()
        {
            return CBuildingName;
        }
        public void SetFloorNo(string VBuildingName)
        {
            CBuildingName = VBuildingName;
        }
        public FloorClass GetFloor(int number)
        {
            return CFloor[number];
        }
        public void SetFloor(FloorClass VFloor, int number)
        {
            CFloor[number] = VFloor;
        }
        public AddressClass GetAddress()
        {
            return CAddress;
        }
        public void SetAddress(AddressClass VAddress)
        {
            CAddress = VAddress;
        }

        public string MakeString()
        {

            string temp;
            temp = "";
            temp = temp + "BuildingName=" + CBuildingName;
            temp = temp + "\nFloor =" + CFloor;
            temp = temp + "\nAddress =" + CAddress;

            return temp;
        }
    }
}
