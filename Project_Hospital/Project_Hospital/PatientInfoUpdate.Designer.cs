namespace Project_Hospital
{
    partial class PatientInfoUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfoUpdate));
            this.BtUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GENDER = new System.Windows.Forms.ComboBox();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxTPasW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxTSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxTName = new System.Windows.Forms.TextBox();
            this.MTBCN = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtUpdate
            // 
            this.BtUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUpdate.Location = new System.Drawing.Point(193, 299);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(143, 29);
            this.BtUpdate.TabIndex = 30;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = false;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(98, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 29;
            this.label7.Text = "Gender:";
            // 
            // GENDER
            // 
            this.GENDER.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GENDER.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDER.FormattingEnabled = true;
            this.GENDER.Items.AddRange(new object[] {
            "MAN",
            "WOMEN"});
            this.GENDER.Location = new System.Drawing.Point(193, 252);
            this.GENDER.Name = "GENDER";
            this.GENDER.Size = new System.Drawing.Size(143, 29);
            this.GENDER.TabIndex = 6;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(193, 165);
            this.PhoneNumber.Mask = "(999) 000-0000";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(143, 29);
            this.PhoneNumber.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 27);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone Number:";
            // 
            // TxTPasW
            // 
            this.TxTPasW.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxTPasW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTPasW.Location = new System.Drawing.Point(193, 208);
            this.TxTPasW.Name = "TxTPasW";
            this.TxTPasW.Size = new System.Drawing.Size(143, 29);
            this.TxTPasW.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(77, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Password:";
            // 
            // TxTSN
            // 
            this.TxTSN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxTSN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTSN.Location = new System.Drawing.Point(193, 121);
            this.TxTSN.Name = "TxTSN";
            this.TxTSN.Size = new System.Drawing.Size(143, 29);
            this.TxTSN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "SurName:";
            // 
            // TxTName
            // 
            this.TxTName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxTName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTName.Location = new System.Drawing.Point(193, 76);
            this.TxTName.Name = "TxTName";
            this.TxTName.Size = new System.Drawing.Size(143, 29);
            this.TxTName.TabIndex = 2;
            // 
            // MTBCN
            // 
            this.MTBCN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MTBCN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBCN.Location = new System.Drawing.Point(193, 32);
            this.MTBCN.Mask = "00000000000";
            this.MTBCN.Name = "MTBCN";
            this.MTBCN.Size = new System.Drawing.Size(143, 29);
            this.MTBCN.TabIndex = 1;
            this.MTBCN.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Citizen Number:";
            // 
            // PatientInfoUpdate
            // 
            this.AcceptButton = this.BtUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 358);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GENDER);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxTPasW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxTSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxTName);
            this.Controls.Add(this.MTBCN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatientInfoUpdate";
            this.Text = "Info Update";
            this.Load += new System.EventHandler(this.PatientInfoUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox GENDER;
        private System.Windows.Forms.MaskedTextBox PhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxTPasW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxTSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxTName;
        private System.Windows.Forms.MaskedTextBox MTBCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}