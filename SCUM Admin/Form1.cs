using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using update;

namespace SCUM_Admin
{
    public partial class scumAdmin : Form, Updateable
    {
        ListViewHelper lvh = new ListViewHelper();
        ProcessHandler hndlr = new ProcessHandler();

        public string ApplicationName
        {
            get { return "SCUM Admin"; }
        }

        public string ApplicationID
        {
            get { return "SCUM Admin"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri(""); }
        }

        public Form Context
        {
            get { return this; }
        }

        public scumAdmin()
        {
            InitializeComponent();
            VersionLabel.Text = ApplicationAssembly.GetName().Version.ToString();
        }

        private void spawnButton_Click(object sender, EventArgs e)
        {

            if (amount.Text.Length > 1)
            {
                MessageBox.Show("Please select a numer between 1 and 9!", "Nononononono!");
                return;
            }

            if (!hndlr.setForground())
                return;

            int spawnAamount = Convert.ToInt32(amount.Text);
            string itemToSpawn = string.Empty;
            string selectedTab = itemsTab.SelectedTab.Name;

            switch (selectedTab)
            {
                case "rangedWeaponsTab":
                    if (rangedList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(rangedList.SelectedItems[0].SubItems[rangedList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "meleeWeaponsTab":
                    if (meleeList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(meleeList.SelectedItems[0].SubItems[meleeList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "weaponpartsTab":
                    if (weaponpartsList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(weaponpartsList.SelectedItems[0].SubItems[weaponpartsList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "ammoTab":
                    if (ammoList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(ammoList.SelectedItems[0].SubItems[ammoList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "headgearTab":
                    if (headgearList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(headgearList.SelectedItems[0].SubItems[headgearList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "topsTab":
                    if (topsList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(topsList.SelectedItems[0].SubItems[topsList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "pantsTab":
                    if (pantsList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(pantsList.SelectedItems[0].SubItems[pantsList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "shoesTab":
                    if (shoesList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(shoesList.SelectedItems[0].SubItems[shoesList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "backpacksTab":
                    if (backpacksList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(backpacksList.SelectedItems[0].SubItems[backpacksList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "vestsTab":
                    if (vestsList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(vestsList.SelectedItems[0].SubItems[vestsList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "miscGearTab":
                    if (miscGearList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(miscGearList.SelectedItems[0].SubItems[miscGearList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "toolsTab":
                    if (toolsList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(toolsList.SelectedItems[0].SubItems[toolsList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "craftingTab":
                    if (craftingList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(craftingList.SelectedItems[0].SubItems[craftingList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "foodTab":
                    if (foodList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(foodList.SelectedItems[0].SubItems[foodList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "drinkTab":
                    if (drinksList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(drinksList.SelectedItems[0].SubItems[drinksList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "drugstoreTab":
                    if (drugstoreList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(drugstoreList.SelectedItems[0].SubItems[drugstoreList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "npcTab":
                    if (npcList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnNpc(npcList.SelectedItems[0].SubItems[npcList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "npcpartsTab":
                    if (npcPartsList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(npcPartsList.SelectedItems[0].SubItems[npcPartsList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "envTab":
                    if (envList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(envList.SelectedItems[0].SubItems[envList.Columns.Count - 1].Text, spawnAamount);
                    break;
                case "miscTab":
                    if (miscList.SelectedItems.Count != 1)
                    {
                        MessageBox.Show("Plase select a row!", "Nononononono!");
                        break;
                    }
                    hndlr.SpawnItem(miscList.SelectedItems[0].SubItems[miscList.Columns.Count - 1].Text, spawnAamount);
                    break;
            }
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void steamIdTextBoxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( steamIdTextBox.Text.Length >= 17 )
            {
                e.Handled = true;
            }
        }

        private void teleportToLocationButton_Click(object sender, EventArgs e)
        {
            string steamID = steamIdTextBox.Text;

            if (steamID == string.Empty || steamID.Length != 17)
            {
                MessageBox.Show("Please enter you SteamID 64 first!", "Nononononono!");
                return;
            }

            if (teleportLocationsList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select a row first!", "Nononononono!");
                return;
            }

            string x = teleportLocationsList.SelectedItems[0].SubItems[2].Text;
            string y = teleportLocationsList.SelectedItems[0].SubItems[3].Text;
            string z = teleportLocationsList.SelectedItems[0].SubItems[4].Text;

            if (!hndlr.setForground())
                return;

            hndlr.Teleport(steamID, x.Replace(',', '.'), y.Replace(',', '.'), z.Replace(',', '.'));
        }

        private void scumAdmin_Load(object sender, EventArgs e)
        {
            steamIdTextBox.Text = Properties.Settings.Default.steamId64;
            MySqlConnection mySqlConnection = lvh.OpenSqlConnection();

            lvh.CreateHeader(rangedList, new string[] { "Display Name", "Caliber", "Hands", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateRagned("ranged", mySqlConnection, rangedList);

            lvh.CreateHeader(meleeList, new string[] { "Display Name", "Caliber", "Hands", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateRagned("melee", mySqlConnection, meleeList);

            lvh.CreateHeader(weaponpartsList, new string[] { "Display Name", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateSmallLists("weaponparts", mySqlConnection, weaponpartsList);

            lvh.CreateHeader(ammoList, new string[] { "Display Name", "Caliber", "Amount", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateAmmo("ammo", mySqlConnection, ammoList);

            lvh.CreateHeader(headgearList, new string[] { "Display Name", "Color", "Cwamouflage", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateGear("headgear", mySqlConnection, headgearList);

            lvh.CreateHeader(topsList, new string[] { "Display Name", "Color", "Cwamouflage", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateGear("tops", mySqlConnection, topsList);

            lvh.CreateHeader(pantsList, new string[] { "Display Name", "Color", "Cwamouflage", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateGear("pants", mySqlConnection, pantsList);

            lvh.CreateHeader(shoesList, new string[] { "Display Name", "Color", "Cwamouflage", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateGear("shoes", mySqlConnection, shoesList);

            lvh.CreateHeader(backpacksList, new string[] { "Display Name", "Color", "Cwamouflage", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateGear("backpacks", mySqlConnection, backpacksList);

            lvh.CreateHeader(vestsList, new string[] { "Display Name", "Color", "Cwamouflage", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateGear("vests", mySqlConnection, vestsList);

            lvh.CreateHeader(miscGearList, new string[] { "Display Name", "Color", "Cwamouflage", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateGear("miscgear", mySqlConnection, miscGearList);

            lvh.CreateHeader(toolsList, new string[] { "Display Name", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateSmallLists("tools", mySqlConnection, toolsList);

            lvh.CreateHeader(craftingList, new string[] { "Display Name", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateSmallLists("crafting", mySqlConnection, craftingList);

            lvh.CreateHeader(foodList, new string[] { "Display Name", "Toxic", "Amount", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateFood("food", mySqlConnection, foodList);

            lvh.CreateHeader(drinksList, new string[] { "Display Name", "Alcoholic", "Amount", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateDrinks("drinks", mySqlConnection, drinksList);

            lvh.CreateHeader(drugstoreList, new string[] { "Display Name", "Amount", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateDrugstore("drugstore", mySqlConnection, drugstoreList);

            lvh.CreateHeader(npcList, new string[] { "Display Name", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateSmallLists("npcs", mySqlConnection, npcList);

            lvh.CreateHeader(npcPartsList, new string[] { "Display Name", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateSmallLists("npcparts", mySqlConnection, npcPartsList);

            lvh.CreateHeader(envList, new string[] { "Display Name", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateSmallLists("environment", mySqlConnection, envList);

            lvh.CreateHeader(miscList, new string[] { "Display Name", "Ingame Spawnable", "Ingame Available", "Spawn Name" });
            lvh.PopulateSmallLists("misc", mySqlConnection, miscList);

            lvh.CreateHeader(teleportLocationsList, new string[] { "Location Name", "Sector", "x", "y", "z" });
            lvh.PopulateTeleportLocations("teleport_locations", mySqlConnection, teleportLocationsList);

            lvh.CloseSqlConnection(mySqlConnection);
        }

        private void scumAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.steamId64 = steamIdTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
