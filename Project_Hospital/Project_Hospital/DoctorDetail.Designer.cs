namespace Project_Hospital
{
    partial class DoctorDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNSN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RCBDetail = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtExit = new System.Windows.Forms.Button();
            this.BtMessages = new System.Windows.Forms.Button();
            this.BtInfoUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.LblNSN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblCN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome Doctor";
            // 
            // LblNSN
            // 
            this.LblNSN.AutoSize = true;
            this.LblNSN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNSN.Location = new System.Drawing.Point(151, 77);
            this.LblNSN.Name = "LblNSN";
            this.LblNSN.Size = new System.Drawing.Size(110, 21);
            this.LblNSN.TabIndex = 15;
            this.LblNSN.Text = "NULL NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
            // 
            // LblCN
            // 
            this.LblCN.AutoSize = true;
            this.LblCN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCN.Location = new System.Drawing.Point(151, 44);
            this.LblCN.Name = "LblCN";
            this.LblCN.Size = new System.Drawing.Size(109, 21);
            this.LblCN.TabIndex = 13;
            this.LblCN.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Citizen Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.RCBDetail);
            this.groupBox2.Location = new System.Drawing.Point(297, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rendezvous Detail";
            // 
            // RCBDetail
            // 
            this.RCBDetail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RCBDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCBDetail.Cursor = System.Windows.Forms.Cursors.No;
            this.RCBDetail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RCBDetail.Location = new System.Drawing.Point(6, 23);
            this.RCBDetail.Name = "RCBDetail";
            this.RCBDetail.Size = new System.Drawing.Size(505, 102);
            this.RCBDetail.TabIndex = 1;
            this.RCBDetail.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(11, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 307);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendezvous List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.BtExit);
            this.groupBox4.Controls.Add(this.BtMessages);
            this.groupBox4.Controls.Add(this.BtInfoUpdate);
            this.groupBox4.Location = new System.Drawing.Point(11, 469);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(802, 90);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quick Page";
            // 
            // BtExit
            // 
            this.BtExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtExit.Location = new System.Drawing.Point(569, 28);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(144, 39);
            this.BtExit.TabIndex = 3;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = false;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // BtMessages
            // 
            this.BtMessages.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtMessages.Location = new System.Drawing.Point(328, 28);
            this.BtMessages.Name = "BtMessages";
            this.BtMessages.Size = new System.Drawing.Size(144, 39);
            this.BtMessages.TabIndex = 1;
            this.BtMessages.Text = "Messages";
            this.BtMessages.UseVisualStyleBackColor = false;
            this.BtMessages.Click += new System.EventHandler(this.BtMessages_Click);
            // 
            // BtInfoUpdate
            // 
            this.BtInfoUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtInfoUpdate.Location = new System.Drawing.Point(92, 28);
            this.BtInfoUpdate.Name = "BtInfoUpdate";
            this.BtInfoUpdate.Size = new System.Drawing.Size(144, 39);
            this.BtInfoUpdate.TabIndex = 0;
            this.BtInfoUpdate.Text = "Info Update";
            this.BtInfoUpdate.UseVisualStyleBackColor = false;
            this.BtInfoUpdate.Click += new System.EventHandler(this.BtInfoUpdate_Click);
            // 
            // DoctorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "DoctorDetail";
            this.Text = "Doctor Panel";
            this.Load += new System.EventHandler(this.DoctorDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RCBDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.Button BtMessages;
        private System.Windows.Forms.Button BtInfoUpdate;
    }
}