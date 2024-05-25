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
            this.txtLine = new System.Windows.Forms.TextBox();
            this.btnEditStation = new System.Windows.Forms.Button();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(308, 107);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(334, 22);
            this.txtStation.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(308, 160);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(334, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(308, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(334, 22);
            this.txtId.TabIndex = 2;
            // 
            // txtSchedule
            // 
            this.txtSchedule.Location = new System.Drawing.Point(308, 260);
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(334, 22);
            this.txtSchedule.TabIndex = 3;
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(308, 213);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(334, 22);
            this.txtLine.TabIndex = 4;
            // 
            // btnEditStation
            // 
            this.btnEditStation.Location = new System.Drawing.Point(462, 326);
            this.btnEditStation.Name = "btnEditStation";
            this.btnEditStation.Size = new System.Drawing.Size(109, 66);
            this.btnEditStation.TabIndex = 5;
            this.btnEditStation.Text = "Izmjeni postojeću stanicu";
            this.btnEditStation.UseVisualStyleBackColor = true;
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(308, 326);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(109, 66);
            this.btnAddStation.TabIndex = 6;
            this.btnAddStation.Text = "Unesi novu stanicu";
            this.btnAddStation.UseVisualStyleBackColor = true;
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
            // FrmDataChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 435);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAddStation);
            this.Controls.Add(this.btnEditStation);
            this.Controls.Add(this.txtLine);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSchedule;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Button btnEditStation;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblDescription;
    }
}