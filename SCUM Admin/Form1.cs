using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using update;
using System.Data;

namespace SCUM_Admin
{
    public partial class scumAdmin : Form, Updateable
    {
        ProcessHandler hndlr = new ProcessHandler();
        TableData data = new TableData("dontplayalone.de", "scumadmin", "scumadmin", "meY16m&4");
        private Updater updater;

        #region Updater
        public string ApplicationName
        {
            get { return "SCUM Admin"; }
        }

        public string ApplicationID
        {
            get { return "SCUM_Admin"; }
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
            get { return new Uri("http://scumadmin.rootgeek.org/update.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }
        #endregion

        public scumAdmin()
        {
            // Init all Components
            InitializeComponent();

            //setSettings
            tbSteamId.Text = Properties.Settings.Default.steamId64;
            hideIngameAvailable.Checked = Properties.Settings.Default.hideAvailable;
            hideIngameSpawnable.Checked = Properties.Settings.Default.hideSpawnable;
            hideIngameUsable.Checked = Properties.Settings.Default.hideUsable;
            switchBackToApp.Checked = Properties.Settings.Default.switchBack;
            setAmountBack.Checked = Properties.Settings.Default.setAmountBack;

            //Check for Updates
            updater = new Updater(this);
            updater.DoUpdate();

            //Populate Tables
            MySqlConnection connection = data.OpenConnection();
            TableRanged.DataSource = data.getRangedWeaponData().Tables[0];
            TableMelee.DataSource = data.getMeleeWeaponData().Tables[0];
            TableWeaponParts.DataSource = data.getWeaponpartsData().Tables[0];
            TableAmmo.DataSource = data.getAmmoData().Tables[0];
            TableHeadGear.DataSource = data.getHeadgearData().Tables[0];
            TableTops.DataSource = data.getTopsData().Tables[0];
            TablePants.DataSource = data.getPantsData().Tables[0];
            TableShoes.DataSource = data.getShoesData().Tables[0];
            TableBackpacks.DataSource = data.getBackpacksData().Tables[0];
            TableVests.DataSource = data.getVestsData().Tables[0];
            TableMiscGear.DataSource = data.getMiscGearData().Tables[0];
            TableTools.DataSource = data.getToolsData().Tables[0];
            TableCrafting.DataSource = data.getCraftingData().Tables[0];
            TableFood.DataSource = data.getFoodData().Tables[0];
            TableDrinks.DataSource = data.getDrinksData().Tables[0];
            TableDrugstore.DataSource = data.getDrugstoreData().Tables[0];
            TableNPC.DataSource = data.getNpcData().Tables[0];
            TableNpcParts.DataSource = data.getNpcPartseData().Tables[0];
            TableEnvironment.DataSource = data.getEnvironmentData().Tables[0];
            TableMisc.DataSource = data.getMiscData().Tables[0];
            connection.Close();

            //Set Current Version
            VersionLabel.Text = ApplicationAssembly.GetName().Version.ToString();
        }

        private void steamIdTextBoxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( tbSteamId.Text.Length >= 17 )
            {
                e.Handled = true;
            }
        }

        private void teleportToLocationButton_Click(object sender, EventArgs e)
        {
            string steamID = tbSteamId.Text;

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
            tbSteamId.Text = Properties.Settings.Default.steamId64;
        }

        private void scumAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.steamId64 = tbSteamId.Text;
            Properties.Settings.Default.Save();
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || ((TextBox)sender).Text.Length >= 2)
            {
                e.Handled = true;
            }
        }

        #region Reanged Weapons
        private void btnSpawnRanged_Click(object sender, EventArgs e)
        {
            string item = Convert.ToString(TableRanged.Rows[TableRanged.SelectedCells[0].RowIndex].Cells["Spawnname"].Value);
            int amount = Convert.ToInt32(tbAmountRanged.Text);
            hndlr.SpawnItem(item, amount);
            tbAmountRanged.Text = "1";
        }

        private void tbSearchRanged_KeyUp(object sender, KeyEventArgs e)
        {
            TableRanged.DataSource = data.getRangedWeaponData(tbSearchRanged.Text).Tables[0];
        }
        #endregion

        #region Melee Weapons
        private void btnSpawnMelee_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchMelee_KeyUp(object sender, KeyEventArgs e)
        {
            TableMelee.DataSource = data.getMeleeWeaponData(tbSearchMelee.Text).Tables[0];
        }
        #endregion

        #region Weaponparts
        private void btnSpawnWeaponparts_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchWeaponparts_KeyUp(object sender, KeyEventArgs e)
        {
            TableWeaponParts.DataSource = data.getWeaponpartsData(tbSearchWeaponparts.Text).Tables[0];
        }
        #endregion

