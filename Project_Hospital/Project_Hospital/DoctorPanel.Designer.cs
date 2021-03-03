namespace Project_Hospital
{
    partial class DoctorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.TXNAME = new System.Windows.Forms.TextBox();
            this.CBBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MTBCN = new System.Windows.Forms.MaskedTextBox();
            this.TXSURNAME = new System.Windows.Forms.TextBox();
            this.TXPassword = new System.Windows.Forms.TextBox();
            this.BtAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtRemv = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(94, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch:";
            // 
            // TXNAME
            // 
            this.TXNAME.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXNAME.Location = new System.Drawing.Point(165, 29);
            this.TXNAME.Name = "TXNAME";
            this.TXNAME.Size = new System.Drawing.Size(97, 26);
            this.TXNAME.TabIndex = 1;
            // 
            // CBBranch
            // 
            this.CBBranch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBBranch.FormattingEnabled = true;
            this.CBBranch.Location = new System.Drawing.Point(166, 94);
            this.CBBranch.Name = "CBBranch";
            this.CBBranch.Size = new System.Drawing.Size(96, 27);
            this.CBBranch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(100, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(74, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(31, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Citizen Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(72, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // MTBCN
            // 
            this.MTBCN.Location = new System.Drawing.Point(166, 159);
            this.MTBCN.Mask = "00000000000";
            this.MTBCN.Name = "MTBCN";
            this.MTBCN.Size = new System.Drawing.Size(96, 29);
            this.MTBCN.TabIndex = 5;
            // 
            // TXSURNAME
            // 
            this.TXSURNAME.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXSURNAME.Location = new System.Drawing.Point(165, 61);
            this.TXSURNAME.Name = "TXSURNAME";
            this.TXSURNAME.Size = new System.Drawing.Size(97, 26);
            this.TXSURNAME.TabIndex = 2;
            // 
            // TXPassword
            // 
            this.TXPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXPassword.Location = new System.Drawing.Point(166, 127);
            this.TXPassword.Name = "TXPassword";
            this.TXPassword.Size = new System.Drawing.Size(96, 26);
            this.TXPassword.TabIndex = 4;
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtAdd.Location = new System.Drawing.Point(39, 213);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(101, 32);
            this.BtAdd.TabIndex = 10;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 277);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtRemv
            // 
            this.BtRemv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtRemv.Location = new System.Drawing.Point(165, 213);
            this.BtRemv.Name = "BtRemv";
            this.BtRemv.Size = new System.Drawing.Size(101, 32);
            this.BtRemv.TabIndex = 12;
            this.BtRemv.Text = "Remove";
            this.BtRemv.UseVisualStyleBackColor = false;
            this.BtRemv.Click += new System.EventHandler(this.BtRemv_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtUpdate.Location = new System.Drawing.Point(89, 251);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(143, 32);
            this.BtUpdate.TabIndex = 13;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = false;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 302);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtRemv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.TXPassword);
            this.Controls.Add(this.TXSURNAME);
            this.Controls.Add(this.MTBCN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBBranch);
            this.Controls.Add(this.TXNAME);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "DoctorPanel";
            this.Text = "Doctor Panel";
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXNAME;
        private System.Windows.Forms.ComboBox CBBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MTBCN;
        private System.Windows.Forms.TextBox TXSURNAME;
        private System.Windows.Forms.TextBox TXPassword;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtRemv;
        private System.Windows.Forms.Button BtUpdate;
    }
}