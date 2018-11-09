using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            GenerateLoot();
        }

        private void GenerateLoot()
        {
            Random rand = new Random();
            string commandString = "";

            switch (crIndex)
            {
                case 0:
                    int[] itemAmounts = { 0,0,1,1,2,3,4 };
                    int numItems = itemAmounts[rand.Next(0, itemAmounts.Length - 1)];
                    for (int i = 0; i < numItems; i++)
                    {
                        int percent = rand.Next(1, 11);
                        percent = 11;
                        if (percent <= 6)
                            commandString = "Select top 1 * From ITEM_LIST where Rarity = 'common' and (Type = 'potion' or Type = 'scroll' or Subtype = 'consumable') order by NewId();";
                        
                        else if (percent > 6 && percent <= 8)
                            commandString = "Select top 1 * From ITEM_LIST where Rarity = 'uncommon' and (Type = 'potion' or Type = 'scroll' or Subtype = 'consumable') order by NewId();";

                        else if (percent == 9)
                            commandString = "Select top 1 * From ITEM_LIST where Rarity = 'rare' and (Type = 'potion' or Type = 'scroll' or Subtype = 'consumable') order by NewId();";

                        else
                            commandString = "Select top 1 * From ITEM_LIST where Rarity = 'uncommon' and not (Type = 'potion' or Type = 'scroll' or Subtype = 'consumable') order by NewId();";

                        randomItem(commandString);
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        public void randomItem(string commandString)
        {
            string connectionString = DND_5e_Loot_Generator.Properties.Settings.Default.Magic_ItemConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand find = new SqlCommand(commandString, connection);
            SqlDataReader reader = find.ExecuteReader();
            
            while (reader.Read())
            {
                Object[] array = new Object[10];
                reader.GetValues(array);
                for (int i = 0; i < array.Length; i++)
                {
                    displayLabel.Text += array[i] + " ";
                }
                displayLabel.Text += "\n";
            }
        }
    }
}
