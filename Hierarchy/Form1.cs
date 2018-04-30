using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hierarchy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FloorClass[] Unit = new FloorClass[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnitClass UNTobj1 = new UnitClass(1, 4, 3, 3, 8, 34, "South");
            MessageBox.Show(" \n" + UNTobj1.MakeString() + "\n");

            AddressClass ADRobj2 = new AddressClass(155, "Georgia", "Vancouver", "BC", "U6F 3F5", "Canada");
            MessageBox.Show(" \n" + ADRobj2.MakeString() + "\n");
            
            BuildingClass BLDObj2 = new BuildingClass();
            MessageBox.Show(" \n" + BLDObj2.MakeString() + "\n");

            FloorClass FLRObj1 = new FloorClass();
            MessageBox.Show(" \n" + FLRObj1.MakeString() + "\n");


        }

    }
}
