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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.Location = new System.Drawing.Point(1300, 328);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(106, 82);
            this.btnDeleteStation.TabIndex = 0;
            this.btnDeleteStation.Text = "Obriši stanicu";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(1300, 219);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(106, 82);
            this.btnAddStation.TabIndex = 2;
            this.btnAddStation.Text = "Dodaj stanicu";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // btnEditStation
            // 
            this.btnEditStation.Location = new System.Drawing.Point(1300, 436);
            this.btnEditStation.Name = "btnEditStation";
            this.btnEditStation.Size = new System.Drawing.Size(106, 82);
            this.btnEditStation.TabIndex = 3;
            this.btnEditStation.Text = "Izmjeni stanicu";
            this.btnEditStation.UseVisualStyleBackColor = true;
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
            // FrmShowStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1429, 549);
            this.Controls.Add(this.dgvStations);
            this.Controls.Add(this.btnEditStation);
            this.Controls.Add(this.btnAddStation);
            this.Controls.Add(this.btnDeleteStation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz stanica";
            this.Load += new System.EventHandler(this.FrmShowStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Button btnEditStation;
        private System.Windows.Forms.DataGridView dgvStations;
    }
}

