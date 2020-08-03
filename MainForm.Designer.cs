namespace AlbionMT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ererwerwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Carleon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlackMarket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lymhurst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thetford = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bridgewatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FortSterling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownWidth = 350;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carleon,
            this.BlackMarket,
            this.Martloc,
            this.Lymhurst,
            this.Thetford,
            this.Bridgewatch,
            this.FortSterling});
            this.dataGridView1.Location = new System.Drawing.Point(8, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 407);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ererwerwToolStripMenuItem,
            this.werwerToolStripMenuItem,
            this.dfgdfToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ererwerwToolStripMenuItem
            // 
            this.ererwerwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdfgToolStripMenuItem});
            this.ererwerwToolStripMenuItem.Name = "ererwerwToolStripMenuItem";
            this.ererwerwToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.ererwerwToolStripMenuItem.Text = "File";
            // 
            // werwerToolStripMenuItem
            // 
            this.werwerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.werwerToolStripMenuItem.Name = "werwerToolStripMenuItem";
            this.werwerToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.werwerToolStripMenuItem.Text = "Lang";
            // 
            // dfgdfgToolStripMenuItem
            // 
            this.dfgdfgToolStripMenuItem.Name = "dfgdfgToolStripMenuItem";
            this.dfgdfgToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dfgdfgToolStripMenuItem.Text = "Exit";
            // 
            // dfgdfToolStripMenuItem1
            // 
            this.dfgdfToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.dfgdfToolStripMenuItem1.Name = "dfgdfToolStripMenuItem1";
            this.dfgdfToolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.dfgdfToolStripMenuItem1.Text = "Others";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "PL",
            "ENG"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Pokaż wykres";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 31);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(807, 517);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mult item";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Craft calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(799, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Zorro";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Carleon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Carleon.DefaultCellStyle = dataGridViewCellStyle1;
            this.Carleon.HeaderText = "Carleon";
            this.Carleon.Name = "Carleon";
            // 
            // BlackMarket
            // 
            this.BlackMarket.HeaderText = "Black Market";
            this.BlackMarket.Name = "BlackMarket";
            // 
            // Martloc
            // 
            this.Martloc.HeaderText = "Martloc";
            this.Martloc.Name = "Martloc";
            // 
            // Lymhurst
            // 
            this.Lymhurst.HeaderText = "Lymhurst";
            this.Lymhurst.Name = "Lymhurst";
            // 
            // Thetford
            // 
            this.Thetford.HeaderText = "Thetford";
            this.Thetford.Name = "Thetford";
            // 
            // Bridgewatch
            // 
            this.Bridgewatch.HeaderText = "Bridgewatch";
            this.Bridgewatch.Name = "Bridgewatch";
            // 
            // FortSterling
            // 
            this.FortSterling.HeaderText = "Fort Sterling";
            this.FortSterling.Name = "FortSterling";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(638, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 62);
            this.button3.TabIndex = 6;
            this.button3.Text = "Wyprowadź psa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(807, 550);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AlbionMT by @Reyzeee";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ererwerwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem werwerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgdfToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carleon;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlackMarket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lymhurst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thetford;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bridgewatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn FortSterling;
        private System.Windows.Forms.Button button3;
    }
}

