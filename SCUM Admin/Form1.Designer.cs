namespace SCUM_Admin
{
    partial class scumAdmin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scumAdmin));
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.spawntable = new System.Windows.Forms.TabPage();
            this.spawnButton = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.itemsTab = new System.Windows.Forms.TabControl();
            this.rangedWeaponsTab = new System.Windows.Forms.TabPage();
            this.rangedList = new System.Windows.Forms.ListView();
            this.meleeWeaponsTab = new System.Windows.Forms.TabPage();
            this.meleeList = new System.Windows.Forms.ListView();
            this.weaponpartsTab = new System.Windows.Forms.TabPage();
            this.weaponpartsList = new System.Windows.Forms.ListView();
            this.ammoTab = new System.Windows.Forms.TabPage();
            this.ammoList = new System.Windows.Forms.ListView();
            this.headgearTab = new System.Windows.Forms.TabPage();
            this.headgearList = new System.Windows.Forms.ListView();
            this.topsTab = new System.Windows.Forms.TabPage();
            this.topsList = new System.Windows.Forms.ListView();
            this.pantsTab = new System.Windows.Forms.TabPage();
            this.pantsList = new System.Windows.Forms.ListView();
            this.shoesTab = new System.Windows.Forms.TabPage();
            this.shoesList = new System.Windows.Forms.ListView();
            this.backpacksTab = new System.Windows.Forms.TabPage();
            this.backpacksList = new System.Windows.Forms.ListView();
            this.vestsTab = new System.Windows.Forms.TabPage();
            this.vestsList = new System.Windows.Forms.ListView();
            this.miscGearTab = new System.Windows.Forms.TabPage();
            this.miscGearList = new System.Windows.Forms.ListView();
            this.toolsTab = new System.Windows.Forms.TabPage();
            this.toolsList = new System.Windows.Forms.ListView();
            this.craftingTab = new System.Windows.Forms.TabPage();
            this.craftingList = new System.Windows.Forms.ListView();
            this.foodTab = new System.Windows.Forms.TabPage();
            this.foodList = new System.Windows.Forms.ListView();
            this.drinkTab = new System.Windows.Forms.TabPage();
            this.drinksList = new System.Windows.Forms.ListView();
            this.drugstoreTab = new System.Windows.Forms.TabPage();
            this.drugstoreList = new System.Windows.Forms.ListView();
            this.npcTab = new System.Windows.Forms.TabPage();
            this.npcList = new System.Windows.Forms.ListView();
            this.npcpartsTab = new System.Windows.Forms.TabPage();
            this.npcPartsList = new System.Windows.Forms.ListView();
            this.envTab = new System.Windows.Forms.TabPage();
            this.envList = new System.Windows.Forms.ListView();
            this.miscTab = new System.Windows.Forms.TabPage();
            this.miscList = new System.Windows.Forms.ListView();
            this.spawnpresets = new System.Windows.Forms.TabPage();
            this.administration = new System.Windows.Forms.TabPage();
            this.teleportToLocationBox = new System.Windows.Forms.GroupBox();
            this.teleportLocationsList = new System.Windows.Forms.ListView();
            this.teleportToLocationButton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.TabPage();
            this.steamId64 = new System.Windows.Forms.Label();
            this.steamIdTextBox = new System.Windows.Forms.TextBox();
            this.mainTabs.SuspendLayout();
            this.spawntable.SuspendLayout();
            this.itemsTab.SuspendLayout();
            this.rangedWeaponsTab.SuspendLayout();
            this.meleeWeaponsTab.SuspendLayout();
            this.weaponpartsTab.SuspendLayout();
            this.ammoTab.SuspendLayout();
            this.headgearTab.SuspendLayout();
            this.topsTab.SuspendLayout();
            this.pantsTab.SuspendLayout();
            this.shoesTab.SuspendLayout();
            this.backpacksTab.SuspendLayout();
            this.vestsTab.SuspendLayout();
            this.miscGearTab.SuspendLayout();
            this.toolsTab.SuspendLayout();
            this.craftingTab.SuspendLayout();
            this.foodTab.SuspendLayout();
            this.drinkTab.SuspendLayout();
            this.drugstoreTab.SuspendLayout();
            this.npcTab.SuspendLayout();
            this.npcpartsTab.SuspendLayout();
            this.envTab.SuspendLayout();
            this.miscTab.SuspendLayout();
            this.administration.SuspendLayout();
            this.teleportToLocationBox.SuspendLayout();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.mainTabs.Controls.Add(this.spawntable);
            this.mainTabs.Controls.Add(this.spawnpresets);
            this.mainTabs.Controls.Add(this.administration);
            this.mainTabs.Controls.Add(this.settings);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1134, 561);
            this.mainTabs.TabIndex = 0;
            // 
            // spawntable
            // 
            this.spawntable.Controls.Add(this.spawnButton);
            this.spawntable.Controls.Add(this.amount);
            this.spawntable.Controls.Add(this.itemsTab);
            this.spawntable.Location = new System.Drawing.Point(4, 4);
            this.spawntable.Name = "spawntable";
            this.spawntable.Padding = new System.Windows.Forms.Padding(3);
            this.spawntable.Size = new System.Drawing.Size(1126, 535);
            this.spawntable.TabIndex = 0;
            this.spawntable.Text = "Spawntable";
            this.spawntable.UseVisualStyleBackColor = true;
            // 
            // spawnButton
            // 
            this.spawnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spawnButton.Location = new System.Drawing.Point(55, 508);
            this.spawnButton.Name = "spawnButton";
            this.spawnButton.Size = new System.Drawing.Size(75, 22);
            this.spawnButton.TabIndex = 2;
            this.spawnButton.Text = "Spawn";
            this.spawnButton.UseVisualStyleBackColor = true;
            this.spawnButton.Click += new System.EventHandler(this.spawnButton_Click);
            // 
            // amount
            // 
            this.amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.amount.Location = new System.Drawing.Point(10, 509);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(39, 20);
            this.amount.TabIndex = 1;
            this.amount.Text = "1";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // itemsTab
            // 
            this.itemsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsTab.Controls.Add(this.rangedWeaponsTab);
            this.itemsTab.Controls.Add(this.meleeWeaponsTab);
            this.itemsTab.Controls.Add(this.weaponpartsTab);
            this.itemsTab.Controls.Add(this.ammoTab);
            this.itemsTab.Controls.Add(this.headgearTab);
            this.itemsTab.Controls.Add(this.topsTab);
            this.itemsTab.Controls.Add(this.pantsTab);
            this.itemsTab.Controls.Add(this.shoesTab);
            this.itemsTab.Controls.Add(this.backpacksTab);
            this.itemsTab.Controls.Add(this.vestsTab);
            this.itemsTab.Controls.Add(this.miscGearTab);
            this.itemsTab.Controls.Add(this.toolsTab);
            this.itemsTab.Controls.Add(this.craftingTab);
            this.itemsTab.Controls.Add(this.foodTab);
            this.itemsTab.Controls.Add(this.drinkTab);
            this.itemsTab.Controls.Add(this.drugstoreTab);
            this.itemsTab.Controls.Add(this.npcTab);
            this.itemsTab.Controls.Add(this.npcpartsTab);
            this.itemsTab.Controls.Add(this.envTab);
            this.itemsTab.Controls.Add(this.miscTab);
            this.itemsTab.Location = new System.Drawing.Point(6, 3);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.SelectedIndex = 0;
            this.itemsTab.Size = new System.Drawing.Size(1114, 500);
            this.itemsTab.TabIndex = 0;
            // 
            // rangedWeaponsTab
            // 
            this.rangedWeaponsTab.Controls.Add(this.rangedList);
            this.rangedWeaponsTab.Location = new System.Drawing.Point(4, 22);
            this.rangedWeaponsTab.Name = "rangedWeaponsTab";
            this.rangedWeaponsTab.Size = new System.Drawing.Size(1106, 474);
            this.rangedWeaponsTab.TabIndex = 0;
            this.rangedWeaponsTab.Text = "Ranged Weapons";
            this.rangedWeaponsTab.UseVisualStyleBackColor = true;
            // 
            // rangedList
            // 
            this.rangedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangedList.FullRowSelect = true;
            this.rangedList.GridLines = true;
            this.rangedList.Location = new System.Drawing.Point(0, 0);
            this.rangedList.MultiSelect = false;
            this.rangedList.Name = "rangedList";
            this.rangedList.Size = new System.Drawing.Size(1106, 474);
            this.rangedList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.rangedList.TabIndex = 2;
            this.rangedList.UseCompatibleStateImageBehavior = false;
            this.rangedList.View = System.Windows.Forms.View.Details;
            // 
            // meleeWeaponsTab
            // 
            this.meleeWeaponsTab.Controls.Add(this.meleeList);
            this.meleeWeaponsTab.Location = new System.Drawing.Point(4, 22);
            this.meleeWeaponsTab.Name = "meleeWeaponsTab";
            this.meleeWeaponsTab.Size = new System.Drawing.Size(1106, 474);
            this.meleeWeaponsTab.TabIndex = 1;
            this.meleeWeaponsTab.Text = "Melee Weapons";
            this.meleeWeaponsTab.UseVisualStyleBackColor = true;
            // 
            // meleeList
            // 
            this.meleeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meleeList.FullRowSelect = true;
            this.meleeList.GridLines = true;
            this.meleeList.Location = new System.Drawing.Point(0, 0);
            this.meleeList.MultiSelect = false;
            this.meleeList.Name = "meleeList";
            this.meleeList.Size = new System.Drawing.Size(1106, 474);
            this.meleeList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.meleeList.TabIndex = 1;
            this.meleeList.UseCompatibleStateImageBehavior = false;
            this.meleeList.View = System.Windows.Forms.View.Details;
            // 
            // weaponpartsTab
            // 
            this.weaponpartsTab.Controls.Add(this.weaponpartsList);
            this.weaponpartsTab.Location = new System.Drawing.Point(4, 22);
            this.weaponpartsTab.Name = "weaponpartsTab";
            this.weaponpartsTab.Size = new System.Drawing.Size(1106, 474);
            this.weaponpartsTab.TabIndex = 17;
            this.weaponpartsTab.Text = "Weaponparts";
            this.weaponpartsTab.UseVisualStyleBackColor = true;
            // 
            // weaponpartsList
            // 
            this.weaponpartsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weaponpartsList.FullRowSelect = true;
            this.weaponpartsList.GridLines = true;
            this.weaponpartsList.Location = new System.Drawing.Point(0, 0);
            this.weaponpartsList.MultiSelect = false;
            this.weaponpartsList.Name = "weaponpartsList";
            this.weaponpartsList.Size = new System.Drawing.Size(1106, 474);
            this.weaponpartsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.weaponpartsList.TabIndex = 1;
            this.weaponpartsList.UseCompatibleStateImageBehavior = false;
            this.weaponpartsList.View = System.Windows.Forms.View.Details;
            // 
            // ammoTab
            // 
            this.ammoTab.Controls.Add(this.ammoList);
            this.ammoTab.Location = new System.Drawing.Point(4, 22);
            this.ammoTab.Name = "ammoTab";
            this.ammoTab.Size = new System.Drawing.Size(1106, 474);
            this.ammoTab.TabIndex = 2;
            this.ammoTab.Text = "Ammo";
            this.ammoTab.UseVisualStyleBackColor = true;
            // 
            // ammoList
            // 
            this.ammoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ammoList.FullRowSelect = true;
            this.ammoList.GridLines = true;
            this.ammoList.Location = new System.Drawing.Point(0, 0);
            this.ammoList.MultiSelect = false;
            this.ammoList.Name = "ammoList";
            this.ammoList.Size = new System.Drawing.Size(1106, 474);
            this.ammoList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ammoList.TabIndex = 1;
            this.ammoList.UseCompatibleStateImageBehavior = false;
            this.ammoList.View = System.Windows.Forms.View.Details;
            // 
            // headgearTab
            // 
            this.headgearTab.Controls.Add(this.headgearList);
            this.headgearTab.Location = new System.Drawing.Point(4, 22);
            this.headgearTab.Name = "headgearTab";
            this.headgearTab.Size = new System.Drawing.Size(1106, 474);
            this.headgearTab.TabIndex = 3;
            this.headgearTab.Text = "Headgear";
            this.headgearTab.UseVisualStyleBackColor = true;
            // 
            // headgearList
            // 
            this.headgearList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headgearList.FullRowSelect = true;
            this.headgearList.GridLines = true;
            this.headgearList.Location = new System.Drawing.Point(0, 0);
            this.headgearList.MultiSelect = false;
            this.headgearList.Name = "headgearList";
            this.headgearList.Size = new System.Drawing.Size(1106, 474);
            this.headgearList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.headgearList.TabIndex = 1;
            this.headgearList.UseCompatibleStateImageBehavior = false;
            this.headgearList.View = System.Windows.Forms.View.Details;
            // 
            // topsTab
            // 
            this.topsTab.Controls.Add(this.topsList);
            this.topsTab.Location = new System.Drawing.Point(4, 22);
            this.topsTab.Name = "topsTab";
            this.topsTab.Size = new System.Drawing.Size(1106, 474);
            this.topsTab.TabIndex = 4;
            this.topsTab.Text = "Tops";
            this.topsTab.UseVisualStyleBackColor = true;
            // 
            // topsList
            // 
            this.topsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topsList.FullRowSelect = true;
            this.topsList.GridLines = true;
            this.topsList.Location = new System.Drawing.Point(0, 0);
            this.topsList.MultiSelect = false;
            this.topsList.Name = "topsList";
            this.topsList.Size = new System.Drawing.Size(1106, 474);
            this.topsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.topsList.TabIndex = 1;
            this.topsList.UseCompatibleStateImageBehavior = false;
            this.topsList.View = System.Windows.Forms.View.Details;
            // 
            // pantsTab
            // 
            this.pantsTab.Controls.Add(this.pantsList);
            this.pantsTab.Location = new System.Drawing.Point(4, 22);
            this.pantsTab.Name = "pantsTab";
            this.pantsTab.Size = new System.Drawing.Size(1106, 474);
            this.pantsTab.TabIndex = 5;
            this.pantsTab.Text = "Pants";
            this.pantsTab.UseVisualStyleBackColor = true;
            // 
            // pantsList
            // 
            this.pantsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantsList.FullRowSelect = true;
            this.pantsList.GridLines = true;
            this.pantsList.Location = new System.Drawing.Point(0, 0);
            this.pantsList.MultiSelect = false;
            this.pantsList.Name = "pantsList";
            this.pantsList.Size = new System.Drawing.Size(1106, 474);
            this.pantsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.pantsList.TabIndex = 1;
            this.pantsList.UseCompatibleStateImageBehavior = false;
            this.pantsList.View = System.Windows.Forms.View.Details;
            // 
            // shoesTab
            // 
            this.shoesTab.Controls.Add(this.shoesList);
            this.shoesTab.Location = new System.Drawing.Point(4, 22);
            this.shoesTab.Name = "shoesTab";
            this.shoesTab.Size = new System.Drawing.Size(1106, 474);
            this.shoesTab.TabIndex = 6;
            this.shoesTab.Text = "Shoes";
            this.shoesTab.UseVisualStyleBackColor = true;
            // 
            // shoesList
            // 
            this.shoesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shoesList.FullRowSelect = true;
            this.shoesList.GridLines = true;
            this.shoesList.Location = new System.Drawing.Point(0, 0);
            this.shoesList.MultiSelect = false;
            this.shoesList.Name = "shoesList";
            this.shoesList.Size = new System.Drawing.Size(1106, 474);
            this.shoesList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.shoesList.TabIndex = 1;
            this.shoesList.UseCompatibleStateImageBehavior = false;
            this.shoesList.View = System.Windows.Forms.View.Details;
            // 
            // backpacksTab
            // 
            this.backpacksTab.Controls.Add(this.backpacksList);
            this.backpacksTab.Location = new System.Drawing.Point(4, 22);
            this.backpacksTab.Name = "backpacksTab";
            this.backpacksTab.Size = new System.Drawing.Size(1106, 474);
            this.backpacksTab.TabIndex = 7;
            this.backpacksTab.Text = "Backpacks";
            this.backpacksTab.UseVisualStyleBackColor = true;
            // 
            // backpacksList
            // 
            this.backpacksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backpacksList.FullRowSelect = true;
            this.backpacksList.GridLines = true;
            this.backpacksList.Location = new System.Drawing.Point(0, 0);
            this.backpacksList.MultiSelect = false;
            this.backpacksList.Name = "backpacksList";
            this.backpacksList.Size = new System.Drawing.Size(1106, 474);
            this.backpacksList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.backpacksList.TabIndex = 1;
            this.backpacksList.UseCompatibleStateImageBehavior = false;
            this.backpacksList.View = System.Windows.Forms.View.Details;
            // 
            // vestsTab
            // 
            this.vestsTab.Controls.Add(this.vestsList);
            this.vestsTab.Location = new System.Drawing.Point(4, 22);
            this.vestsTab.Name = "vestsTab";
            this.vestsTab.Size = new System.Drawing.Size(1106, 474);
            this.vestsTab.TabIndex = 8;
            this.vestsTab.Text = "Vests";
            this.vestsTab.UseVisualStyleBackColor = true;
            // 
            // vestsList
            // 
            this.vestsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vestsList.FullRowSelect = true;
            this.vestsList.GridLines = true;
            this.vestsList.Location = new System.Drawing.Point(0, 0);
            this.vestsList.MultiSelect = false;
            this.vestsList.Name = "vestsList";
            this.vestsList.Size = new System.Drawing.Size(1106, 474);
            this.vestsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.vestsList.TabIndex = 1;
            this.vestsList.UseCompatibleStateImageBehavior = false;
            this.vestsList.View = System.Windows.Forms.View.Details;
            // 
            // miscGearTab
            // 
            this.miscGearTab.Controls.Add(this.miscGearList);
            this.miscGearTab.Location = new System.Drawing.Point(4, 22);
            this.miscGearTab.Name = "miscGearTab";
            this.miscGearTab.Size = new System.Drawing.Size(1106, 474);
            this.miscGearTab.TabIndex = 19;
            this.miscGearTab.Text = "Misc Gear";
            this.miscGearTab.UseVisualStyleBackColor = true;
            // 
            // miscGearList
            // 
            this.miscGearList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miscGearList.FullRowSelect = true;
            this.miscGearList.GridLines = true;
            this.miscGearList.Location = new System.Drawing.Point(0, 0);
            this.miscGearList.MultiSelect = false;
            this.miscGearList.Name = "miscGearList";
            this.miscGearList.Size = new System.Drawing.Size(1106, 474);
            this.miscGearList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.miscGearList.TabIndex = 2;
            this.miscGearList.UseCompatibleStateImageBehavior = false;
            this.miscGearList.View = System.Windows.Forms.View.Details;
            // 
            // toolsTab
            // 
            this.toolsTab.Controls.Add(this.toolsList);
            this.toolsTab.Location = new System.Drawing.Point(4, 22);
            this.toolsTab.Name = "toolsTab";
            this.toolsTab.Size = new System.Drawing.Size(1106, 474);
            this.toolsTab.TabIndex = 9;
            this.toolsTab.Text = "Tools";
            this.toolsTab.UseVisualStyleBackColor = true;
            // 
            // toolsList
            // 
            this.toolsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsList.FullRowSelect = true;
            this.toolsList.GridLines = true;
            this.toolsList.Location = new System.Drawing.Point(0, 0);
            this.toolsList.MultiSelect = false;
            this.toolsList.Name = "toolsList";
            this.toolsList.Size = new System.Drawing.Size(1106, 474);
            this.toolsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.toolsList.TabIndex = 1;
            this.toolsList.UseCompatibleStateImageBehavior = false;
            this.toolsList.View = System.Windows.Forms.View.Details;
            // 
            // craftingTab
            // 
            this.craftingTab.Controls.Add(this.craftingList);
            this.craftingTab.Location = new System.Drawing.Point(4, 22);
            this.craftingTab.Name = "craftingTab";
            this.craftingTab.Size = new System.Drawing.Size(1106, 474);
            this.craftingTab.TabIndex = 10;
            this.craftingTab.Text = "Crafting";
            this.craftingTab.UseVisualStyleBackColor = true;
            // 
            // craftingList
            // 
            this.craftingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.craftingList.FullRowSelect = true;
            this.craftingList.GridLines = true;
            this.craftingList.Location = new System.Drawing.Point(0, 0);
            this.craftingList.MultiSelect = false;
            this.craftingList.Name = "craftingList";
            this.craftingList.Size = new System.Drawing.Size(1106, 474);
            this.craftingList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.craftingList.TabIndex = 1;
            this.craftingList.UseCompatibleStateImageBehavior = false;
            this.craftingList.View = System.Windows.Forms.View.Details;
            // 
            // foodTab
            // 
            this.foodTab.Controls.Add(this.foodList);
            this.foodTab.Location = new System.Drawing.Point(4, 22);
            this.foodTab.Name = "foodTab";
            this.foodTab.Size = new System.Drawing.Size(1106, 474);
            this.foodTab.TabIndex = 11;
            this.foodTab.Text = "Food";
            this.foodTab.UseVisualStyleBackColor = true;
            // 
            // foodList
            // 
            this.foodList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodList.FullRowSelect = true;
            this.foodList.GridLines = true;
            this.foodList.Location = new System.Drawing.Point(0, 0);
            this.foodList.MultiSelect = false;
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(1106, 474);
            this.foodList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.foodList.TabIndex = 1;
            this.foodList.UseCompatibleStateImageBehavior = false;
            this.foodList.View = System.Windows.Forms.View.Details;
            // 
            // drinkTab
            // 
            this.drinkTab.Controls.Add(this.drinksList);
            this.drinkTab.Location = new System.Drawing.Point(4, 22);
            this.drinkTab.Name = "drinkTab";
            this.drinkTab.Size = new System.Drawing.Size(1106, 474);
            this.drinkTab.TabIndex = 12;
            this.drinkTab.Text = "Drinks";
            this.drinkTab.UseVisualStyleBackColor = true;
            // 
            // drinksList
            // 
            this.drinksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinksList.FullRowSelect = true;
            this.drinksList.GridLines = true;
            this.drinksList.Location = new System.Drawing.Point(0, 0);
            this.drinksList.MultiSelect = false;
            this.drinksList.Name = "drinksList";
            this.drinksList.Size = new System.Drawing.Size(1106, 474);
            this.drinksList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.drinksList.TabIndex = 1;
            this.drinksList.UseCompatibleStateImageBehavior = false;
            this.drinksList.View = System.Windows.Forms.View.Details;
            // 
            // drugstoreTab
            // 
            this.drugstoreTab.Controls.Add(this.drugstoreList);
            this.drugstoreTab.Location = new System.Drawing.Point(4, 22);
            this.drugstoreTab.Name = "drugstoreTab";
            this.drugstoreTab.Size = new System.Drawing.Size(1106, 474);
            this.drugstoreTab.TabIndex = 13;
            this.drugstoreTab.Text = "Drugstore";
            this.drugstoreTab.UseVisualStyleBackColor = true;
            // 
            // drugstoreList
            // 
            this.drugstoreList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drugstoreList.FullRowSelect = true;
            this.drugstoreList.GridLines = true;
            this.drugstoreList.Location = new System.Drawing.Point(0, 0);
            this.drugstoreList.MultiSelect = false;
            this.drugstoreList.Name = "drugstoreList";
            this.drugstoreList.Size = new System.Drawing.Size(1106, 474);
            this.drugstoreList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.drugstoreList.TabIndex = 1;
            this.drugstoreList.UseCompatibleStateImageBehavior = false;
            this.drugstoreList.View = System.Windows.Forms.View.Details;
            // 
            // npcTab
            // 
            this.npcTab.Controls.Add(this.npcList);
            this.npcTab.Location = new System.Drawing.Point(4, 22);
            this.npcTab.Name = "npcTab";
            this.npcTab.Size = new System.Drawing.Size(1106, 474);
            this.npcTab.TabIndex = 18;
            this.npcTab.Text = "NPC";
            this.npcTab.UseVisualStyleBackColor = true;
            // 
            // npcList
            // 
            this.npcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npcList.FullRowSelect = true;
            this.npcList.GridLines = true;
            this.npcList.Location = new System.Drawing.Point(0, 0);
            this.npcList.MultiSelect = false;
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(1106, 474);
            this.npcList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.npcList.TabIndex = 2;
            this.npcList.UseCompatibleStateImageBehavior = false;
            this.npcList.View = System.Windows.Forms.View.Details;
            // 
            // npcpartsTab
            // 
            this.npcpartsTab.Controls.Add(this.npcPartsList);
            this.npcpartsTab.Location = new System.Drawing.Point(4, 22);
            this.npcpartsTab.Name = "npcpartsTab";
            this.npcpartsTab.Size = new System.Drawing.Size(1106, 474);
            this.npcpartsTab.TabIndex = 16;
            this.npcpartsTab.Text = "NPC Parts";
            this.npcpartsTab.UseVisualStyleBackColor = true;
            // 
            // npcPartsList
            // 
            this.npcPartsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npcPartsList.FullRowSelect = true;
            this.npcPartsList.GridLines = true;
            this.npcPartsList.Location = new System.Drawing.Point(0, 0);
            this.npcPartsList.MultiSelect = false;
            this.npcPartsList.Name = "npcPartsList";
            this.npcPartsList.Size = new System.Drawing.Size(1106, 474);
            this.npcPartsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.npcPartsList.TabIndex = 1;
            this.npcPartsList.UseCompatibleStateImageBehavior = false;
            this.npcPartsList.View = System.Windows.Forms.View.Details;
            // 
            // envTab
            // 
            this.envTab.Controls.Add(this.envList);
            this.envTab.Location = new System.Drawing.Point(4, 22);
            this.envTab.Name = "envTab";
            this.envTab.Size = new System.Drawing.Size(1106, 474);
            this.envTab.TabIndex = 15;
            this.envTab.Text = "Environment";
            this.envTab.UseVisualStyleBackColor = true;
            // 
            // envList
            // 
            this.envList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.envList.FullRowSelect = true;
            this.envList.GridLines = true;
            this.envList.Location = new System.Drawing.Point(0, 0);
            this.envList.MultiSelect = false;
            this.envList.Name = "envList";
            this.envList.Size = new System.Drawing.Size(1106, 474);
            this.envList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.envList.TabIndex = 1;
            this.envList.UseCompatibleStateImageBehavior = false;
            this.envList.View = System.Windows.Forms.View.Details;
            // 
            // miscTab
            // 
            this.miscTab.Controls.Add(this.miscList);
            this.miscTab.Location = new System.Drawing.Point(4, 22);
            this.miscTab.Name = "miscTab";
            this.miscTab.Size = new System.Drawing.Size(1106, 474);
            this.miscTab.TabIndex = 14;
            this.miscTab.Text = "Misc";
            this.miscTab.UseVisualStyleBackColor = true;
            // 
            // miscList
            // 
            this.miscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miscList.FullRowSelect = true;
            this.miscList.GridLines = true;
            this.miscList.Location = new System.Drawing.Point(0, 0);
            this.miscList.MultiSelect = false;
            this.miscList.Name = "miscList";
            this.miscList.Size = new System.Drawing.Size(1106, 474);
            this.miscList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.miscList.TabIndex = 1;
            this.miscList.UseCompatibleStateImageBehavior = false;
            this.miscList.View = System.Windows.Forms.View.Details;
            // 
            // spawnpresets
            // 
            this.spawnpresets.Location = new System.Drawing.Point(4, 4);
            this.spawnpresets.Name = "spawnpresets";
            this.spawnpresets.Size = new System.Drawing.Size(1126, 535);
            this.spawnpresets.TabIndex = 3;
            this.spawnpresets.Text = "Spawntable Presets";
            this.spawnpresets.UseVisualStyleBackColor = true;
            // 
            // administration
            // 
            this.administration.Controls.Add(this.teleportToLocationBox);
            this.administration.Location = new System.Drawing.Point(4, 4);
            this.administration.Name = "administration";
            this.administration.Padding = new System.Windows.Forms.Padding(3);
            this.administration.Size = new System.Drawing.Size(1126, 535);
            this.administration.TabIndex = 1;
            this.administration.Text = "Administration";
            this.administration.UseVisualStyleBackColor = true;
            // 
            // teleportToLocationBox
            // 
            this.teleportToLocationBox.Controls.Add(this.teleportLocationsList);
            this.teleportToLocationBox.Controls.Add(this.teleportToLocationButton);
            this.teleportToLocationBox.Location = new System.Drawing.Point(9, 9);
            this.teleportToLocationBox.Name = "teleportToLocationBox";
            this.teleportToLocationBox.Size = new System.Drawing.Size(502, 296);
            this.teleportToLocationBox.TabIndex = 0;
            this.teleportToLocationBox.TabStop = false;
            this.teleportToLocationBox.Text = "Teleport to Location";
            // 
            // teleportLocationsList
            // 
            this.teleportLocationsList.FullRowSelect = true;
            this.teleportLocationsList.GridLines = true;
            this.teleportLocationsList.Location = new System.Drawing.Point(7, 20);
            this.teleportLocationsList.MultiSelect = false;
            this.teleportLocationsList.Name = "teleportLocationsList";
            this.teleportLocationsList.Size = new System.Drawing.Size(489, 239);
            this.teleportLocationsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.teleportLocationsList.TabIndex = 2;
            this.teleportLocationsList.UseCompatibleStateImageBehavior = false;
            this.teleportLocationsList.View = System.Windows.Forms.View.Details;
            // 
            // teleportToLocationButton
            // 
            this.teleportToLocationButton.Location = new System.Drawing.Point(7, 265);
            this.teleportToLocationButton.Name = "teleportToLocationButton";
            this.teleportToLocationButton.Size = new System.Drawing.Size(75, 23);
            this.teleportToLocationButton.TabIndex = 1;
            this.teleportToLocationButton.Text = "Teleport";
            this.teleportToLocationButton.UseVisualStyleBackColor = true;
            this.teleportToLocationButton.Click += new System.EventHandler(this.teleportToLocationButton_Click);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.steamId64);
            this.settings.Controls.Add(this.steamIdTextBox);
            this.settings.Location = new System.Drawing.Point(4, 4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1126, 535);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // steamId64
            // 
            this.steamId64.AutoSize = true;
            this.steamId64.Location = new System.Drawing.Point(9, 11);
            this.steamId64.Name = "steamId64";
            this.steamId64.Size = new System.Drawing.Size(75, 13);
            this.steamId64.TabIndex = 1;
            this.steamId64.Text = "Steamd ID 64:";
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.Location = new System.Drawing.Point(90, 8);
            this.steamIdTextBox.Name = "steamIdTextBox";
            this.steamIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.steamIdTextBox.TabIndex = 0;
            this.steamIdTextBox.TextChanged += new System.EventHandler(this.steamIdTextBox_TextChanged);
            this.steamIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.steamIdTextBoxt_KeyPress);
            // 
            // scumAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.mainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "scumAdmin";
            this.Text = "SCUM Admin";
            this.mainTabs.ResumeLayout(false);
            this.spawntable.ResumeLayout(false);
            this.spawntable.PerformLayout();
            this.itemsTab.ResumeLayout(false);
            this.rangedWeaponsTab.ResumeLayout(false);
            this.meleeWeaponsTab.ResumeLayout(false);
            this.weaponpartsTab.ResumeLayout(false);
            this.ammoTab.ResumeLayout(false);
            this.headgearTab.ResumeLayout(false);
            this.topsTab.ResumeLayout(false);
            this.pantsTab.ResumeLayout(false);
            this.shoesTab.ResumeLayout(false);
            this.backpacksTab.ResumeLayout(false);
            this.vestsTab.ResumeLayout(false);
            this.miscGearTab.ResumeLayout(false);
            this.toolsTab.ResumeLayout(false);
            this.craftingTab.ResumeLayout(false);
            this.foodTab.ResumeLayout(false);
            this.drinkTab.ResumeLayout(false);
            this.drugstoreTab.ResumeLayout(false);
            this.npcTab.ResumeLayout(false);
            this.npcpartsTab.ResumeLayout(false);
            this.envTab.ResumeLayout(false);
            this.miscTab.ResumeLayout(false);
            this.administration.ResumeLayout(false);
            this.teleportToLocationBox.ResumeLayout(false);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage spawntable;
        private System.Windows.Forms.TabControl itemsTab;
        private System.Windows.Forms.TabPage rangedWeaponsTab;
        private System.Windows.Forms.TabPage meleeWeaponsTab;
        private System.Windows.Forms.TabPage administration;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.Button spawnButton;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TabPage ammoTab;
        private System.Windows.Forms.TabPage headgearTab;
        private System.Windows.Forms.TabPage topsTab;
        private System.Windows.Forms.TabPage pantsTab;
        private System.Windows.Forms.TabPage shoesTab;
        private System.Windows.Forms.TabPage backpacksTab;
        private System.Windows.Forms.TabPage vestsTab;
        private System.Windows.Forms.TabPage toolsTab;
        private System.Windows.Forms.TabPage craftingTab;
        private System.Windows.Forms.TabPage foodTab;
        private System.Windows.Forms.TabPage drinkTab;
        private System.Windows.Forms.TabPage drugstoreTab;
        private System.Windows.Forms.TabPage npcpartsTab;
        private System.Windows.Forms.TabPage envTab;
        private System.Windows.Forms.TabPage miscTab;
        private System.Windows.Forms.ListView meleeList;
        private System.Windows.Forms.ListView ammoList;
        private System.Windows.Forms.ListView headgearList;
        private System.Windows.Forms.ListView topsList;
        private System.Windows.Forms.ListView pantsList;
        private System.Windows.Forms.ListView shoesList;
        private System.Windows.Forms.ListView backpacksList;
        private System.Windows.Forms.ListView vestsList;
        private System.Windows.Forms.ListView toolsList;
        private System.Windows.Forms.ListView craftingList;
        private System.Windows.Forms.ListView foodList;
        private System.Windows.Forms.ListView drinksList;
        private System.Windows.Forms.ListView drugstoreList;
        private System.Windows.Forms.ListView npcPartsList;
        private System.Windows.Forms.ListView envList;
        private System.Windows.Forms.ListView miscList;
        private System.Windows.Forms.TabPage weaponpartsTab;
        private System.Windows.Forms.ListView weaponpartsList;
        private System.Windows.Forms.TabPage npcTab;
        private System.Windows.Forms.ListView npcList;
        private System.Windows.Forms.TabPage miscGearTab;
        private System.Windows.Forms.ListView miscGearList;
        private System.Windows.Forms.ListView rangedList;
        private System.Windows.Forms.TabPage spawnpresets;
        private System.Windows.Forms.GroupBox teleportToLocationBox;
        private System.Windows.Forms.ListView teleportLocationsList;
        private System.Windows.Forms.Button teleportToLocationButton;
        private System.Windows.Forms.Label steamId64;
        private System.Windows.Forms.TextBox steamIdTextBox;
    }
}

