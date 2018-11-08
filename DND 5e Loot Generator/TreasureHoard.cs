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
    public partial class TreasureHoard : Form
    {
        public TreasureHoard()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // variable declarations
            bool evenAmounts;
            int crIndex = 0;
            List<string> exclusions = new List<string>();

            evenAmounts = evenCheck.Checked;
            crIndex = crDropDown.SelectedIndex;
            exclusions.Add(Convert.ToString(exclusionListBox.SelectedItem));

            Loot loot = new Loot(exclusions, crIndex, evenAmounts);
            loot.Show();
        }
    }
}
