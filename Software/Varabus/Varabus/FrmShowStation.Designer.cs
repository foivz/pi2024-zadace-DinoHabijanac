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
            this.SuspendLayout();
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.Location = new System.Drawing.Point(570, 360);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(188, 53);
            this.btnDeleteStation.TabIndex = 0;
            this.btnDeleteStation.Text = "Obriši stanicu";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(570, 211);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(188, 54);
            this.btnAddStation.TabIndex = 2;
            this.btnAddStation.Text = "Dodaj stanicu";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // btnEditStation
            // 
            this.btnEditStation.Location = new System.Drawing.Point(570, 286);
            this.btnEditStation.Name = "btnEditStation";
            this.btnEditStation.Size = new System.Drawing.Size(188, 56);
            this.btnEditStation.TabIndex = 3;
            this.btnEditStation.Text = "Izmjeni stanicu";
            this.btnEditStation.UseVisualStyleBackColor = true;
            this.btnEditStation.Click += new System.EventHandler(this.btnEditStation_Click);
            // 
            // FrmShowStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Button btnEditStation;
    }
}

