namespace Battletech
{
    partial class MainForm
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
            this.TechnologyTab = new System.Windows.Forms.TabControl();
            this.TechnologyTabPage = new System.Windows.Forms.TabPage();
            this.TechnologyGroupBox = new System.Windows.Forms.GroupBox();
            this.ClanRadio = new System.Windows.Forms.RadioButton();
            this.InnerSphereRadio = new System.Windows.Forms.RadioButton();
            this.InternalComponentsTabPage = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ArmorGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BattlemechNameGroupBox = new System.Windows.Forms.GroupBox();
            this.YearRatingGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.YearRatingCheckBox = new System.Windows.Forms.CheckBox();
            this.OmniMechCheckBox = new System.Windows.Forms.CheckBox();
            this.MechWeightGroupBox = new System.Windows.Forms.GroupBox();
            this.LightMechRadio = new System.Windows.Forms.RadioButton();
            this.MediumMechRadio = new System.Windows.Forms.RadioButton();
            this.HeavyMechRadio = new System.Windows.Forms.RadioButton();
            this.AssualtMechRadio = new System.Windows.Forms.RadioButton();
            this.FactionGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.FactionCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.InternalStructureGroupBox = new System.Windows.Forms.GroupBox();
            this.TechnologyTab.SuspendLayout();
            this.TechnologyTabPage.SuspendLayout();
            this.TechnologyGroupBox.SuspendLayout();
            this.InternalComponentsTabPage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.ArmorGroupBox.SuspendLayout();
            this.BattlemechNameGroupBox.SuspendLayout();
            this.YearRatingGroupBox.SuspendLayout();
            this.MechWeightGroupBox.SuspendLayout();
            this.FactionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.InternalStructureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TechnologyTab
            // 
            this.TechnologyTab.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TechnologyTab.Controls.Add(this.TechnologyTabPage);
            this.TechnologyTab.Controls.Add(this.InternalComponentsTabPage);
            this.TechnologyTab.Controls.Add(this.tabPage3);
            this.TechnologyTab.Controls.Add(this.tabPage4);
            this.TechnologyTab.Controls.Add(this.tabPage5);
            this.TechnologyTab.Controls.Add(this.tabPage6);
            this.TechnologyTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.TechnologyTab.Location = new System.Drawing.Point(484, 0);
            this.TechnologyTab.Multiline = true;
            this.TechnologyTab.Name = "TechnologyTab";
            this.TechnologyTab.SelectedIndex = 0;
            this.TechnologyTab.Size = new System.Drawing.Size(532, 741);
            this.TechnologyTab.TabIndex = 0;
            // 
            // TechnologyTabPage
            // 
            this.TechnologyTabPage.Controls.Add(this.FactionCheckBox);
            this.TechnologyTabPage.Controls.Add(this.FactionGroupBox);
            this.TechnologyTabPage.Controls.Add(this.MechWeightGroupBox);
            this.TechnologyTabPage.Controls.Add(this.YearRatingCheckBox);
            this.TechnologyTabPage.Controls.Add(this.YearRatingGroupBox);
            this.TechnologyTabPage.Controls.Add(this.BattlemechNameGroupBox);
            this.TechnologyTabPage.Controls.Add(this.label3);
            this.TechnologyTabPage.Controls.Add(this.TechnologyGroupBox);
            this.TechnologyTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TechnologyTabPage.Location = new System.Drawing.Point(4, 4);
            this.TechnologyTabPage.Name = "TechnologyTabPage";
            this.TechnologyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TechnologyTabPage.Size = new System.Drawing.Size(505, 733);
            this.TechnologyTabPage.TabIndex = 0;
            this.TechnologyTabPage.Text = "Technology Base ";
            this.TechnologyTabPage.UseVisualStyleBackColor = true;
            // 
            // TechnologyGroupBox
            // 
            this.TechnologyGroupBox.Controls.Add(this.OmniMechCheckBox);
            this.TechnologyGroupBox.Controls.Add(this.ClanRadio);
            this.TechnologyGroupBox.Controls.Add(this.InnerSphereRadio);
            this.TechnologyGroupBox.Location = new System.Drawing.Point(6, 8);
            this.TechnologyGroupBox.Name = "TechnologyGroupBox";
            this.TechnologyGroupBox.Size = new System.Drawing.Size(347, 47);
            this.TechnologyGroupBox.TabIndex = 12;
            this.TechnologyGroupBox.TabStop = false;
            this.TechnologyGroupBox.Text = "Technology Base:";
            this.TechnologyGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ClanRadio
            // 
            this.ClanRadio.AutoSize = true;
            this.ClanRadio.Location = new System.Drawing.Point(6, 19);
            this.ClanRadio.Name = "ClanRadio";
            this.ClanRadio.Size = new System.Drawing.Size(46, 17);
            this.ClanRadio.TabIndex = 0;
            this.ClanRadio.TabStop = true;
            this.ClanRadio.Text = "Clan";
            this.ClanRadio.UseVisualStyleBackColor = true;
            // 
            // InnerSphereRadio
            // 
            this.InnerSphereRadio.AutoSize = true;
            this.InnerSphereRadio.Location = new System.Drawing.Point(58, 19);
            this.InnerSphereRadio.Name = "InnerSphereRadio";
            this.InnerSphereRadio.Size = new System.Drawing.Size(86, 17);
            this.InnerSphereRadio.TabIndex = 1;
            this.InnerSphereRadio.TabStop = true;
            this.InnerSphereRadio.Text = "Inner Sphere";
            this.InnerSphereRadio.UseVisualStyleBackColor = true;
            this.InnerSphereRadio.CheckedChanged += new System.EventHandler(this.InnerSphereRadio_CheckedChanged);
            // 
            // InternalComponentsTabPage
            // 
            this.InternalComponentsTabPage.Controls.Add(this.InternalStructureGroupBox);
            this.InternalComponentsTabPage.Location = new System.Drawing.Point(4, 4);
            this.InternalComponentsTabPage.Name = "InternalComponentsTabPage";
            this.InternalComponentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InternalComponentsTabPage.Size = new System.Drawing.Size(505, 733);
            this.InternalComponentsTabPage.TabIndex = 1;
            this.InternalComponentsTabPage.Text = "Internal Components";
            this.InternalComponentsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ArmorGroupBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(505, 733);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Armor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ArmorGroupBox
            // 
            this.ArmorGroupBox.Controls.Add(this.radioButton4);
            this.ArmorGroupBox.Controls.Add(this.radioButton3);
            this.ArmorGroupBox.Controls.Add(this.radioButton2);
            this.ArmorGroupBox.Controls.Add(this.radioButton1);
            this.ArmorGroupBox.Location = new System.Drawing.Point(6, 8);
            this.ArmorGroupBox.Name = "ArmorGroupBox";
            this.ArmorGroupBox.Size = new System.Drawing.Size(376, 110);
            this.ArmorGroupBox.TabIndex = 0;
            this.ArmorGroupBox.TabStop = false;
            this.ArmorGroupBox.Text = "groupBox2";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(156, 55);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(156, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(505, 733);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Weapons";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(505, 733);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(505, 733);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clan Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Inner Sphere Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Input Clan Name";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(115, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Input Inner Sphere Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Manufactoring Year:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // BattlemechNameGroupBox
            // 
            this.BattlemechNameGroupBox.Controls.Add(this.label2);
            this.BattlemechNameGroupBox.Controls.Add(this.label1);
            this.BattlemechNameGroupBox.Controls.Add(this.textBox1);
            this.BattlemechNameGroupBox.Controls.Add(this.textBox2);
            this.BattlemechNameGroupBox.Location = new System.Drawing.Point(6, 61);
            this.BattlemechNameGroupBox.Name = "BattlemechNameGroupBox";
            this.BattlemechNameGroupBox.Size = new System.Drawing.Size(347, 81);
            this.BattlemechNameGroupBox.TabIndex = 20;
            this.BattlemechNameGroupBox.TabStop = false;
            this.BattlemechNameGroupBox.Text = "Battlemech Name:";
            // 
            // YearRatingGroupBox
            // 
            this.YearRatingGroupBox.Controls.Add(this.textBox4);
            this.YearRatingGroupBox.Controls.Add(this.label5);
            this.YearRatingGroupBox.Controls.Add(this.label4);
            this.YearRatingGroupBox.Controls.Add(this.textBox3);
            this.YearRatingGroupBox.Enabled = false;
            this.YearRatingGroupBox.Location = new System.Drawing.Point(6, 148);
            this.YearRatingGroupBox.Name = "YearRatingGroupBox";
            this.YearRatingGroupBox.Size = new System.Drawing.Size(347, 87);
            this.YearRatingGroupBox.TabIndex = 21;
            this.YearRatingGroupBox.TabStop = false;
            this.YearRatingGroupBox.Text = "Manufacturing Year and Technology Rating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Technology Rating:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // YearRatingCheckBox
            // 
            this.YearRatingCheckBox.AutoSize = true;
            this.YearRatingCheckBox.Location = new System.Drawing.Point(359, 182);
            this.YearRatingCheckBox.Name = "YearRatingCheckBox";
            this.YearRatingCheckBox.Size = new System.Drawing.Size(125, 17);
            this.YearRatingCheckBox.TabIndex = 22;
            this.YearRatingCheckBox.Text = "Use Year and Rating";
            this.YearRatingCheckBox.UseVisualStyleBackColor = true;
            // 
            // OmniMechCheckBox
            // 
            this.OmniMechCheckBox.AutoSize = true;
            this.OmniMechCheckBox.Location = new System.Drawing.Point(161, 18);
            this.OmniMechCheckBox.Name = "OmniMechCheckBox";
            this.OmniMechCheckBox.Size = new System.Drawing.Size(77, 17);
            this.OmniMechCheckBox.TabIndex = 2;
            this.OmniMechCheckBox.Text = "OmniMech";
            this.OmniMechCheckBox.UseVisualStyleBackColor = true;
            // 
            // MechWeightGroupBox
            // 
            this.MechWeightGroupBox.Controls.Add(this.label6);
            this.MechWeightGroupBox.Controls.Add(this.numericUpDown2);
            this.MechWeightGroupBox.Controls.Add(this.AssualtMechRadio);
            this.MechWeightGroupBox.Controls.Add(this.HeavyMechRadio);
            this.MechWeightGroupBox.Controls.Add(this.MediumMechRadio);
            this.MechWeightGroupBox.Controls.Add(this.LightMechRadio);
            this.MechWeightGroupBox.Location = new System.Drawing.Point(6, 300);
            this.MechWeightGroupBox.Name = "MechWeightGroupBox";
            this.MechWeightGroupBox.Size = new System.Drawing.Size(347, 100);
            this.MechWeightGroupBox.TabIndex = 23;
            this.MechWeightGroupBox.TabStop = false;
            this.MechWeightGroupBox.Text = "Weight Classes";
            // 
            // LightMechRadio
            // 
            this.LightMechRadio.AutoSize = true;
            this.LightMechRadio.Location = new System.Drawing.Point(9, 20);
            this.LightMechRadio.Name = "LightMechRadio";
            this.LightMechRadio.Size = new System.Drawing.Size(105, 17);
            this.LightMechRadio.TabIndex = 3;
            this.LightMechRadio.TabStop = true;
            this.LightMechRadio.Text = "Light BattleMech";
            this.LightMechRadio.UseVisualStyleBackColor = true;
            // 
            // MediumMechRadio
            // 
            this.MediumMechRadio.AutoSize = true;
            this.MediumMechRadio.Location = new System.Drawing.Point(161, 20);
            this.MediumMechRadio.Name = "MediumMechRadio";
            this.MediumMechRadio.Size = new System.Drawing.Size(119, 17);
            this.MediumMechRadio.TabIndex = 4;
            this.MediumMechRadio.TabStop = true;
            this.MediumMechRadio.Text = "Medium BattleMech";
            this.MediumMechRadio.UseVisualStyleBackColor = true;
            // 
            // HeavyMechRadio
            // 
            this.HeavyMechRadio.AutoSize = true;
            this.HeavyMechRadio.Location = new System.Drawing.Point(9, 43);
            this.HeavyMechRadio.Name = "HeavyMechRadio";
            this.HeavyMechRadio.Size = new System.Drawing.Size(113, 17);
            this.HeavyMechRadio.TabIndex = 5;
            this.HeavyMechRadio.TabStop = true;
            this.HeavyMechRadio.Text = "Heavy BattleMech";
            this.HeavyMechRadio.UseVisualStyleBackColor = true;
            this.HeavyMechRadio.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // AssualtMechRadio
            // 
            this.AssualtMechRadio.AutoSize = true;
            this.AssualtMechRadio.Location = new System.Drawing.Point(161, 43);
            this.AssualtMechRadio.Name = "AssualtMechRadio";
            this.AssualtMechRadio.Size = new System.Drawing.Size(116, 17);
            this.AssualtMechRadio.TabIndex = 6;
            this.AssualtMechRadio.TabStop = true;
            this.AssualtMechRadio.Text = "Assualt BattleMech";
            this.AssualtMechRadio.UseVisualStyleBackColor = true;
            // 
            // FactionGroupBox
            // 
            this.FactionGroupBox.Controls.Add(this.label7);
            this.FactionGroupBox.Controls.Add(this.comboBox1);
            this.FactionGroupBox.Enabled = false;
            this.FactionGroupBox.Location = new System.Drawing.Point(6, 241);
            this.FactionGroupBox.Name = "FactionGroupBox";
            this.FactionGroupBox.Size = new System.Drawing.Size(347, 53);
            this.FactionGroupBox.TabIndex = 24;
            this.FactionGroupBox.TabStop = false;
            this.FactionGroupBox.Text = "Faction:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(154, 66);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Select Tonnage:";
            // 
            // FactionCheckBox
            // 
            this.FactionCheckBox.AutoSize = true;
            this.FactionCheckBox.Location = new System.Drawing.Point(359, 259);
            this.FactionCheckBox.Name = "FactionCheckBox";
            this.FactionCheckBox.Size = new System.Drawing.Size(83, 17);
            this.FactionCheckBox.TabIndex = 25;
            this.FactionCheckBox.Text = "Use Faction";
            this.FactionCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Select Faction:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 723);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Remaining Tonnage:";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(152, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Standard Internal Structure";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(177, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(161, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Endo Steel Internal Structure";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // InternalStructureGroupBox
            // 
            this.InternalStructureGroupBox.Controls.Add(this.radioButton5);
            this.InternalStructureGroupBox.Controls.Add(this.radioButton6);
            this.InternalStructureGroupBox.Location = new System.Drawing.Point(6, 8);
            this.InternalStructureGroupBox.Name = "InternalStructureGroupBox";
            this.InternalStructureGroupBox.Size = new System.Drawing.Size(347, 46);
            this.InternalStructureGroupBox.TabIndex = 2;
            this.InternalStructureGroupBox.TabStop = false;
            this.InternalStructureGroupBox.Text = "Internal Structure:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TechnologyTab);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Battletech Designer";
            this.TechnologyTab.ResumeLayout(false);
            this.TechnologyTabPage.ResumeLayout(false);
            this.TechnologyTabPage.PerformLayout();
            this.TechnologyGroupBox.ResumeLayout(false);
            this.TechnologyGroupBox.PerformLayout();
            this.InternalComponentsTabPage.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ArmorGroupBox.ResumeLayout(false);
            this.ArmorGroupBox.PerformLayout();
            this.BattlemechNameGroupBox.ResumeLayout(false);
            this.BattlemechNameGroupBox.PerformLayout();
            this.YearRatingGroupBox.ResumeLayout(false);
            this.YearRatingGroupBox.PerformLayout();
            this.MechWeightGroupBox.ResumeLayout(false);
            this.MechWeightGroupBox.PerformLayout();
            this.FactionGroupBox.ResumeLayout(false);
            this.FactionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.InternalStructureGroupBox.ResumeLayout(false);
            this.InternalStructureGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TechnologyTab;
        private System.Windows.Forms.TabPage TechnologyTabPage;
        private System.Windows.Forms.TabPage InternalComponentsTabPage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RadioButton InnerSphereRadio;
        private System.Windows.Forms.RadioButton ClanRadio;
        private System.Windows.Forms.GroupBox TechnologyGroupBox;
        private System.Windows.Forms.GroupBox ArmorGroupBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox YearRatingGroupBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox BattlemechNameGroupBox;
        private System.Windows.Forms.CheckBox YearRatingCheckBox;
        private System.Windows.Forms.GroupBox MechWeightGroupBox;
        private System.Windows.Forms.RadioButton HeavyMechRadio;
        private System.Windows.Forms.RadioButton MediumMechRadio;
        private System.Windows.Forms.RadioButton LightMechRadio;
        private System.Windows.Forms.CheckBox OmniMechCheckBox;
        private System.Windows.Forms.RadioButton AssualtMechRadio;
        private System.Windows.Forms.GroupBox FactionGroupBox;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox FactionCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox InternalStructureGroupBox;
    }
}

