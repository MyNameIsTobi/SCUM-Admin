using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace SCUM_Admin
{
    class ListViewHelper
    {
        Color pastelRed = System.Drawing.ColorTranslator.FromHtml("#ff9994");

        public void CreateHeader(ListView listView, string[] headers)
        {
            foreach (var header in headers)
            {
                switch (header)
                {
                    case "Display Name":
                    case "Spawn Name":
                        listView.Columns.Add(header).Width = 250;
                        break;
                    case "Ingame Available":
                    case "Ingame Spawnable":
                        listView.Columns.Add(header).Width = 120;
                        break;
                    case "Location Name":
                        listView.Columns.Add(header).Width = 100;
                        break;
                    default:
                        listView.Columns.Add(header).Width = 75;
                        break;
                }
            }
            int lastColumn = headers.Length - 1;
            listView.Columns[lastColumn].Width = -2;
        }

        public MySqlConnection OpenSqlConnection()
        {
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.connString);

            try{ conn.Open(); }
            catch (Exception e) { Console.WriteLine(e.ToString()); }

            return conn;
        }

        public void CloseSqlConnection(MySqlConnection mySqlConnection)
        {
            mySqlConnection.Close();
        }

        public void PopulateRagned(string table, MySqlConnection conn, ListView listView)
        {
            
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("displayname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetString("caliber"));
                listViewItem.SubItems.Add(mySqlDataReader.GetInt32("hands").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("spawnable").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("available").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetString("spawnname"));
                if (!mySqlDataReader.GetBoolean("usable"))
                    listViewItem.BackColor = pastelRed;
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }

        public void PopulateMelee(string table, MySqlConnection conn, ListView listView)
        {
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("displayname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetString("caliber"));
                listViewItem.SubItems.Add(mySqlDataReader.GetInt32("hands").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("spawnable").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("available").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetString("spawnname"));
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }

        public void PopulateSmallLists(string table, MySqlConnection conn, ListView listView)
        {
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("displayname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("spawnable").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("available").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetString("spawnname"));
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }

        public void PopulateAmmo(string table, MySqlConnection conn, ListView listView)
        {
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("displayname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetString("caliber"));
                listViewItem.SubItems.Add(mySqlDataReader.GetInt32("amount").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("spawnable").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("available").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetString("spawnname"));
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }

        public void PopulateGear(string table, MySqlConnection conn, ListView listView)
        {
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("displayname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetString("color"));
                listViewItem.SubItems.Add(mySqlDataReader.GetString("camo"));
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("spawnable").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("available").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetString("spawnname"));
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }

        public void PopulateFood(string table, MySqlConnection conn, ListView listView)
        {
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("displayname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("toxic").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetInt32("amount").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("spawnable").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("available").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetString("spawnname"));
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }

        public void PopulateDrinks(string table, MySqlConnection conn, ListView listView)
        {
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("displayname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("alcoholic").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetInt32("amount").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("spawnable").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("available").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetString("spawnname"));
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }

        public void PopulateDrugstore(string table, MySqlConnection conn, ListView listView)
        {
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("displayname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetInt32("amount").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("spawnable").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetBoolean("available").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetString("spawnname"));
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }

        public void PopulateTeleportLocations(string table, MySqlConnection conn, ListView listView)
        {
            string mySqlString = "SELECT * from " + table;
            MySqlCommand cmd = new MySqlCommand(mySqlString, conn);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString("locationname"));
                listViewItem.SubItems.Add(mySqlDataReader.GetString("sector"));
                listViewItem.SubItems.Add(mySqlDataReader.GetDecimal("x").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetDecimal("y").ToString());
                listViewItem.SubItems.Add(mySqlDataReader.GetDecimal("z").ToString());
                listView.Items.Add(listViewItem);
            }

            mySqlDataReader.Close();
        }
    }
}
