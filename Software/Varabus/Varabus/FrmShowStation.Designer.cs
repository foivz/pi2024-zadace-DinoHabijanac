namespace Varabus
{
    partial class FrmShowStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowStation));
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.btnEditStation = new System.Windows.Forms.Button();
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.numSearch = new System.Windows.Forms.NumericUpDown();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteStation.Location = new System.Drawing.Point(1302, 424);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(106, 82);
            this.btnDeleteStation.TabIndex = 0;
            this.btnDeleteStation.Text = "Obriši stanicu";
            this.btnDeleteStation.UseVisualStyleBackColor = false;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // btnAddStation
            // 
            this.btnAddStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddStation.Location = new System.Drawing.Point(1302, 210);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(106, 82);
            this.btnAddStation.TabIndex = 2;
            this.btnAddStation.Text = "Dodaj stanicu";
            this.btnAddStation.UseVisualStyleBackColor = false;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // btnEditStation
            // 
            this.btnEditStation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditStation.Location = new System.Drawing.Point(1302, 316);
            this.btnEditStation.Name = "btnEditStation";
            this.btnEditStation.Size = new System.Drawing.Size(106, 82);
            this.btnEditStation.TabIndex = 3;
            this.btnEditStation.Text = "Izmjeni stanicu";
            this.btnEditStation.UseVisualStyleBackColor = false;
            this.btnEditStation.Click += new System.EventHandler(this.btnEditStation_Click);
            // 
            // dgvStations
            // 
            this.dgvStations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStations.Location = new System.Drawing.Point(12, 12);
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.ReadOnly = true;
            this.dgvStations.RowHeadersWidth = 5;
            this.dgvStations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStations.RowTemplate.Height = 24;
            this.dgvStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStations.Size = new System.Drawing.Size(1268, 525);
            this.dgvStations.TabIndex = 4;
            this.dgvStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStations_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.Location = new System.Drawing.Point(1302, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 82);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Pretraži po liniji";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // numSearch
            // 
            this.numSearch.Location = new System.Drawing.Point(1302, 132);
            this.numSearch.Name = "numSearch";
            this.numSearch.Size = new System.Drawing.Size(106, 22);
            this.numSearch.TabIndex = 7;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(1302, 160);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(106, 23);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Prikaži sve";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // FrmShowStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1429, 549);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.numSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvStations);
            this.Controls.Add(this.btnEditStation);
            this.Controls.Add(this.btnAddStation);
            this.Controls.Add(this.btnDeleteStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz stanica";
            this.Load += new System.EventHandler(this.FrmShowStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Button btnEditStation;
        private System.Windows.Forms.DataGridView dgvStations;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown numSearch;
        private System.Windows.Forms.Button btnShowAll;
    }
}

