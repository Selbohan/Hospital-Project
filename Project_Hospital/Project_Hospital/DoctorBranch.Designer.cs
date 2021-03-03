namespace Project_Hospital
{
    partial class DoctorBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorBranch));
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtRemv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtAdd = new System.Windows.Forms.Button();
            this.TXNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtUpdate
            // 
            this.BtUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtUpdate.Location = new System.Drawing.Point(75, 208);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(143, 32);
            this.BtUpdate.TabIndex = 27;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = false;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // BtRemv
            // 
            this.BtRemv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtRemv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtRemv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtRemv.Location = new System.Drawing.Point(160, 168);
            this.BtRemv.Name = "BtRemv";
            this.BtRemv.Size = new System.Drawing.Size(101, 32);
            this.BtRemv.TabIndex = 26;
            this.BtRemv.Text = "Remove";
            this.BtRemv.UseVisualStyleBackColor = false;
            this.BtRemv.Click += new System.EventHandler(this.BtRemv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(286, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 231);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtAdd.Location = new System.Drawing.Point(35, 168);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(101, 32);
            this.BtAdd.TabIndex = 24;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // TXNAME
            // 
            this.TXNAME.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXNAME.Location = new System.Drawing.Point(160, 94);
            this.TXNAME.Name = "TXNAME";
            this.TXNAME.Size = new System.Drawing.Size(120, 29);
            this.TXNAME.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Branch Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Branch Id:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TXID
            // 
            this.TXID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXID.Location = new System.Drawing.Point(160, 49);
            this.TXID.Name = "TXID";
            this.TXID.Size = new System.Drawing.Size(120, 29);
            this.TXID.TabIndex = 15;
            // 
            // DoctorBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 257);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtRemv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.TXNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXID);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DoctorBranch";
            this.Text = "Branch Panel";
            this.Load += new System.EventHandler(this.DoctorBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button BtRemv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.TextBox TXNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXID;
    }
}