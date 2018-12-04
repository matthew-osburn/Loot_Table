namespace Loot_Table
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Generate_Treasure_Budget = new System.Windows.Forms.Button();
            this.CreatureType = new System.Windows.Forms.ComboBox();
            this.RewardType = new System.Windows.Forms.ComboBox();
            this.ChallengeRating = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TreasureBudget = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TreasureTypes = new System.Windows.Forms.TextBox();
            this.RemaingBudget = new System.Windows.Forms.NumericUpDown();
            this.BudgetAllocation = new System.Windows.Forms.GroupBox();
            this.RollLoot = new System.Windows.Forms.Button();
            this.ResetBudget = new System.Windows.Forms.Button();
            this.AddI = new System.Windows.Forms.Button();
            this.AddH = new System.Windows.Forms.Button();
            this.AddG = new System.Windows.Forms.Button();
            this.AddF = new System.Windows.Forms.Button();
            this.AddE = new System.Windows.Forms.Button();
            this.AddD = new System.Windows.Forms.Button();
            this.AddC = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.AddA = new System.Windows.Forms.Button();
            this.RollList = new System.Windows.Forms.ListBox();
            this.TableI = new System.Windows.Forms.ComboBox();
            this.TableH = new System.Windows.Forms.ComboBox();
            this.TableG = new System.Windows.Forms.ComboBox();
            this.TableF = new System.Windows.Forms.ComboBox();
            this.TableE = new System.Windows.Forms.ComboBox();
            this.TableD = new System.Windows.Forms.ComboBox();
            this.TableC = new System.Windows.Forms.ComboBox();
            this.TableB = new System.Windows.Forms.ComboBox();
            this.TableA = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.Loot = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChallengeRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemaingBudget)).BeginInit();
            this.BudgetAllocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generate_Treasure_Budget
            // 
            this.Generate_Treasure_Budget.Location = new System.Drawing.Point(96, 204);
            this.Generate_Treasure_Budget.Margin = new System.Windows.Forms.Padding(4);
            this.Generate_Treasure_Budget.Name = "Generate_Treasure_Budget";
            this.Generate_Treasure_Budget.Size = new System.Drawing.Size(201, 39);
            this.Generate_Treasure_Budget.TabIndex = 1;
            this.Generate_Treasure_Budget.Text = "Generate Treasure Budget";
            this.Generate_Treasure_Budget.UseVisualStyleBackColor = true;
            this.Generate_Treasure_Budget.Click += new System.EventHandler(this.Generate_Treasure_Budget_Click);
            // 
            // CreatureType
            // 
            this.CreatureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreatureType.FormattingEnabled = true;
            this.CreatureType.Items.AddRange(new object[] {
            "Aberration",
            "Animal",
            "Construct",
            "Dragon",
            "Fey",
            "Humanoid",
            "Magical Beast",
            "Monstrous Humanoid",
            "Ooze",
            "Outsider",
            "Plant",
            "Undead",
            "Vermin"});
            this.CreatureType.Location = new System.Drawing.Point(159, 160);
            this.CreatureType.Margin = new System.Windows.Forms.Padding(4);
            this.CreatureType.Name = "CreatureType";
            this.CreatureType.Size = new System.Drawing.Size(160, 24);
            this.CreatureType.TabIndex = 2;
            // 
            // RewardType
            // 
            this.RewardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RewardType.FormattingEnabled = true;
            this.RewardType.Items.AddRange(new object[] {
            "None",
            "Incidental",
            "Standard",
            "Double",
            "Triple",
            "NPC Gear"});
            this.RewardType.Location = new System.Drawing.Point(159, 114);
            this.RewardType.Margin = new System.Windows.Forms.Padding(4);
            this.RewardType.Name = "RewardType";
            this.RewardType.Size = new System.Drawing.Size(160, 24);
            this.RewardType.TabIndex = 3;
            // 
            // ChallengeRating
            // 
            this.ChallengeRating.Location = new System.Drawing.Point(160, 37);
            this.ChallengeRating.Margin = new System.Windows.Forms.Padding(4);
            this.ChallengeRating.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ChallengeRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChallengeRating.Name = "ChallengeRating";
            this.ChallengeRating.Size = new System.Drawing.Size(68, 22);
            this.ChallengeRating.TabIndex = 4;
            this.ChallengeRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChallengeRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Challenge Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reward Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Creature Type";
            // 
            // TreasureBudget
            // 
            this.TreasureBudget.Location = new System.Drawing.Point(159, 251);
            this.TreasureBudget.Margin = new System.Windows.Forms.Padding(4);
            this.TreasureBudget.Name = "TreasureBudget";
            this.TreasureBudget.Size = new System.Drawing.Size(119, 22);
            this.TreasureBudget.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Treasure Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "GP";
            // 
            // Speed
            // 
            this.Speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Speed.FormattingEnabled = true;
            this.Speed.Items.AddRange(new object[] {
            "Slow",
            "Medium",
            "Fast"});
            this.Speed.Location = new System.Drawing.Point(159, 81);
            this.Speed.Margin = new System.Windows.Forms.Padding(4);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(160, 24);
            this.Speed.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Treasure Types";
            // 
            // TreasureTypes
            // 
            this.TreasureTypes.Location = new System.Drawing.Point(160, 289);
            this.TreasureTypes.Margin = new System.Windows.Forms.Padding(4);
            this.TreasureTypes.Multiline = true;
            this.TreasureTypes.Name = "TreasureTypes";
            this.TreasureTypes.Size = new System.Drawing.Size(155, 84);
            this.TreasureTypes.TabIndex = 13;
            // 
            // RemaingBudget
            // 
            this.RemaingBudget.Location = new System.Drawing.Point(153, 57);
            this.RemaingBudget.Margin = new System.Windows.Forms.Padding(4);
            this.RemaingBudget.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.RemaingBudget.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.RemaingBudget.Name = "RemaingBudget";
            this.RemaingBudget.ReadOnly = true;
            this.RemaingBudget.Size = new System.Drawing.Size(160, 22);
            this.RemaingBudget.TabIndex = 15;
            this.RemaingBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BudgetAllocation
            // 
            this.BudgetAllocation.Controls.Add(this.RollLoot);
            this.BudgetAllocation.Controls.Add(this.ResetBudget);
            this.BudgetAllocation.Controls.Add(this.AddI);
            this.BudgetAllocation.Controls.Add(this.AddH);
            this.BudgetAllocation.Controls.Add(this.AddG);
            this.BudgetAllocation.Controls.Add(this.AddF);
            this.BudgetAllocation.Controls.Add(this.AddE);
            this.BudgetAllocation.Controls.Add(this.AddD);
            this.BudgetAllocation.Controls.Add(this.AddC);
            this.BudgetAllocation.Controls.Add(this.AddB);
            this.BudgetAllocation.Controls.Add(this.AddA);
            this.BudgetAllocation.Controls.Add(this.RollList);
            this.BudgetAllocation.Controls.Add(this.TableI);
            this.BudgetAllocation.Controls.Add(this.TableH);
            this.BudgetAllocation.Controls.Add(this.TableG);
            this.BudgetAllocation.Controls.Add(this.TableF);
            this.BudgetAllocation.Controls.Add(this.TableE);
            this.BudgetAllocation.Controls.Add(this.TableD);
            this.BudgetAllocation.Controls.Add(this.TableC);
            this.BudgetAllocation.Controls.Add(this.TableB);
            this.BudgetAllocation.Controls.Add(this.TableA);
            this.BudgetAllocation.Controls.Add(this.label18);
            this.BudgetAllocation.Controls.Add(this.label17);
            this.BudgetAllocation.Controls.Add(this.label16);
            this.BudgetAllocation.Controls.Add(this.label15);
            this.BudgetAllocation.Controls.Add(this.label14);
            this.BudgetAllocation.Controls.Add(this.label13);
            this.BudgetAllocation.Controls.Add(this.label12);
            this.BudgetAllocation.Controls.Add(this.label11);
            this.BudgetAllocation.Controls.Add(this.label10);
            this.BudgetAllocation.Controls.Add(this.label9);
            this.BudgetAllocation.Controls.Add(this.label8);
            this.BudgetAllocation.Controls.Add(this.RemaingBudget);
            this.BudgetAllocation.Location = new System.Drawing.Point(449, 16);
            this.BudgetAllocation.Margin = new System.Windows.Forms.Padding(4);
            this.BudgetAllocation.Name = "BudgetAllocation";
            this.BudgetAllocation.Padding = new System.Windows.Forms.Padding(4);
            this.BudgetAllocation.Size = new System.Drawing.Size(621, 546);
            this.BudgetAllocation.TabIndex = 16;
            this.BudgetAllocation.TabStop = false;
            this.BudgetAllocation.Text = "Budget Allocation";
            // 
            // RollLoot
            // 
            this.RollLoot.Location = new System.Drawing.Point(261, 511);
            this.RollLoot.Margin = new System.Windows.Forms.Padding(4);
            this.RollLoot.Name = "RollLoot";
            this.RollLoot.Size = new System.Drawing.Size(100, 28);
            this.RollLoot.TabIndex = 45;
            this.RollLoot.Text = "Roll Loot";
            this.RollLoot.UseVisualStyleBackColor = true;
            this.RollLoot.Click += new System.EventHandler(this.RollLoot_Click);
            // 
            // ResetBudget
            // 
            this.ResetBudget.Location = new System.Drawing.Point(441, 30);
            this.ResetBudget.Margin = new System.Windows.Forms.Padding(4);
            this.ResetBudget.Name = "ResetBudget";
            this.ResetBudget.Size = new System.Drawing.Size(123, 46);
            this.ResetBudget.TabIndex = 44;
            this.ResetBudget.Text = "Reset";
            this.ResetBudget.UseVisualStyleBackColor = true;
            this.ResetBudget.Click += new System.EventHandler(this.ResetBudget_Click);
            // 
            // AddI
            // 
            this.AddI.Location = new System.Drawing.Point(453, 370);
            this.AddI.Margin = new System.Windows.Forms.Padding(4);
            this.AddI.Name = "AddI";
            this.AddI.Size = new System.Drawing.Size(100, 28);
            this.AddI.TabIndex = 43;
            this.AddI.Text = "Add I";
            this.AddI.UseVisualStyleBackColor = true;
            this.AddI.Click += new System.EventHandler(this.AddI_Click);
            // 
            // AddH
            // 
            this.AddH.Location = new System.Drawing.Point(453, 336);
            this.AddH.Margin = new System.Windows.Forms.Padding(4);
            this.AddH.Name = "AddH";
            this.AddH.Size = new System.Drawing.Size(100, 28);
            this.AddH.TabIndex = 42;
            this.AddH.Text = "Add H";
            this.AddH.UseVisualStyleBackColor = true;
            this.AddH.Click += new System.EventHandler(this.AddH_Click);
            // 
            // AddG
            // 
            this.AddG.Location = new System.Drawing.Point(453, 305);
            this.AddG.Margin = new System.Windows.Forms.Padding(4);
            this.AddG.Name = "AddG";
            this.AddG.Size = new System.Drawing.Size(100, 28);
            this.AddG.TabIndex = 41;
            this.AddG.Text = "Add G";
            this.AddG.UseVisualStyleBackColor = true;
            this.AddG.Click += new System.EventHandler(this.AddG_Click);
            // 
            // AddF
            // 
            this.AddF.Location = new System.Drawing.Point(453, 273);
            this.AddF.Margin = new System.Windows.Forms.Padding(4);
            this.AddF.Name = "AddF";
            this.AddF.Size = new System.Drawing.Size(100, 28);
            this.AddF.TabIndex = 40;
            this.AddF.Text = "Add F";
            this.AddF.UseVisualStyleBackColor = true;
            this.AddF.Click += new System.EventHandler(this.AddF_Click);
            // 
            // AddE
            // 
            this.AddE.Location = new System.Drawing.Point(453, 239);
            this.AddE.Margin = new System.Windows.Forms.Padding(4);
            this.AddE.Name = "AddE";
            this.AddE.Size = new System.Drawing.Size(100, 28);
            this.AddE.TabIndex = 39;
            this.AddE.Text = "Add E";
            this.AddE.UseVisualStyleBackColor = true;
            this.AddE.Click += new System.EventHandler(this.AddE_Click);
            // 
            // AddD
            // 
            this.AddD.Location = new System.Drawing.Point(453, 203);
            this.AddD.Margin = new System.Windows.Forms.Padding(4);
            this.AddD.Name = "AddD";
            this.AddD.Size = new System.Drawing.Size(100, 28);
            this.AddD.TabIndex = 38;
            this.AddD.Text = "Add D";
            this.AddD.UseVisualStyleBackColor = true;
            this.AddD.Click += new System.EventHandler(this.AddD_Click);
            // 
            // AddC
            // 
            this.AddC.Location = new System.Drawing.Point(453, 166);
            this.AddC.Margin = new System.Windows.Forms.Padding(4);
            this.AddC.Name = "AddC";
            this.AddC.Size = new System.Drawing.Size(100, 28);
            this.AddC.TabIndex = 37;
            this.AddC.Text = "Add C";
            this.AddC.UseVisualStyleBackColor = true;
            this.AddC.Click += new System.EventHandler(this.AddC_Click);
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(453, 130);
            this.AddB.Margin = new System.Windows.Forms.Padding(4);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(100, 28);
            this.AddB.TabIndex = 36;
            this.AddB.Text = "Add B";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // AddA
            // 
            this.AddA.Location = new System.Drawing.Point(453, 98);
            this.AddA.Margin = new System.Windows.Forms.Padding(4);
            this.AddA.Name = "AddA";
            this.AddA.Size = new System.Drawing.Size(100, 28);
            this.AddA.TabIndex = 35;
            this.AddA.Text = "Add A";
            this.AddA.UseVisualStyleBackColor = true;
            this.AddA.Click += new System.EventHandler(this.AddA_Click);
            // 
            // RollList
            // 
            this.RollList.FormattingEnabled = true;
            this.RollList.HorizontalScrollbar = true;
            this.RollList.ItemHeight = 16;
            this.RollList.Location = new System.Drawing.Point(35, 406);
            this.RollList.Margin = new System.Windows.Forms.Padding(4);
            this.RollList.Name = "RollList";
            this.RollList.Size = new System.Drawing.Size(577, 100);
            this.RollList.TabIndex = 18;
            // 
            // TableI
            // 
            this.TableI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableI.FormattingEnabled = true;
            this.TableI.Items.AddRange(new object[] {
            "0",
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "40000",
            "50000",
            "60000",
            "75000",
            "100000",
            "125000",
            "150000",
            "200000",
            "300000"});
            this.TableI.Location = new System.Drawing.Point(263, 373);
            this.TableI.Margin = new System.Windows.Forms.Padding(4);
            this.TableI.Name = "TableI";
            this.TableI.Size = new System.Drawing.Size(160, 24);
            this.TableI.TabIndex = 34;
            // 
            // TableH
            // 
            this.TableH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableH.FormattingEnabled = true;
            this.TableH.Items.AddRange(new object[] {
            "0",
            "500",
            "1000",
            "2500",
            "5000",
            "7500",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "40000",
            "50000",
            "75000",
            "100000"});
            this.TableH.Location = new System.Drawing.Point(263, 338);
            this.TableH.Margin = new System.Windows.Forms.Padding(4);
            this.TableH.Name = "TableH";
            this.TableH.Size = new System.Drawing.Size(160, 24);
            this.TableH.TabIndex = 33;
            // 
            // TableG
            // 
            this.TableG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableG.FormattingEnabled = true;
            this.TableG.Items.AddRange(new object[] {
            "0",
            "50",
            "75",
            "100",
            "150",
            "200",
            "250",
            "500",
            "750",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "4000",
            "5000",
            "6000",
            "7500",
            "10000",
            "12500",
            "15000",
            "20000",
            "25000",
            "30000",
            "40000",
            "50000",
            "60000",
            "75000",
            "100000"});
            this.TableG.Location = new System.Drawing.Point(263, 305);
            this.TableG.Margin = new System.Windows.Forms.Padding(4);
            this.TableG.Name = "TableG";
            this.TableG.Size = new System.Drawing.Size(160, 24);
            this.TableG.TabIndex = 32;
            // 
            // TableF
            // 
            this.TableF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableF.FormattingEnabled = true;
            this.TableF.Items.AddRange(new object[] {
            "0",
            "50",
            "250",
            "350",
            "400",
            "500",
            "750",
            "1000",
            "1500",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7500",
            "10000",
            "10000",
            "12500",
            "15000",
            "20000",
            "25000",
            "30000",
            "40000",
            "50000",
            "60000",
            "75000",
            "100000"});
            this.TableF.Location = new System.Drawing.Point(261, 272);
            this.TableF.Margin = new System.Windows.Forms.Padding(4);
            this.TableF.Name = "TableF";
            this.TableF.Size = new System.Drawing.Size(160, 24);
            this.TableF.TabIndex = 31;
            // 
            // TableE
            // 
            this.TableE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableE.FormattingEnabled = true;
            this.TableE.Items.AddRange(new object[] {
            "0",
            "200",
            "300",
            "350",
            "1000",
            "1500",
            "2500",
            "3000",
            "3000",
            "4000",
            "5500",
            "6000",
            "7500",
            "8000",
            "9000",
            "10000",
            "13000",
            "13000",
            "15000",
            "20000",
            "25000",
            "30000",
            "30000",
            "35000",
            "35000",
            "40000",
            "50000",
            "75000",
            "100000"});
            this.TableE.Location = new System.Drawing.Point(261, 239);
            this.TableE.Margin = new System.Windows.Forms.Padding(4);
            this.TableE.Name = "TableE";
            this.TableE.Size = new System.Drawing.Size(160, 24);
            this.TableE.TabIndex = 30;
            // 
            // TableD
            // 
            this.TableD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableD.FormattingEnabled = true;
            this.TableD.Items.AddRange(new object[] {
            "0",
            "50",
            "50",
            "100",
            "150",
            "200",
            "250",
            "300",
            "400",
            "500",
            "500",
            "750",
            "1000",
            "1000",
            "1500",
            "1500",
            "2000",
            "2000",
            "3000",
            "4000",
            "5000",
            "7500",
            "7500",
            "10000",
            "10000",
            "15000",
            "15000",
            "20000",
            "20000",
            "25000",
            "30000",
            "50000"});
            this.TableD.Location = new System.Drawing.Point(263, 201);
            this.TableD.Margin = new System.Windows.Forms.Padding(4);
            this.TableD.Name = "TableD";
            this.TableD.Size = new System.Drawing.Size(160, 24);
            this.TableD.TabIndex = 29;
            // 
            // TableC
            // 
            this.TableC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableC.FormattingEnabled = true;
            this.TableC.Items.AddRange(new object[] {
            "0",
            "50",
            "100",
            "100",
            "150",
            "200",
            "250",
            "500",
            "500",
            "750",
            "1000",
            "1000",
            "1500",
            "2000",
            "2500",
            "5000",
            "5000",
            "7500",
            "10000",
            "10000",
            "15000",
            "20000",
            "50000"});
            this.TableC.Location = new System.Drawing.Point(263, 161);
            this.TableC.Margin = new System.Windows.Forms.Padding(4);
            this.TableC.Name = "TableC";
            this.TableC.Size = new System.Drawing.Size(160, 24);
            this.TableC.TabIndex = 28;
            // 
            // TableB
            // 
            this.TableB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableB.FormattingEnabled = true;
            this.TableB.Items.AddRange(new object[] {
            "0",
            "10",
            "15",
            "25",
            "50",
            "50",
            "75",
            "100",
            "100",
            "150",
            "200",
            "250",
            "500",
            "500",
            "750",
            "1000",
            "1000",
            "2500",
            "5000",
            "5000",
            "10000",
            "20000",
            "50000"});
            this.TableB.Location = new System.Drawing.Point(263, 128);
            this.TableB.Margin = new System.Windows.Forms.Padding(4);
            this.TableB.Name = "TableB";
            this.TableB.Size = new System.Drawing.Size(160, 24);
            this.TableB.TabIndex = 27;
            // 
            // TableA
            // 
            this.TableA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableA.FormattingEnabled = true;
            this.TableA.Items.AddRange(new object[] {
            "0",
            "1",
            "5",
            "10",
            "25",
            "50",
            "100",
            "200",
            "500",
            "1000",
            "5000",
            "10000",
            "50000"});
            this.TableA.Location = new System.Drawing.Point(261, 98);
            this.TableA.Margin = new System.Windows.Forms.Padding(4);
            this.TableA.Name = "TableA";
            this.TableA.Size = new System.Drawing.Size(160, 24);
            this.TableA.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 373);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Table I: Treasure Hoard";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 342);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 17);
            this.label17.TabIndex = 25;
            this.label17.Text = "Table H: Lair Treasure";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 309);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Table G: Spellcaster Gear";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 277);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "Table F: Combatant Gear";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 239);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Table E: Armor and Weapons";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 201);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Table D: Coins and Small Objects";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 166);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Table C: Art Objects";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Table B: Coins and Gems";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Table A: Coins";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "GP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Remaining Budget";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(184, 385);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "Loot";
            // 
            // Loot
            // 
            this.Loot.Location = new System.Drawing.Point(16, 412);
            this.Loot.Margin = new System.Windows.Forms.Padding(4);
            this.Loot.Multiline = true;
            this.Loot.Name = "Loot";
            this.Loot.ReadOnly = true;
            this.Loot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Loot.Size = new System.Drawing.Size(424, 203);
            this.Loot.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 631);
            this.Controls.Add(this.Loot);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BudgetAllocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TreasureTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TreasureBudget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChallengeRating);
            this.Controls.Add(this.RewardType);
            this.Controls.Add(this.CreatureType);
            this.Controls.Add(this.Generate_Treasure_Budget);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Loot Table";
            ((System.ComponentModel.ISupportInitialize)(this.ChallengeRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemaingBudget)).EndInit();
            this.BudgetAllocation.ResumeLayout(false);
            this.BudgetAllocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_Treasure_Budget;
        private System.Windows.Forms.ComboBox CreatureType;
        private System.Windows.Forms.ComboBox RewardType;
        private System.Windows.Forms.NumericUpDown ChallengeRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TreasureBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TreasureTypes;
        private System.Windows.Forms.NumericUpDown RemaingBudget;
        private System.Windows.Forms.GroupBox BudgetAllocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox RollList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ResetBudget;
        private System.Windows.Forms.Button AddI;
        private System.Windows.Forms.Button AddH;
        private System.Windows.Forms.Button AddG;
        private System.Windows.Forms.Button AddF;
        private System.Windows.Forms.Button AddE;
        private System.Windows.Forms.Button AddD;
        private System.Windows.Forms.Button AddC;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button AddA;
        private System.Windows.Forms.ComboBox TableI;
        private System.Windows.Forms.ComboBox TableH;
        private System.Windows.Forms.ComboBox TableG;
        private System.Windows.Forms.ComboBox TableF;
        private System.Windows.Forms.ComboBox TableE;
        private System.Windows.Forms.ComboBox TableD;
        private System.Windows.Forms.ComboBox TableC;
        private System.Windows.Forms.ComboBox TableB;
        private System.Windows.Forms.ComboBox TableA;
        private System.Windows.Forms.Button RollLoot;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.TextBox Loot;
    }
}

