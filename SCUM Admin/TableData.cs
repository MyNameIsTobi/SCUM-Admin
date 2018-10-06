using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCUM_Admin
{
    internal class TableData
    {
        private MySqlConnection connection;

        //Server=dontplayalone.de;port=3306;User Id=scumadmin;password=meY16m&4;Database=scumadmin;SslMode=none
        internal TableData(string server, string database, string uid, string password, string sslMode = "SslMode=none")
        {
            string connString = "Server=" + server + ";port=3306;User Id=" + uid + ";Password=" + password + ";Database=" + database + ";" + sslMode + ";";
            connection = new MySqlConnection(connString);
        }

        internal DataSet getRangedWeaponData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`caliber` AS 'Caliber',`hands` AS 'Hands',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `ranged` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getMeleeWeaponData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`caliber` AS 'Caliber',`hands` AS 'Hands',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `melee` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getWeaponpartsData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `weaponparts` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getAmmoData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`caliber` AS 'Caliber',`amount` AS 'Amount',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `ammo` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getHeadgearData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`color` AS 'Color',`camo` AS 'Camoflage',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `headgear` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getTopsData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`color` AS 'Color',`camo` AS 'Camoflage',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `tops` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getPantsData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`color` AS 'Color',`camo` AS 'Camoflage',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `pants` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getShoesData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`color` AS 'Color',`camo` AS 'Camoflage',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `shoes` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getBackpacksData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`color` AS 'Color',`camo` AS 'Camoflage',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `backpacks` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getVestsData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`color` AS 'Color',`camo` AS 'Camoflage',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `vests` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getMiscGearData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`color` AS 'Color',`camo` AS 'Camoflage',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `miscgear` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getToolsData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `tools` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getCraftingData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `crafting` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getFoodData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`toxic` AS 'Toxic',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `food` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getDrinksData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`alcoholic` AS 'Alcolohic',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `drinks` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getDrugstoreData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`amount` AS 'Amount',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `drugstore` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getNpcData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`friendly` as 'Friendly',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `npcs` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getNpcPartseData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `npcparts` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getEnvironmentData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `environment` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal DataSet getMiscData(string searchString = "")
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT `displayname` AS 'Displayname',`spawnable` AS 'Ingame Spawnable',`usable` AS 'Ingame Usable',`available` AS 'Ingame Available',`spawnname` AS 'Spawnname' FROM `misc` WHERE `displayname` LIKE '%" + searchString + "%' ORDER BY `displayname` ASC", connection);
            dataAdapter.Fill(ds);
            return ds;
        }

        internal MySqlConnection OpenConnection()
        {
            try
            {
                connection.Open();
                return connection;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.Contact administrator");
                        break;
                    case 1:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(e.Message);
                        break;
                }
                return null;
            }
        }

        internal bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


    }
}
