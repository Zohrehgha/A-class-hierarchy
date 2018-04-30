using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class FloorClass
    {
        //Create Class Variables
        private int CFloorNo;
        private UnitClass[] CUnit;

        UnitClass[] Unit = new UnitClass[10];
        //Implementing default constructor
        public int i;
        public FloorClass()
        {

        }
        public FloorClass(int VFloorNo, UnitClass VUnit)
        {
            CFloorNo = VFloorNo;
            for (i = 0; i < 10; i++)
            {
            CUnit[i] = VUnit;
            //CUnit[0] = UnitClass.VUnitNo
            }
        }
        //Copy Constructor
        public FloorClass(FloorClass right)
        {
            this.CFloorNo = right.GetFloorNo();
            this.CUnit[i] = right.GetUnit(10);
            
        }
        //Creating access functions
        public int GetFloorNo()
        {
            return CFloorNo;
        }
        public void SetFloorNo(int VFloorNo)
        {
            CFloorNo = VFloorNo;
        }
        public UnitClass GetUnit(int number)
        {
            return CUnit[number];
        }
        public void SetUnit(UnitClass VUnit,int number)
        {
            CUnit[number] = VUnit;
        }
        

        public string MakeString()
        {

            string temp;
            temp = "";
            temp = temp + "FloorNo=" + CFloorNo;
            temp = temp + "\nUnit =" + CUnit;
            
            return temp;
        }
    }
}

    

    

