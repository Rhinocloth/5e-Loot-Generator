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
            // find connection string
            string connectionString = DND_5e_Loot_Generator.Properties.Settings.Default.Magic_ItemConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand findJug = new SqlCommand("SELECT * FROM ITEM_LIST WHERE Name = 'Alchemy Jug';", connection))
                {
                    using (SqlDataReader reader = findJug.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Object[] array = new Object[10];
                                reader.GetValues(array);
                                for (int o = 0; i < array.Length; i++)
                                {
                                    displayLabel.Text += array[i] + " ";
                                }
                                displayLabel.Text += "\n";
                                
                            }
                        }
                    }
                }
            }
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