        #region Ammo
        private void btnSpawnAmmo_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchAmmo_KeyUp(object sender, KeyEventArgs e)
        {
            TableAmmo.DataSource = data.getAmmoData(tbSearchAmmo.Text).Tables[0];
        }
        #endregion

        #region Headgear
        private void btnSpawnHeadgear_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchHeadgear_KeyUp(object sender, KeyEventArgs e)
        {
            TableHeadGear.DataSource = data.getHeadgearData(tbSearchHeadgear.Text).Tables[0];
        }
        #endregion

        #region Tops
        private void btnSpawnTops_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchTops_KeyUp(object sender, KeyEventArgs e)
        {
            TableTops.DataSource = data.getTopsData(tbSearchTops.Text).Tables[0];
        }
        #endregion

        #region Pants
        private void btnSpawnPants_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchPants_KeyUp(object sender, KeyEventArgs e)
        {
            TablePants.DataSource = data.getPantsData(tbSearchPants.Text).Tables[0];
        }
        #endregion

        #region Shoes
        private void btnSpawnShoes_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchShoes_KeyUp(object sender, KeyEventArgs e)
        {
            TableShoes.DataSource = data.getShoesData(tbSearchShoes.Text).Tables[0];
        }
        #endregion

        #region Backpacks
        private void btnSpawnBackpacks_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchBackpacks_KeyUp(object sender, KeyEventArgs e)
        {
            TableBackpacks.DataSource = data.getBackpacksData(tbSearchBackpacks.Text).Tables[0];
        }
        #endregion

        #region Vests
        private void btnSpawnVests_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchVests_KeyUp(object sender, KeyEventArgs e)
        {
            TableVests.DataSource = data.getVestsData(tbSearchVests.Text).Tables[0];
        }
        #endregion

        #region Miscgear
        private void btnSpawnMiscgear_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchMiscgear_KeyUp(object sender, KeyEventArgs e)
        {
            TableMiscGear.DataSource = data.getMiscGearData(tbSearchMiscgear.Text).Tables[0];
        }
        #endregion

        #region Tools
        private void btnSpawnTools_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchTools_KeyUp(object sender, KeyEventArgs e)
        {
            TableTools.DataSource = data.getToolsData(tbSearchTools.Text).Tables[0];
        }
        #endregion

        #region Crafting
        private void btnSpawnCrafting_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchCrafting_KeyUp(object sender, KeyEventArgs e)
        {
            TableCrafting.DataSource = data.getCraftingData(tbSearchCrafting.Text).Tables[0];
        }
        #endregion

        #region Food
        private void Food_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchFood_KeyUp(object sender, KeyEventArgs e)
        {
            TableFood.DataSource = data.getFoodData(tbSearchFood.Text).Tables[0];
        }
        #endregion

        #region Drinks
        private void btnSpawnDrinks_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchDrinks_KeyUp(object sender, KeyEventArgs e)
        {
            TableDrinks.DataSource = data.getDrinksData(tbSearchDrinks.Text).Tables[0];
        }
        #endregion

        #region Drugstore
        private void btnSpawnDrugstore_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchDrugstore_KeyUp(object sender, KeyEventArgs e)
        {
            TableDrugstore.DataSource = data.getDrugstoreData(tbSearchDrugstore.Text).Tables[0];
        }
        #endregion

        #region Npc
        private void btnSpawnNpc_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchNpc_KeyUp(object sender, KeyEventArgs e)
        {
            TableNPC.DataSource = data.getNpcData(tbSearchNpc.Text).Tables[0];
        }
        #endregion

        #region Npcparts
        private void btnSpawnNpcparts_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchNpcparts_KeyUp(object sender, KeyEventArgs e)
        {
            TableNpcParts.DataSource = data.getNpcPartseData(tbSearchNpcparts.Text).Tables[0];
        }
        #endregion

        #region Environment
        private void btnSpawnEnvironment_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchEnvironment_KeyUp(object sender, KeyEventArgs e)
        {
            TableEnvironment.DataSource = data.getEnvironmentData(tbSearchEnvironment.Text).Tables[0];
        }
        #endregion

        #region Misc
        private void btnSpawnMisc_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchMisc_KeyUp(object sender, KeyEventArgs e)
        {
            TableMisc.DataSource = data.getMiscData(tbSearchMisc.Text).Tables[0];
        }
        #endregion

        #region Settings
        private void hideIngameSpawnable_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.hideSpawnable = hideIngameSpawnable.Checked;
        }

        private void hideIngameUsable_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.hideUsable = hideIngameSpawnable.Checked;
        }

        private void hideIngameAvailable_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.hideAvailable = hideIngameAvailable.Checked;
        }

        private void switchBackToApp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.switchBack = switchBackToApp.Checked;
        }

        private void setAmountBack_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.setAmountBack = setAmountBack.Checked;
        }
        #endregion
    }
}
