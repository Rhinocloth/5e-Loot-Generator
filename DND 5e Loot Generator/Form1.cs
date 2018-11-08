using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_5e_Loot_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            // check for type
            if (typeDropDown.SelectedIndex == 0)
            {
                // open TreasureHoard form
                TreasureHoard hoard = new TreasureHoard();
                hoard.Show();
            }
        }
    }
}
