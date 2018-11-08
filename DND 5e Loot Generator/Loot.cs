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
    public partial class Loot : Form
    {
        private List<String> exclusions = new List<String>();
        private int crIndex;
        private bool evenAmounts;
        public Loot(List<String> exclusions, int crIndex, bool evenAmounts)
        {
            InitializeComponent();
            this.exclusions = exclusions;
            this.crIndex = crIndex;
            this.evenAmounts = evenAmounts;
            
        }

        private void Loot_Load(object sender, EventArgs e)
        {

        }

        private void GenerateLoot(int index)
        {
            switch (crIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
