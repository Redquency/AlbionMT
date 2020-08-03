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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Carleon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlackMarket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lymhurst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thetford = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bridgewatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FortSterling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownWidth = 350;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carleon,
            this.BlackMarket,
            this.Martloc,
            this.Lymhurst,
            this.Thetford,
            this.Bridgewatch,
            this.FortSterling});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Carleon
            // 
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "AlbionMT by @Reyzeee";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carleon;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlackMarket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lymhurst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thetford;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bridgewatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn FortSterling;
    }
}

