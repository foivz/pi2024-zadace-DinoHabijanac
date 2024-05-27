namespace Varabus
{
    partial class FrmDataChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataChange));
            this.txtStation = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSchedule = new System.Windows.Forms.TextBox();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.numLine = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLine)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(308, 107);
            this.txtStation.Multiline = true;
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(334, 22);
            this.txtStation.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(308, 160);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(334, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(308, 61);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(334, 22);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtSchedule
            // 
            this.txtSchedule.Location = new System.Drawing.Point(308, 260);
            this.txtSchedule.Multiline = true;
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(334, 45);
            this.txtSchedule.TabIndex = 3;
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(308, 326);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(162, 66);
            this.btnAddStation.TabIndex = 6;
            this.btnAddStation.Text = "Unesi izmjene";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(69, 64);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(59, 16);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Unesi id:";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(69, 110);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(93, 16);
            this.lblStation.TabIndex = 8;
            this.lblStation.Text = "Unesi stanicu: ";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(69, 263);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(106, 16);
            this.lblSchedule.TabIndex = 9;
            this.lblSchedule.Text = "Unesi raspored: ";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(69, 217);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(77, 16);
            this.lblLine.TabIndex = 10;
            this.lblLine.Text = "Unesi liniju: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(69, 163);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(205, 16);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Unesi dodatan opis (opcionalno):";
            // 
            // numLine
            // 
            this.numLine.Location = new System.Drawing.Point(308, 215);
            this.numLine.Name = "numLine";
            this.numLine.Size = new System.Drawing.Size(89, 22);
            this.numLine.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(480, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 66);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmDataChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 435);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numLine);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAddStation);
            this.Controls.Add(this.txtSchedule);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena podataka";
            this.Load += new System.EventHandler(this.FrmDataChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSchedule;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.NumericUpDown numLine;
        private System.Windows.Forms.Button btnCancel;
    }
}